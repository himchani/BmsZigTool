using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace FWDLlibrary
{

	public struct S_HIB
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
		public byte[] IEEEAddr;
		public byte ChipId;
		public byte TxPower;
		public byte DataRate;
		public byte StackID;
		public byte Ch;									// 0x0B~0x1A
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
		public byte[] PanID;							// PanID[0]=[7:0], PanID[1]=[15:8]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
		public byte[] NwkAddr;							// NwkAddr[0]=[7:0], NwkAddr[1]=[15:8]
		public byte SecLevel;							// 0=No, 1=MIC32, 2=MIC64, 3=MIC128, 4=ENC, 5=ENCMIC32, 6=ENCMIC64, 7=ENCMIC128
		public byte PreConfig;							// 0x00 ~ 0xFF
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
		public byte[] NetworkKey;						// Nwk Security Key
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
		public byte[] Rsv_0;							// reserved
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
		public byte[] Rsv_EPID;							// Extended Pan ID         
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
		public byte[] Rsv_1;							// reserved
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
		public byte[] GeneralWord0;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
		public byte[] GeneralWord1;		
	}

	public struct inteldata {
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
		public byte []recdata;		//256
		public uint base_addr;
		public uint offset;
		public uint reclen;
		public uint rectype;
		//FILE * file;
		public int eof_found;
	} ;

	public delegate void MyDelegate(int num, int percent);
    public delegate void StatDelegate(int num, int ret);

    public class MG2470Cmd
	{

		MyDelegate prog_bar = null;
        public StatDelegate stat_func = null;

        string MG2470_FWRIT_DRIVER = "./driver/FWRIT.HEX";
		
		string MG2470_FREAD_B0_DRIVER = "./driver/FREAD_B0.HEX";
		//string MG2470_FREAD_B1_DRIVER = "./driver/FREAD_B1.HEX";
		//string MG2470_FREAD_B4_DRIVER = "./driver/FREAD_B4.HEX";

		const uint MG2470_DRIVER_CADDR = 0x0003;
		const uint MG2470_BUFFER_ADDR = 0x1000;

		const uint MG2470_HIB_OFFSET = 0x1000;
		const uint MG2470_HIB_SIZE = 64;

		const uint MG2470_FREAD_B0_CADDR = 0x8003;		
		const uint MG2470_FREAD_B1_CADDR = 0x0003;
		const uint MG2470_FREAD_B4_CADDR = 0x0003;

		public const uint MG2470_FLASH_PAGE_SIZE = 0x00200;
		public const uint MG2470_FLASH_INFO_SIZE = 0x00400;
		public const uint MG2470_FLASH_BANK_SIZE = 0x08000;

		public const byte MG2470_FLASH_MERS = 0x00;
		public const byte MG2470_FLASH_RERS = 0x01;
		public const byte MG2470_FLASH_PERS = 0x02;
		public const byte MG2470_FLASH_CSUM = 0x03;
		public const byte MG2470_FLASH_MISC = 0x04;
		public const byte MG2470_FLASH_EXEC = 0x05;
		public const byte MG2470_FLASH_STAT = 0x06;
		public const byte MG2470_XDATA_READ = 0x07;
		public const byte MG2470_XDATA_WRIT = 0x08;

		public byte[] CMD_SYNC = { 0x55, 0x55, 0x55, 0x55, 0x55, 0x55};

		private byte CHIPID_MG2470	= 3;
		private byte DATARATE_250_K = 3;
		private byte STACKID_NONE = 0x00;

		public S_HIB HIB = new S_HIB();
		public inteldata ihex = new inteldata();
		SerialPort port;
		ringBuffer queue = new ringBuffer();
		FileStream file;
		StreamReader sfile;

        public int devNum = 0;
		private int prog_percent = 0;

		public MG2470Cmd(string com, int baud)
		{
			InitHIB();

			ihex.recdata = new byte[256];
			prog_percent = 0;

			try
			{
				port = new SerialPort(com, baud);
				//port.ReadTimeout = 1000;
				port.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

		public void CallbackFunc(int num, MyDelegate func, StatDelegate func2)
		{
			devNum = num;
			prog_bar = new MyDelegate(func);
            stat_func = new StatDelegate(func2);
        }

		private byte[] ReadSerialByteData()
		{
			port.ReadTimeout = 1000;
			byte[] bytesBuffer = new byte[port.BytesToRead];
			int bufferOffset = 0;
			int bytesToRead = port.BytesToRead;

			while (bytesToRead > 0)
			{
				try
				{
					//queue.ring_buffer_push((byte)port.ReadByte());
					int readBytes = port.Read(bytesBuffer, bufferOffset, bytesToRead - bufferOffset);
					bytesToRead -= readBytes;
					bufferOffset += readBytes;
				}
				catch (TimeoutException ex)
				{
					Debug.WriteLine(ex.ToString());
				}
			}

			return bytesBuffer;
		}

		private void ReadSerialData()
		{
			while (port.BytesToRead > 0)
			{
				try
				{
					queue.ring_buffer_push((byte)port.ReadByte());
				}
				catch (TimeoutException ex)
				{
					Debug.WriteLine(ex.ToString());
				}
			}
		}
   
		private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			try
			{
#if false
				string strbuf = port.ReadExisting();
				byte[] arrBuf = Encoding.ASCII.GetBytes(strbuf);
				for (int i = 0; i < arrBuf.Length; i++)
				{
					queue.ring_buffer_push(arrBuf[i]);
				}

#else
				//byte[] bytesBuffer = ReadSerialByteData();
				//for (int i = 0; i < bytesBuffer.Length; i++)
				//{
				//	queue.ring_buffer_push(bytesBuffer[i]);
				//}

				ReadSerialData();
#endif
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}  
		}

		public void ClearQueue()
		{
			//port.ReadExisting();
			if (port.IsOpen)
			{
				port.DiscardOutBuffer();
				port.DiscardInBuffer();
			}
			queue.ring_buf_head = queue.ring_buf_tail;
			queue.ring_buf_len = 0;
		}

		private bool GetBytes(ref byte[] buf, int size, int timeout = 500)
		{
			
			while (queue.ring_buffer_length() < size)
			{
				Thread.Sleep(10);
				if (timeout-- == 0)
				{
					break;
				}
			}

			if (timeout == -1)
			{
				ClearQueue();
				Debug.WriteLine("Timeout : QueueClear");
				return false;
			}
			else
			{
				for (int i = 0; i < size; i++)
				{
					buf[i] = queue.ring_buffer_pop();
				}
				return true;
			}
		}

		private void DataReceiveHandler(byte[] data)
		{

		}



		public bool CheckSync()
		{
			byte error = 0;
			byte[] rx_bytes = new byte[7];

			ClearQueue();

			port.Write(CMD_SYNC, 0, 6);
			Thread.Sleep(500);

			//port.DiscardOutBuffer();
			//port.DiscardInBuffer();
			ClearQueue();
			port.Write(CMD_SYNC, 0, 6);

			GetBytes(ref rx_bytes, 7);
			//serialPort.Read(buf, 0, 7);

			error = 0;
			if (rx_bytes[0] != CMD_SYNC[0]) error++;
			if (rx_bytes[1] != CMD_SYNC[1]) error++;
			if (rx_bytes[2] != CMD_SYNC[2]) error++;
			if (rx_bytes[3] != CMD_SYNC[3]) error++;
			if (rx_bytes[4] != CMD_SYNC[4]) error++;
			if (rx_bytes[5] != CMD_SYNC[5]) error++;
			if (rx_bytes[6] != 0xFF) error++;

			if (error != 0)
			{
				for (int i = 0; i < 7; i++)
				{
					Debug.WriteLine("isp_sync:rx_bytes[" + i + "] = " + rx_bytes[i].ToString("X2"));
					//fprintf(stderr, "isp_sync:rx_bytes[%d] =%X\n", i, rx_bytes[i]);
				}
				return false;
			}

			return true;
		}


		public void InitHIB()
		{
#if true
			HIB.IEEEAddr = new byte[8];
			HIB.PanID = new byte[2];
			HIB.NwkAddr = new byte[2];
			HIB.NetworkKey = new byte[16];
			HIB.Rsv_0 = new byte[8];
			HIB.Rsv_EPID = new byte[8];
			HIB.Rsv_1 = new byte[8];
			HIB.GeneralWord0 = new byte[2];
			HIB.GeneralWord1 = new byte[2];
#endif
		}

		public bool portopen()
		{
			try
			{
				if (port != null)
				{					
					port.Open();
					if (port.IsOpen)
					{
						port.DiscardInBuffer();
						port.DiscardOutBuffer();
					}
					//port.ReadExisting();
				}

			}
			catch (Exception e)
			{
				Debug.WriteLine(e.ToString());
			}
			return port.IsOpen;
		}

		public void portclose()
		{
			if (port != null)
			{
				port.Close();
			}
		}

		public bool ihx_hib_read(string fname, uint addr, uint size)
		{
			//inteldata ihex;

			byte[] codes;
			byte[] rcrc = new byte[1];
			byte[] rx_byte = new byte[1];
			uint waddr, wsize;
			int i;

			//codes = (byte *)malloc(MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE);
			codes = new byte[MG2470_FLASH_BANK_SIZE * 4 + MG2470_FLASH_INFO_SIZE];
			for (i = 0; i < (MG2470_FLASH_BANK_SIZE * 4 + MG2470_FLASH_INFO_SIZE); i++)
			{
				codes[i] = 0xFF;
			}
			//memset(codes,0xFF,MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE);

			if (isp_fsh_misc(0x0000, 0x0000) == false) return false;

			waddr = addr >> 2; // start address in word address
			wsize = size >> 2; // size in word


			ihx_ram_writ_offset(MG2470_FREAD_B0_DRIVER, 0x7000);
			isp_fsh_misc(0x0000, 0x0080);

			isp_fsh_exec_noret(MG2470_FREAD_B0_CADDR);
			GetBytes(ref rx_byte, 1);
			//rx_byte = c_rx_byte();
			if(rx_byte[0] != 0x5A)
			{
				//fprintf(stderr,"BANK0:READ FLASH ERROR:%02X\n",rx_byte);
				//exit(0);
				Debug.WriteLine("BANK0:READ FLASH ERROR:" + rx_byte[0].ToString("X2"));
				return false;
			}

			//c_tx_byte(waddr  >>8);
			//c_tx_byte(waddr&0xFF);
			//c_tx_byte(wsize >> 8);
			//c_tx_byte(wsize & 0xFF);
			//c_rx(codes + addr, size);
			//rcrc = c_rx_byte();


			byte[] buf = new byte[size];
			Buffer.BlockCopy(codes, 4, buf, 0, (int)size);


			codes[0] = (byte)(waddr >> 8);
			codes[1] = (byte)(waddr & 0xFF);
			codes[2] = (byte)(wsize >> 8);
			codes[3] = (byte)(wsize & 0xFF);
			port.Write(codes, 0, 4);

			GetBytes(ref buf, (int)size, 500);
			GetBytes(ref rcrc, 1);

			Buffer.BlockCopy(buf, 0, codes, 4, (int)size);
			System.Diagnostics.Debug.Write("BANK0: " +  rcrc[0].ToString("X2"));

			intelhex_writ(fname,codes);
			//free(codes);
			return true;
		}


		public bool isp_fsh_misc(uint xaddr, uint bank)
		{
			byte[] error = new byte[1];

            isp_cmd(MG2470_FLASH_MISC, xaddr, bank);
            
			//error = c_rx_byte();
			//error = port.ReadByte();		//123
			if (GetBytes(ref error, 1) == false)
			{
				Debug.WriteLine("isp_fsh_misc:timeout");
				return false;
			}

			if (error[0] != 0)
			{
				//fprintf(stderr,"isp_fsh_misc:error =%02X\n",error);
				Debug.WriteLine("isp_fsh_misc:error");
				//exit(0);
				return false;
			}
			return true;
		}

		public bool isp_cmd(byte cmd, uint addr, uint size)
		{
			byte[] cmd_tx = { 0, 0, 0, 0, 0, 0, 0x0 };
			byte[] cmd_rx = new byte[7];
			int error;

			cmd_tx[0] = 0x55;
			cmd_tx[1] = cmd;
			cmd_tx[3] = (byte)(addr & 0xFF); addr >>= 8;
			cmd_tx[2] = (byte)(addr & 0xFF);
			cmd_tx[5] = (byte)(size & 0xFF); size >>= 8;
			cmd_tx[4] = (byte)(size & 0xFF);

			port.Write(cmd_tx, 0, 6);

			if (GetBytes(ref cmd_rx, 7) == false)
			{
				Debug.WriteLine("isp_cmd : ack was not received");
				return false;
			}
			// Check response
			error = 0;
			if (cmd_rx[0] != cmd_tx[0]) error++;
			if (cmd_rx[1] != cmd_tx[1]) error++;
			if (cmd_rx[2] != cmd_tx[2]) error++;
			if (cmd_rx[3] != cmd_tx[3]) error++;
			if (cmd_rx[4] != cmd_tx[4]) error++;
			if (cmd_rx[5] != cmd_tx[5]) error++;
			if (cmd_rx[6] != 0x00) error++;

			if (error != 0)
			{
				for (int i = 0; i < 7; i++)
					//fprintf(stderr, "isp_cmd:rx_bytes[%d] =%X\n", i, rx_bytes[i]);
					Debug.WriteLine("isp_cmd:rx_bytes[" + i + "] = " + cmd_rx[i].ToString("X2") + " " + cmd_tx[i].ToString("X2"));
				//exit(0);
				return false;
			}

			return true;

		}

		public bool isp_ram_writ(byte[] src, uint xaddr, uint xsize)
		{
			byte []xdata = src;
			byte gcrc;
			byte []rcrc = new byte[1];

			gcrc = gen_crc(xdata, 0, xsize);

			isp_cmd(MG2470_XDATA_WRIT, xaddr, xsize);
			//c_tx(xdata,xsize);
			port.Write(xdata, 0, (int)xsize);

			//rcrc = c_rx_byte();
			//rcrc = (byte)port.ReadByte();	//123
			if (GetBytes(ref rcrc, 1) == false)
			{
				Debug.WriteLine("isp_ram_writ:data not found.");
				return false;
			}

			if (gcrc != rcrc[0])
			{
				//fprintf(stderr,"isp_ram_writ:crc error\n");
				Debug.WriteLine("isp_ram_writ:crc error");
				//exit(0);
				return false;
			}

			return true;
		}

		bool isp_nowait(byte para)
		{
			//byte gcrc;
			byte[] rcrc = new byte[1];

			isp_cmd(MG2470_XDATA_WRIT, 0x270E, 0x0001);
			//c_tx_byte(para);
			//rcrc = c_rx_byte();


			//port.ReadExisting();
			byte[] tmp = new byte[1];
			tmp[0] = para;
			port.Write(tmp, 0, 1);

			if (GetBytes(ref rcrc, 1) == false)
			{
				System.Diagnostics.Debug.WriteLine("isp_nowait:timeout");
				return false;
			}

			if (para != rcrc[0])
			{
				//fprintf(stderr,"isp_nowait:error\n");
				//exit(0);
				System.Diagnostics.Debug.WriteLine("isp_nowait:error");
				return false;
			}
			return true;
		}

		bool isp_fsh_rers()
		{
			byte[] error = new byte[1];

			isp_cmd(MG2470_FLASH_RERS,0x0000,0x0000);
			
			//error = c_rx_byte();
			if (GetBytes(ref error, 1) == false)
			{
				System.Diagnostics.Debug.WriteLine("data was not received");
				return false;
			}

			if (error[0] != 0)
			{
				System.Diagnostics.Debug.WriteLine("isp_fsh_rers:error");
				return false;
			}
			return true;
		}

		bool isp_fsh_mers(uint waddr)
		{
			byte[] error = new byte[1];

			isp_cmd(MG2470_FLASH_MERS,waddr,0x0000);
			//error = c_rx_byte();
			//error = (byte)port.ReadByte();

			if (GetBytes(ref error, 1) == false)
			{
				System.Diagnostics.Debug.WriteLine("isp_fsh_mers:timeout");
				return false;
			}

		
			if (error[0] != 0)
			{
				//fprintf(stderr,"isp_fsh_mers:error =%02X\n",error);
				//exit(0);
				System.Diagnostics.Debug.WriteLine("isp_fsh_mers:error");
				return false;
			}
			return true;
		}

		byte isp_fsh_exec(uint caddr)
		{
			byte []retval = new byte[1];

			isp_cmd(MG2470_FLASH_EXEC,caddr,0x0000);
			//retval = c_rx_byte();
			//retval = (byte)port.ReadByte();	//123
			GetBytes(ref retval, 1);
			return retval[0];
		}

		byte isp_fsh_csum(uint waddr, uint wsize)
		{
			byte []csum = new byte[1];

			isp_nowait(0);
			isp_cmd(MG2470_FLASH_CSUM,waddr,wsize);
			//csum = c_rx_byte();
			//csum = (byte)port.ReadByte();		//123

			if (GetBytes(ref csum, 1) == false)
			{
				Debug.WriteLine("isp_fsh_csum : timeout");
			}
			return csum[0];
		}

		bool isp_fsh_pers(uint waddr)
		{
			byte []error = new byte[1];

			isp_cmd(MG2470_FLASH_PERS,waddr,0x0000);
			//error = c_rx_byte();
			//error = (byte)port.ReadByte();	//123
			if (GetBytes(ref error, 1) == false)
			{
				System.Diagnostics.Debug.WriteLine("isp_fsh_pers:timeout");
			}

			if (error[0] != 0)
			{
				//fprintf(stderr,"isp_fsh_pers:error =%02X\n",error);
				//exit(0);
				System.Diagnostics.Debug.WriteLine("isp_fsh_pers:error");
				return false;
			}
			return true;
		}


		bool cmd_checkerror(byte[] a, byte[] b, int size)
		{
			return a.SequenceEqual(b);
		}



		byte gen_crc(byte[] codes, uint offset, uint size)
		{
			int i;
			byte crc;

			for (i = 0, crc = 0; i < size; i++)
			{
				crc += codes[i + offset];
			}
			return crc;
		}

		////////////////////////////////////////////////////////////////////////////////////////////////////////
		// intel hex
		////////////////////////////////////////////////////////////////////////////////////////////////////////

		public void isp_fsh_exec_noret(uint caddr)
		{
			isp_cmd(MG2470_FLASH_EXEC, caddr, 0x0000);
		}

		public int intelhex_fileopen(string filename, int mode)
		{
			/*mode = 1 -> open file for reading
			  0 -> creates a new file for writing */

			/* TODO: please, check if the file already exists before overwriting */
			if (mode == 0)
			{
				//sfile = new StreamReader(filename, Encoding.Default);
				file = File.Open(filename, FileMode.OpenOrCreate);
				sfile = new StreamReader(file, Encoding.Default);

				ihex.eof_found = 0;
				ihex.base_addr = 0;
				return 1;
			}
			else
			{
				FileInfo fi = new FileInfo(filename);
				if (!fi.Exists) return 0;
				
				try {
					file = File.Open(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
					sfile = new StreamReader(file, Encoding.Default);
					ihex.eof_found = 0;
					ihex.base_addr = 0;
				}
				catch (Exception e)
				{
					Debug.WriteLine(e.ToString());
					return 0;
				}
				return 1;

			}
		}

		bool ihx_ram_writ(string fname)
		{
			int retval;
			//inteldata ihex;
			if (intelhex_fileopen(fname, 1) != 1) return false;
			while((retval = intelhex_readline(ihex)) != 0)
			{
				if (retval == 0x01)
					if (!isp_ram_writ(ihex.recdata, ihex.offset, ihex.reclen)) return false;
			}
			//intelhex_fileclose(&ihex);
			file.Close();
			sfile.Close();

			return true;
		}

		public bool ihx_ram_writ_offset(string fname, uint offset)
		{
			int retval;
			//inteldata ihex = new inteldata();		//remove
			intelhex_fileopen(fname, 1);
			while ((retval = intelhex_readline(ihex)) != 0)
			{
				if ((retval == 0x01) && (ihex.offset >= offset))
					isp_ram_writ(ihex.recdata, ihex.offset - offset, ihex.reclen);
			}
			//intelhex_fileclose(&ihex);
			file.Close();
			sfile.Close();
			return true;
		}
#if false
		public int intelhex_readline(inteldata id)
		{
			/* returns:
				0 EOF found
				1 data line read ok
				2 extended linear address read ok
				>2 error
			*/
			byte[] line = new byte[526];
			byte[] conv = new byte[5];
			int chksum, linelen, reccount, i;

			/* verifies eof and eof_record */
			if (id.eof_found == 1) return 0; /* eof_record found */

			if (file.Position == file.Length)
			{		//end of file
				return 1;
			}

			file.Read(line, 0, 525);
			string strLine = Encoding.Default.GetString(line);
			

			/* reads a line from stdin (hex file format) */
			//fgets(line, 525, id->file);

			/* changes CR+LF to FL if needed and checks if LF is present */
			linelen = strLine.Length;
			if (line[linelen - 2] == 13)
			{
				line[linelen - 2] = line[linelen - 1];
				line[linelen - 1] = 0;
				//linelen = strlen(line);
				linelen -= 1;
			}

			if (line[linelen-1] != 10) 
			{
				//fprintf(stderr,"error in intelhex file - linefeed not found at end of line\n");
				//exit(1);
				return 0;
			}

			/* checks for record mark */
			if (line[0] != 0x3a) {
				//fprintf(stderr,"error in intelhex file - ':' missing\n"); exit(1);
				return 0;
			}

			/* verifies the minimum linelength */
			if (linelen < 12) {
				//fprintf(stderr,"error in intelhex file - less than 11 characters in a line\n");
				return 5;
			}

			/* verifies the checksum */
			conv[2] = 0; chksum = 0;
			string strConv;
			for(i = 1; i < (linelen-1); i += 2) {
				conv[0] = line[i];
				conv[1] = line[i+1];

				strConv = Encoding.Default.GetString(conv);
				chksum += Convert.ToInt32(strConv, 16);
				//chksum += (int)strtoul(conv,(char **)NULL,16);
			}

	
			if ((chksum % 256) != 0) {
				//fprintf(stderr,"error in intelhex file - bad chksum\n"); exit(1);
				return 0;
			}

			/* reads record length */
			i = 1;
			conv[2] = 0; 
			conv[0] = line[i];
			conv[1] = line[i+1];
			i+=2;

			strConv = Encoding.Default.GetString(conv);
			id.reclen = Convert.ToUInt32(strConv, 16);

			/* checks if linelength is (reclength*2 + 12) */
			if (((id.reclen*2)+12) != linelen) {
				//fprintf(stderr,"error in intelhex file - number of characters doesn't match reclength\n");
				//exit(1);
				return 0;
			}

			/* reads load offset */
			conv[4]=0;
			conv[0]=line[i];
			conv[1]=line[i+1];
			conv[2]=line[i+2]; 
			conv[3]=line[i+3];
			i+=4;
			//id.offset = (int)strtoul(conv,(char **)NULL,16);
			strConv = Encoding.Default.GetString(conv);
			id.offset = Convert.ToUInt32(strConv, 16);

			/* reads record type */
			conv[2]=0; conv[0]=line[i]; conv[1]=line[i+1]; i+=2;
			strConv = Encoding.Default.GetString(conv);
			id.rectype = Convert.ToUInt32(strConv, 16);
			//id.rectype = (int)strtoul(conv,(char **)NULL,16);

			/* returns if rectype is 01 (eof_record) */
			if(id.rectype==1) {
				id.eof_found=1;
				return 0; /* eof_record found */
			}
  
			/* checks if rectype is 00 */
			if((id.rectype != 0) && (id.rectype != 4)) {
				//fprintf(stderr,"error in intelhex file - this program only accepts rectype 00(DATA) or 01(EOF) or 04(ELA)\n");
				//exit(1);
				return 0;
			}
    
			/* reads record data */
			for (reccount = 0; reccount < id.reclen; reccount++) {
				conv[0]=line[i]; conv[1]=line[i+1]; i+=2;
				strConv = Encoding.Default.GetString(conv);
				id.recdata[reccount] = (byte)Convert.ToUInt32(strConv, 16);

				//id.recdata[reccount]=(int)strtoul(conv,(char **)NULL,16);
			}

			/* update base address */
			if (id.rectype==4)
			{
				id.base_addr = 0;
				id.base_addr = id.recdata[0];
				id.base_addr <<= 8;
				id.base_addr |= id.recdata[1];
				return 2;
			}
			return 1; /* successfull read - data available */
		}
#endif

		public bool ihx_fsh_writ(string fname)
		{
			byte[] codes;
			//byte[] codes64bit;
			byte[] pages;
			byte[] wpage;
			uint waddr;
			uint wsize;
			uint caddr;
			uint paddr;
			uint dirty;
			byte gcrc;
			byte rcrc;
			//byte scrc;
			byte error = 0;
			byte page_error = 0;
			int i;
			int retry;

			int loop_cnt = 0;

			/* setup code image */
			//codes = (byte *)malloc(MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE);
			//memset(codes,0xFF,MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE);
			codes = new byte[MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE];
			for (i = 0; i < MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE; i++) {
				codes[i] = 0xFF;
			}

			if (intelhex_read(fname, codes) == false) return false;

			prog_bar(devNum, prog_percent = 25);

			//memset(codes+MG2470_FLASH_BANK_SIZE*2,0xFF,MG2470_FLASH_BANK_SIZE*2);
			for (i = 0; i < MG2470_FLASH_BANK_SIZE * 2; i++) {
				codes[MG2470_FLASH_BANK_SIZE + i] = 0xFF;
			}

			//memset(&codes[(MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE)-4], 0xFF, 4);//4byte : V1.2 by iamacat
			for (i = 0; i < 4; i++) {
				codes[(MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE)-4 + i] = 0xFF;
			}


		  //wpage = (byte *)malloc(MG2470_FLASH_PAGE_SIZE+4);
			wpage = new byte[MG2470_FLASH_PAGE_SIZE + 4];

			/* set mcu_wait during flash operation */
			if (!isp_nowait(0)) return false;

			/* mass erase data region & info region */
			if (!isp_fsh_rers()) return false;

			if (!isp_fsh_mers(0xFFFF)) return false;

			/* set default bank */
			if (!isp_fsh_misc(0x0000, 0x0000)) return false;

			/* load flash write driver */
			if (!ihx_ram_writ(MG2470_FWRIT_DRIVER)) return false;

			prog_bar(devNum, prog_percent = 30);

			/* switch xdata memory 0x0000-0x1FFF region to code memory 0x0000-0x7FFF */
			if (!isp_fsh_misc(0x0000, 0x0040)) return false;


			pages = new byte[codes.Length];

			//step 5
			//100- 30 = 70
			//70 / 5 = 14

			loop_cnt = (int)((MG2470_FLASH_BANK_SIZE * 4 + MG2470_FLASH_INFO_SIZE) / MG2470_FLASH_PAGE_SIZE);
			loop_cnt = loop_cnt / ((100 - prog_percent) / 5);
			loop_cnt++;

			int loop = 0;
			/* flash write */
			for (caddr = 0; caddr < (MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE); caddr += MG2470_FLASH_PAGE_SIZE)
			{
#if true
				if (++loop == loop_cnt)
				{
					prog_bar(devNum, prog_percent+=5);
					loop = 0;
				}
#endif

				//pages = codes + caddr;
				Buffer.BlockCopy(codes, (int)caddr, pages, 0, (int)MG2470_FLASH_PAGE_SIZE);
				for (paddr = 0, dirty = 0; paddr < MG2470_FLASH_PAGE_SIZE; paddr++)
				{
					if (pages[paddr]!=0xFF) 
					{
						dirty = 1;
						break;
					}
				}

				if (dirty != 0)
				{
					waddr = caddr >> 2;
					wsize = MG2470_FLASH_PAGE_SIZE >> 2;

					wpage[1] = (byte)(waddr & 0xFF); waddr >>= 8;
					wpage[0] = (byte)(waddr & 0xFF);
					wpage[3] = (byte)(wsize & 0xFF) ; wsize >>= 8;
					wpage[2] = (byte)(wsize & 0xFF);

					Buffer.BlockCopy(pages, 0, wpage, (int)4, (int)MG2470_FLASH_PAGE_SIZE);
					//memcpy(wpage+4, pages, MG2470_FLASH_PAGE_SIZE);
					gcrc = gen_crc(pages, 0, MG2470_FLASH_PAGE_SIZE);

					isp_nowait(0);
					ihx_fsh_para(0xA0,0x0A,0x08);
					isp_ram_writ(wpage, MG2470_BUFFER_ADDR, MG2470_FLASH_PAGE_SIZE+4);
					isp_fsh_misc(0x0000,0x0040);
					isp_fsh_exec(MG2470_DRIVER_CADDR);
					rcrc = isp_fsh_csum(caddr>>2,MG2470_FLASH_PAGE_SIZE>>2);

					page_error = 0;
					if (gcrc!=rcrc)
					{
						page_error++;
						//fprintf(stderr,"ihx_page_csum:fail: caddr=%05X gcrc=%02X rcrc=%02X\n",caddr, gcrc,rcrc);
						System.Diagnostics.Debug.WriteLine("ihx_page_csum:fail: caddr=" + caddr.ToString("X5") + "gcrc=" + gcrc.ToString("X2") + " rcrc=" + rcrc.ToString("X2"));
					}

					/* write retry */
					if (page_error != 0)
					{
						for (retry = 0; retry < 3; retry ++)
						{
							isp_nowait(0);
							ihx_fsh_para(0xC0,0x0C,0x80);
							isp_ram_writ(wpage,MG2470_BUFFER_ADDR,MG2470_FLASH_PAGE_SIZE+4);
							isp_fsh_misc(0x0000,0x0040);
							isp_fsh_exec(MG2470_DRIVER_CADDR);
							rcrc = isp_fsh_csum(caddr>>2,MG2470_FLASH_PAGE_SIZE>>2);

							if (gcrc!=rcrc)
							{
								page_error++;
								//fprintf(stderr,"ihx_page_csum:retry%d:fail: caddr=%05X gcrc=%02X rcrc=%02X\n",retry,caddr,gcrc,rcrc);
								System.Diagnostics.Debug.WriteLine("ihx_page_csum:retry%d:fail: caddr=%05X gcrc=%02X rcrc=%02X");
							}
							else
							{
								//fprintf(stderr,"ihx_page_csum:retry%d:pass\n",retry);
								System.Diagnostics.Debug.WriteLine("ihx_page_csum:retry : " + retry + " pass");
								page_error = 0;
								break;
							}
						}
					}

					/* erase retry */
					if (page_error != 0)
					{
						for (retry = 3; retry < 6; retry ++)
						{
							isp_nowait(0);
							isp_fsh_pers(caddr>>2);
							isp_fsh_pers(caddr>>2);
							isp_fsh_pers(caddr>>2);
							isp_fsh_pers(caddr>>2);
							ihx_fsh_para(0xa0,0x0A,0x80);
							isp_ram_writ(wpage,MG2470_BUFFER_ADDR,MG2470_FLASH_PAGE_SIZE+4);
							isp_fsh_misc(0x0000,0x0040);
							isp_fsh_exec(MG2470_DRIVER_CADDR);
							rcrc = isp_fsh_csum(caddr>>2,MG2470_FLASH_PAGE_SIZE>>2);

							if (gcrc!=rcrc)
							{
								page_error++;
								//fprintf(stderr,"ihx_page_csum:retry%d:fail: caddr=%05X gcrc=%02X rcrc=%02X\n",								
								//retry,caddr,gcrc,rcrc);
								Debug.WriteLine("ihx_page_csum:retry fail");
							}
							else
							{
								//fprintf(stderr,"ihx_page_csum:retry%d:pass\n",retry);
								Debug.WriteLine("ihx_page_csum:retry pass");
								page_error = 0;
								break;
							}
						}
					}

					if (page_error != 0) 
					{
						error++;
						//fprintf(stderr,"ihx_page_csum:fail [%05X]\n",caddr);
						Debug.WriteLine("ihx_page_csum:fail");
					}
				}

			}

			if (!isp_fsh_misc(0x0000, 0x0000)) return false;

			/* set mcu_wait during flash operation */
			if (!isp_nowait(0)) return false;

			/* generage check sum */
			gcrc  = gen_crc(codes, 0, MG2470_FLASH_BANK_SIZE*3);
			gcrc += gen_crc(codes, MG2470_FLASH_BANK_SIZE*4, MG2470_FLASH_INFO_SIZE);

			rcrc  = isp_fsh_csum(0x0000,(MG2470_FLASH_BANK_SIZE*2)>>2);
			rcrc  += isp_fsh_csum((MG2470_FLASH_BANK_SIZE*4)>>2,(MG2470_FLASH_INFO_SIZE)>>2);

			if (rcrc!=gcrc)
			{
				error++;
				//fprintf(stderr,"ihx_fsh_writ:csum:gcrc=%02X rcrc=%02X\n",gcrc,rcrc);
				Debug.WriteLine(String.Format("ihx_fsh_writ:csum:gcrc=%02X rcrc=%02X\n", gcrc, rcrc));
			}

			if (error == 0)
			{
				//fprintf(stderr, "ihx_fsh_writ:pass\n");
				Debug.WriteLine("ihx_fsh_writ:pass");
			}
			else
			{
				Debug.WriteLine("ihx_fsh_writ:fail");
				//fprintf(stderr, "ihx_fsh_writ:fail\n");
			}
			prog_bar(devNum, 100);
			return true;
		}

		void ihx_fsh_para(byte tpgs, byte tprg, byte trcv)
		{
			/* flash para */

			// default: tpgs = 0xA0
			// default: tprg = 0x0A
			// default: trcv = 0x08
			byte[] tmp = new byte[1];
			tmp[0] = tpgs;
			isp_ram_writ(tmp, 0x272A, 0x0001);
			tmp[0] = tprg;
			isp_ram_writ(tmp, 0x2724, 0x0001);
			tmp[0] = trcv;
			isp_ram_writ(tmp, 0x2725, 0x0001);
		}

		/************************************************************************************************************************/
		//IntelHex

		public int intelhex_writeline() 
		{
			uint chksum;
			int reccount;
			if (ihex.reclen == 0 || ihex.reclen > 255 || ihex.offset < 0 || ihex.offset > 0xffff)
			{
				//fprintf(stderr,"error in intelhex file - offset/reclen invalid when writing file\n");
				//exit(1);
				System.Diagnostics.Debug.Write("error in intelhex file - offset/reclen invalid when writing file\r\n");
				return 0;
			}

			string strBuf = ":";
			strBuf += ihex.reclen.ToString("X2");
			strBuf += ihex.offset.ToString("X4");
			strBuf += ihex.rectype.ToString("X2");
			byte[] arrBuf = Encoding.ASCII.GetBytes(strBuf);
			file.Write(arrBuf, 0, 9);
			//fprintf(id->file, ":%02X%04X%02X", id.reclen, id.offset, id.rectype);

			chksum = ihex.reclen; 		/* reclength */
			chksum += ihex.offset % 256;	/* low 8 bits of load offset */
			chksum += ihex.offset / 256;	/* high 8 bits of load offset */
			chksum += ihex.rectype;	/* rectype */

			for (reccount = 0; reccount < ihex.reclen; reccount++)
			{
				//fprintf(id->file, "%02X", id->recdata[reccount]);
				strBuf = ihex.recdata[reccount].ToString("X2");
				file.Write(Encoding.ASCII.GetBytes(strBuf), 0, 2);
				chksum += ihex.recdata[reccount];
			}
			chksum = 256 - (chksum % 256);
			if (chksum==256) chksum=0;

			strBuf = chksum.ToString("X2");
			strBuf += "\n";
			file.Write(Encoding.ASCII.GetBytes(strBuf), 0, 3);
			//fprintf(id.file, "%02X", chksum);
			//fprintf(id.file, "\n");

			return 1;
		}


		public void intelhex_writebase(uint base_addr)
		{	
			ihex.reclen = 0x02;
			ihex.offset = 0x0000;			
			ihex.rectype = 0x04;
			ihex.base_addr = base_addr;
			ihex.recdata[1] = (byte)(base_addr & 0xFF);
			base_addr >>= 8;
			ihex.recdata[0] = (byte)(base_addr & 0xFF);
			intelhex_writeline();
		}

		void intelhex_writeimage(byte[] codes_src, uint offset, uint n)
		{
			uint os, dirty;

			ihex.reclen = 0x10;
			ihex.rectype = 0x00;

			byte[] codes = new byte[codes_src.Length];
			Buffer.BlockCopy(codes_src, (int)offset, codes, 0, (int)n);
			//codes_src.CopyTo(codes, offset);

			for (ihex.offset = 0x0000; ihex.offset < n; ihex.offset += ihex.reclen)
			{
				for (os = 0, dirty = 0; os < ihex.reclen; os++)
				{
					if (codes[ihex.offset + os] != 0xFF)
					{
						dirty = 1;
						break;
					}
				}

				if (dirty != 0)
				{
					//memcpy(ihex.recdata, codes + (ihex.offset), ihex.reclen);
					Buffer.BlockCopy(codes, (int)ihex.offset, ihex.recdata, 0, (int)ihex.reclen);
					intelhex_writeline();
				}
			}
		}

		void intelhex_writeeof()
		{
			string strBuf = ":00000001FF\n";
			//fprintf(id->file, ":00000001FF\n");
			file.Write(Encoding.ASCII.GetBytes(strBuf), 0, strBuf.Length);
		}

		public bool intelhex_writ(string fname, byte[] codes)
		{
			//inteldata ihex;
			if (intelhex_fileopen(fname, 0) != 1) return false;
			intelhex_writebase(0x0000);
			intelhex_writeimage(codes, 0x00000,MG2470_FLASH_BANK_SIZE*2);

#if false		//blocked by euiseok (20181213)
			intelhex_writebase(0x0001); 
			intelhex_writeimage(codes, 0x10000,MG2470_FLASH_BANK_SIZE*1);
			intelhex_writebase(0x0002); 
			intelhex_writeimage(codes, 0x20000,MG2470_FLASH_INFO_SIZE*1);
#endif

			intelhex_writeeof();
			file.Close();
			sfile.Close();
			return true;
			//intelhex_fileclose(ihex);
		}


		public int intelhex_readline (inteldata id) 
		{
			/* returns:
			0 EOF found
			1 data line read ok
			2 extended linear address read ok
			>2 error
			*/
			byte[] line = new byte[526];
			byte[] conv = new byte[5];
			int chksum, linelen, reccount, i;

			/* verifies eof and eof_record */
			if (ihex.eof_found==1) return 0; /* eof_record found */

			try
			{
				if (sfile.EndOfStream)
				{
					System.Diagnostics.Debug.WriteLine("error in intelhex file - eof_record not found");
					return 0;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
				return 0;
			}
			//if (file.Position == file.Length) {
				//fprintf(stderr,"error in intelhex file - eof_record not found\n");
				//exit(1);
			//	System.Diagnostics.Debug.WriteLine("error in intelhex file - eof_record not found");
			//	return 0;
			//}


			/* reads a line from stdin (hex file format) */
			//fgets(line, 525, id->file);
			//file.Read(line, 0, 525);
			string strLine = sfile.ReadLine();
			strLine += "\r\n";
			line = Encoding.UTF8.GetBytes(strLine);
			/* changes CR+LF to FL if needed and checks if LF is present */
			linelen = strLine.Length;


			

			if (line[linelen-2] == 13)
			{
				line[linelen-2]=line[linelen-1];
				line[linelen-1]=0;
				linelen -= 1;
			}



			if (line[linelen-1] != 10) 
			{
				//fprintf(stderr,"error in intelhex file - linefeed not found at end of line\n");
				//exit(1);
				System.Diagnostics.Debug.WriteLine("error in intelhex file - linefeed not found at end of line\n");
				return 0;
			}


			/* checks for record mark */
			if (line[0] != 0x3a) {
				//fprintf(stderr,"error in intelhex file - ':' missing\n"); exit(1);
				System.Diagnostics.Debug.WriteLine("error in intelhex file - ':' missing");
				return 0;
			}

			/* verifies the minimum linelength */
			if (linelen < 12) {
				//fprintf(stderr,"error in intelhex file - less than 11 characters in a line\n");
				//return 5;
				System.Diagnostics.Debug.WriteLine("error in intelhex file - less than 11 characters in a line");
				return 5;
			}

			/* verifies the checksum */
			conv[2]=0; chksum=0;
			for(i=1; i<(linelen-1); i+=2) {
				conv[0]=line[i]; conv[1]=line[i+1];
				//chksum+=(int)strtoul(conv,(char **)NULL,16);
				string strVal = Encoding.Default.GetString(conv, 0, 2);
				chksum += (byte)Convert.ToUInt32(strVal, 16);
			}

			if ((chksum % 256) != 0) {
				//fprintf(stderr,"error in intelhex file - bad chksum\n"); exit(1);
				System.Diagnostics.Debug.WriteLine("error in intelhex file - bad chksum");
				return 0;
			}

			/* reads record length */
			conv[2]=0; i=1;
			conv[0]=line[i]; conv[1]=line[i+1]; i+=2;
			//id->reclen=(int)strtoul(conv,(char **)NULL,16);
			ihex.reclen = (uint)(Convert.ToUInt32(Encoding.Default.GetString(conv, 0, 2), 16));

			/* checks if linelength is (reclength*2 + 12) */
			if (((ihex.reclen * 2) + 12) != linelen) {
				//fprintf(stderr,"error in intelhex file - number of characters doesn't match reclength\n");
				//exit(1);
				System.Diagnostics.Debug.WriteLine("error in intelhex file - number of characters doesn't match reclength");
				return 0;
			}

			/* reads load offset */
			conv[4]=0; 
			conv[0]=line[i]; 
			conv[1]=line[i+1];
			conv[2]=line[i+2]; 
			conv[3]=line[i+3]; 
			i+=4;
			//id->offset=(int)strtoul(conv,(char **)NULL,16);
			ihex.offset = (uint)(Convert.ToUInt32(Encoding.Default.GetString(conv, 0, 4), 16));

			/* reads record type */
			conv[2]=0; conv[0]=line[i]; conv[1]=line[i+1]; i+=2;
			//id->rectype=(int)strtoul(conv,(char **)NULL,16);
			ihex.rectype = (uint)(Convert.ToUInt32(Encoding.Default.GetString(conv, 0, 2), 16));

			/* returns if rectype is 01 (eof_record) */
			if(ihex.rectype == 1) {
				ihex.eof_found = 1;
				return 0; /* eof_record found */ 
			}
    
			/* checks if rectype is 00 */
			if((ihex.rectype != 0) && (ihex.rectype != 4)) {
				//fprintf(stderr,"error in intelhex file - this program only accepts rectype 00(DATA) or 01(EOF) or 04(ELA)\n");
				//exit(1);
				System.Diagnostics.Debug.WriteLine("error in intelhex file - this program only accepts rectype 00(DATA) or 01(EOF) or 04(ELA)");
				return 0;
			}
    
			/* reads record data */
			for(reccount=0; reccount<ihex.reclen; reccount++) {
				conv[0]=line[i]; conv[1]=line[i+1]; i+=2;
				//id->recdata[reccount]=(int)strtoul(conv,(char **)NULL,16);
				ihex.recdata[reccount] = (byte)(Convert.ToUInt32(Encoding.Default.GetString(conv, 0, 2), 16));
			}

			/* update base address */
			if (ihex.rectype==4)
			{
				ihex.base_addr = 0;
				ihex.base_addr = ihex.recdata[0];
				ihex.base_addr <<= 8;
				ihex.base_addr |= ihex.recdata[1];
				return 2;
			}

			return 1; /* successfull read - data available */
		}

		bool intelhex_read(string fname, byte[] codes)
		{
			//inteldata ihex;
			int retval;

			if (intelhex_fileopen(fname, 1) == 0) return false;

			while((retval = intelhex_readline(ihex)) != 0)
			{
				if (retval==0x01) {
					//memcpy(codes+ihex.offset+(ihex.base<<16),ihex.recdata,ihex.reclen);

					Buffer.BlockCopy(ihex.recdata, 0, codes, (int)ihex.offset, (int)ihex.reclen);
				}
			}
			//intelhex_fileclose(&ihex);
			file.Close();
			sfile.Close();

			Debug.WriteLine("intelhex_read");

			return true;
		}


		public static object ByteToStructure(byte[] data, int size, Type type)
		{
			int length = size;

			IntPtr intPtr = Marshal.AllocHGlobal(length);
			Marshal.Copy(data, 0, intPtr, length);
			object obj = Marshal.PtrToStructure(intPtr, type);
			Marshal.FreeHGlobal(intPtr);

			if (Marshal.SizeOf(obj) != length)// (((PACKET_DATA)obj).TotalBytes != data.Length) // 구조체와 원래의 데이터의 크기 비교
			{
				return null; // 크기가 다르면 null 리턴
			}
			return obj; // 구조체 리턴
		}

		public static byte[] StructureToByte(object obj)
		{
			int datasize = Marshal.SizeOf(obj) + 1;//((PACKET_DATA)obj).TotalBytes; // 구조체에 할당된 메모리의 크기를 구한다.
			IntPtr buff = Marshal.AllocHGlobal(datasize); // 비관리 메모리 영역에 구조체 크기만큼의 메모리를 할당한다.
			Marshal.StructureToPtr(obj, buff, false); // 할당된 구조체 객체의 주소를 구한다.
			byte[] data = new byte[datasize]; // 구조체가 복사될 배열
			Marshal.Copy(buff, data, 0, datasize); // 구조체 객체를 배열에 복사
			Marshal.FreeHGlobal(buff); // 비관리 메모리 영역에 할당했던 메모리를 해제함
			return data; // 배열을 리턴
		}

		/*
		============================================================================================================================
		*/
		public bool WriteHIB(string fname, string hib_name, bool bRetain)
		{
			//S_HIB HIB = new S_HIB();
			byte sum = 0;

			//Thread.Sleep(1000);
			ihx_hib_read(hib_name, MG2470_HIB_OFFSET, MG2470_FLASH_PAGE_SIZE);							//HIB를 읽어서 파일로 저장.
			Debug.WriteLine("HIB_READ: SUCCESS");

			byte[] codes = new byte[MG2470_FLASH_BANK_SIZE * 4 + MG2470_FLASH_INFO_SIZE];				//FW size 할당. (0x8000*4 + 0x400 = 0x20400)
			for (int i = 0; i < MG2470_FLASH_BANK_SIZE * 4 + MG2470_FLASH_INFO_SIZE; i++)				//byte array 초기화.
			{
				codes[i] = 0xFF;
			}
			intelhex_read(hib_name, codes);																//HIB 를 읽어서 codes array 에 저장.											/

			byte[] arrHIB = new byte[MG2470_HIB_SIZE];											//chksum 계산 후 구조체 저장.
			Buffer.BlockCopy(codes, 4, arrHIB, 0, (int)MG2470_HIB_SIZE);
			for (int i = 0; i < (MG2470_HIB_SIZE - 1); i++)
			{
				sum += arrHIB[i];
			}
			arrHIB[MG2470_HIB_SIZE - 1] = (byte)(0 - sum);
			HIB = (S_HIB)ByteToStructure(arrHIB, arrHIB.Length - 1, HIB.GetType());

			for (int i = 0; i < MG2470_FLASH_BANK_SIZE * 4 + MG2470_FLASH_INFO_SIZE; i++)				//codes Array 초기화.
			{
				codes[i] = 0xFF;
			}

			intelhex_read(fname, codes);																//fw codes array 저장.
			//memcpy(&codes[MG2470_HIB_OFFSET], HIB.Value, MG2470_FLASH_PAGE_SIZE);
			Buffer.BlockCopy(arrHIB, 0, codes, (int)MG2470_HIB_OFFSET, (int)MG2470_HIB_SIZE);			//HIB SIZE 만 저장하도록 했는데 이상 없는지 확인.
			intelhex_writ(fname + "_bak", codes);														//읽어온 HIB를 F/W Hex 에 저장.
			return true;
		}


		public bool DefaultHIB(string srcName, string dstName, byte[] IEEE64 = null)
		{

			//prog_bar(devNum, prog_percent = 0);
			//////////////////////////////////////////////////////////////////////////////////
			//무조건 HIB 는 디폴트 값 사용 하며 IEEE64 만 적용.
			//////////////////////////////////////////////////////////////////////////////////
			HIB.IEEEAddr[0] = 0x01;	HIB.IEEEAddr[4] = 0x01;
			HIB.IEEEAddr[1] = 0x00;	HIB.IEEEAddr[5] = 0x51;
			HIB.IEEEAddr[2] = 0x00;	HIB.IEEEAddr[6] = 0x15;
			HIB.IEEEAddr[3] = 0x00;	HIB.IEEEAddr[7] = 0x00;
			HIB.ChipId = CHIPID_MG2470;
			HIB.TxPower = 0;
			HIB.DataRate = DATARATE_250_K;
			HIB.StackID = STACKID_NONE;
			HIB.Ch = 0x0B;
			HIB.PanID[0] = 0x34;
			HIB.PanID[1] = 0x12;
			HIB.NwkAddr[0] = 0x01;
			HIB.NwkAddr[1] = 0x00;
			//HIB.SecLevel;
			//HIB.PreConfig;
			//HIB.NetworkKey;
			//HIB.Rsv_0;
			//HIB.Rsv_EPID;
			//HIB.Rsv_1;

			if (IEEE64 != null)
			{
				Buffer.BlockCopy(IEEE64, 0, HIB.IEEEAddr, 0, 8);
			}

            //prog_bar(devNum, prog_percent = 0);

            byte sum = 0;	
			byte[] arrHIB = StructureToByte(HIB);			//61

			for(int i = 0; i < (MG2470_HIB_SIZE-1); i++)
			{
				sum += arrHIB[i];
			}

            arrHIB[MG2470_HIB_SIZE - 1] = (byte)(0 - sum);

            byte[] codes = new byte[MG2470_FLASH_BANK_SIZE*4+MG2470_FLASH_INFO_SIZE];
			for (int i = 0; i < MG2470_FLASH_BANK_SIZE * 4 + MG2470_FLASH_INFO_SIZE; i++)
			{
				codes[i] = 0xFF;
			}
			
			if (!intelhex_read(srcName, codes)) return false;

			//prog_bar(devNum, prog_percent = 10);			
			//memcpy(&codes[MG2470_HIB_OFFSET], HIB.Value, MG2470_HIB_SIZE);
			Buffer.BlockCopy(arrHIB, 0, codes, (int)MG2470_HIB_OFFSET, (int)(MG2470_HIB_SIZE));

            //codes[MG2470_HIB_OFFSET + MG2470_HIB_SIZE - 1] = sum;											//chksum 은 62에 존재함. (실제 구조체는 size = 61)

			if (!intelhex_writ(dstName, codes)) return false;

			//prog_bar(devNum, prog_percent = 20);
			Debug.Write("IEEE64 Address : ");
			for (int i = 0; i < 8; i++)
			{
				Debug.Write(HIB.IEEEAddr[i].ToString("X2") + " ");
			}
			Debug.WriteLine("");
			//Debug.WriteLine(String.Format("{0:X2}{1:X2}{2:X2}{3:X", HIB.IEEEAddr[7], HIB.IEEEAddr[6]));

			//printf("IEEE Address : 0x%02X%02X%02X%02X%02X%02X%02X%02X\n", HIB.IEEEAddr[7], HIB.IEEEAddr[6],
			//	HIB.IEEEAddr[5], HIB.IEEEAddr[4], HIB.IEEEAddr[3], HIB.IEEEAddr[2],
			//	HIB.IEEEAddr[1], HIB.IEEEAddr[0]);

			return true;
		}

	}
}
