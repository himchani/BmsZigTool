using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace FWDLlibrary
{

    //public delegate void ProgressDelegate(string com, int num, int percent);

    public class FWDNLib : IDisposable {
        //ProgressDelegate __callBack;
		private bool isDispose = false;

		MG2470Cmd fwDev = null;
		private string strFileName;
		private string strCom;
		private byte[] arrIEEE64;
        //private int devNum = 0;
        //private volatile bool _threadStop = true;

        //public void SetProgressFunc(ProgressDelegate callback)
        //{
        //__callBack = new ProgressDelegate(callback);
        //}

        public void SetCallbackFunc(int num, MyDelegate func, StatDelegate func2)
        {
            fwDev.CallbackFunc(num, func, func2);
        }


        public FWDNLib()
        {
            //__callBack = null;
			//Mg2470Cmd = new MG2470Cmd(com, baud);
        }

		~FWDNLib()
		{
			if (!isDispose) {
				Dispose();
			}
		}
		
		public void Dispose()
		{
			isDispose = true;
			fwDev = null;
			arrIEEE64 = null;
			GC.SuppressFinalize(this);
		}

		public void SetDevice(string fname, string com, byte[] IEEE64)
		{
			strFileName = fname;
			strCom = com;
			fwDev = new MG2470Cmd(com, 115200);
			arrIEEE64 = IEEE64;
		}

		public bool Open()
		{
			return fwDev.portopen();
		}

		//return
		//1 : Success
		//0 : FileOpen Error
		//2 : Write Error
		public int FWWrite(string fname, bool bRetain)
        {
            FileInfo fi = new FileInfo(fname);
            if (fi.Exists == false) return 0;

			//S_HIB HIB = new S_HIB();
			fwDev.portopen();			
			//Mg2470Cmd.ClearQueue();



			if (fwDev.CheckSync() == false)
			{
				Debug.WriteLine("ISP Sync Error");
                fwDev.stat_func(fwDev.devNum, 0);
                fwDev.portclose();
                return 0;
			}

			//Mg2470Cmd.WriteHIB(fname, "HIB.hex", bRetain);/
			byte[] ieee64 = {0x0,0x15,0x51,0x01,0x00,0x00,0x00,0x00};
            if (fwDev.DefaultHIB(fname, fname + "_tmp", ieee64) == false)
            {
                fwDev.portclose();
                fwDev.stat_func(fwDev.devNum, -1);
                return 0;
            }
            System.Diagnostics.Debug.WriteLine("Start WRITE...");

            if (fwDev.ihx_fsh_writ(fname + "_tmp") == false)
            {
                fwDev.stat_func(fwDev.devNum, -2);
            }
            System.Diagnostics.Debug.WriteLine("Write Success");

			fwDev.portclose();
            fwDev.stat_func(fwDev.devNum, 1);

            return 1;
        }


		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//Thread 

		public int FWDownloadProcessing(TInfo threadContext)
		{
			int threadIndex = threadContext.Index;
			{
                byte inc = (byte)threadIndex;

                byte[] ieee_dummy = arrIEEE64;

                //ieee_dummy[0] += inc;

                //ieee_dummy[0] += (byte)fwDev.devNum;

                string strDst = strFileName + "_" + threadIndex + "_tmp";

                if (fwDev.DefaultHIB(strFileName, strDst, ieee_dummy))
                {
                    bool err;
                    
					err = fwDev.ihx_fsh_writ(strDst);

                    if (err == false)
                    {
                        fwDev.stat_func(fwDev.devNum, -3);
                        fwDev.portclose();
                        System.Diagnostics.Debug.WriteLine("Write Error");
                    }
                    else
                    {
                        fwDev.stat_func(fwDev.devNum, 1);
                        fwDev.portclose();
                    }

                    FileInfo fDel = new FileInfo(@strDst);
					if (fDel.Exists) fDel.Delete();
				}
				
			}
			return threadIndex;
		}
    }

	//ret
	// 0 : file not exist
	// 1 : success
	// 2 : comport open error
	// 3 : sync error

	public class FWThreadDn
	{
		private TPool tp = null;
        public int Run(int num, string fname, string[] com, byte[,] ieee64, MyDelegate func, StatDelegate func2)
        {
			FWDNLib[] fwLib = new FWDNLib[num];

			FileInfo fileInfo = new FileInfo(fname);
			if (fileInfo.Exists == false) return 0;
			
			FWDNLib f = new FWDNLib();
			tp = new TPool(num, new DMethod(f.FWDownloadProcessing));

			for (int i = 0; i < num; i++)
			{
				//Fibonacci fi = new Fibonacci(r.Next(20, 40));
				FWDNLib fi = new FWDNLib();

                byte[] addr = new byte[8];

                for (int j = 0; j < 8; j++)
				{
					addr[j] = ieee64[i, j];
				}

				fi.SetDevice(fname, com[i], addr);

                if (fi.Open() == false)
				{
					//return 2;
				}
				else
				{
                    //fi.SetProgressFunc(func);
                    fi.SetCallbackFunc(i, func, func2);
                    TInfo ti = new TInfo(i, i, fi.FWDownloadProcessing);
					fwLib[i] = fi;
					ThreadPool.QueueUserWorkItem(tp.Run, ti); //쓰레드풀이용
                }
			}

			//while (!tp.Check())
			//	Thread.Sleep(100);

			//Console.WriteLine("All calculations are complete.");
			return 1;
		}

		public bool CheckThread()
		{
			if (tp != null) {
				if (!tp.Check()) {
					Thread.Sleep(1);
					return false;
				}
				else {
					return true;
				}
			}
			return true;

		}
    }
}



