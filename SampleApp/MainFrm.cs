using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using FWDLlibrary;
using Automation.BDaq;
using ScannerLib;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;



namespace SampleApp
{
    public partial class Main : Form
    {
        int adc_status = 0;
        int adc_cnt = 0;
        int adc_dummy_cnt = 5;
        int adc_measure_cnt = 25;

        double[] adc1_buf = new double[32];
        double[] adc1_sum_buf = new double[32];
        double[] adc1_avr_buf = new double[32];

        double[] adc2_buf = new double[32];
        double[] adc2_sum_buf = new double[32];
        double[] adc2_avr_buf = new double[32];

        int dmm_status = 0;
        int dmm_cnt = 0;
        double dmm_f_value = 0;
        double dmm_sum_value = 0;
        double dmm_avr_value = 0;
        string dmm_str_value = "";

        int psu_status = 0;
        double psu_set_v_value = 0;
        double psu_target_v_value = 0;

        FWThreadDn fdn = null;

        string strFname = null;
        ComboBox[] cbb;
        CheckBox[] cb;

        public Label[] lb;
        public ProgressBar[] pb;

        TextBox[] dev_set_i_tb;
        TextBox[] dev_ovp_v_tb;
        TextBox[] dev_1st_v_tb;
        TextBox[] dev_2nd_v_tb;
        TextBox[] dev_adc_v_tb;
        TextBox[] dev_ieee64_tb;
        TextBox[] dev_err_tb;

        double[,,] bd_chk_value = new double[12, 20, 5];

        int bd_chk_value_cnt = 0;

        int bd_err_avr_ovp_cnt = 0;
        int bd_err_avr_1st_cnt = 0;
        int bd_err_avr_2nd_cnt = 0;
        int bd_err_avr_adc_cnt = 0;
        //avr,min,max,dvdt 값 잡기 12개씩
        //dev_chk_cnt - 디바이스 갯수
        int bd_err_dvdt_ovp_cnt = 0;
        int bd_err_dvdt_1st_cnt = 0;
        int bd_err_dvdt_2nd_cnt = 0;
        int bd_err_dvdt_adc_cnt = 0;
        int[] err_board_num = new int[12];
        bool db_check = false;


        double[] dev_set_i_scale;
        double[] dev_set_i_offset;

        RadioButton[] dev_ieee64_chk_rdbtn;
        int dev_ieee64_chk_rdbtn_idx;
        TextBox[] dev_ieee64_low_chk_tb;
        Label[] dev_cal_chk_lb;

        byte[] devchk_write_buf = new byte[255];
        byte devchk_write_header;
        byte devchk_write_cmd;
        byte devchk_write_length;
        byte[] devchk_write_data = new byte[128];
        byte[] devchk_write_sid;
        byte[] devchk_write_did;

        byte[] devchk_read_buf = new byte[255];
        byte devchk_read_buf_cnt = 0;
        ringBuffer devchk_queue = new ringBuffer();
        Label[] dev_ieee64_rf_chk_lb;

        int devchk_cal_v_value = 0;
        byte[] devchk_cal_v_buf;
        TextBox[] dev_v_rd_tb;

        string[,] dev_mesasure_str_buf;

        Label[] dev_sd_id_chk_lb;
        TextBox[] dev_s_id_tb;
        TextBox[] dev_d_id_tb;

        int devchk_rx_flag = 0;
        int devchk_tx_flag = 0;

        DS8178Lib ds8178lib = null;
        string[] ds8178_str = null;
        int ds8178_cnt = 0;

        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        string strConfigname = null;

        System.Timers.Timer main_timer;
        int main_timer_cnt = 0;
        int main_timer_wait = 0;

        System.Timers.Timer adc_timer;
        int adc_timer_cnt = 0;

        System.Timers.Timer power_set_timer;
        int power_set_timer_cnt = 0;

        System.Timers.Timer rf_rx_timer;
        int rf_rx_timer_cnt = 0;
        int rf_rx_timer_wait = 0;

        System.Timers.Timer rf_tx_timer;
        int rf_tx_timer_cnt = 0;
        int rf_tx_timer_wait = 0;

        int board_check_cnt = 0;
        public static MySqlConnection db_con = null;
        public static MySqlCommand db_cmd = null;
        string db_serber_name = "maroomcs.myqnapcloud.com;";
        string db_database_name = "bms_manufacturer;";
        string db_id = "root;";
        string db_password = "dnflskfk12;";
        string db_con_str = "";

        DB_BmsProduction db_bms_pd;

        int v_mode = 0;
        int v_cal_step = 0;
        int op_mode = 0;
        int op_step = 0;
        int op_step_retry = 5;
        int op_step_retry_cnt = 0;
        int op_status = 0;

        int dev_chk_cnt = 0;
        int dev_chk_fail_cnt = 0;
        int dev_chk_result_cnt = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            op_status_lb.Text = "초기화 중..";

            system_init();

            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = "devcon.exe";
            pInfo.Arguments = @"restart *VID_067B*"; // 시리얼포트
            Process p = Process.Start(pInfo);
            p.WaitForExit();

            pInfo.Arguments = @"restart *VID_2184*"; // PSU
            p = Process.Start(pInfo);
            p.WaitForExit();

            pInfo.Arguments = @"restart *VID_0403*"; // DMM
            p = Process.Start(pInfo);
            p.WaitForExit();

            pInfo.Arguments = @"restart *VID_10C4*"; // ZIGBEE Checker
            p = Process.Start(pInfo);
            p.WaitForExit();


            psw3036_port_cbb.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            dmm_port_cbb.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            devchk_cbb.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            bool err;
            ds8178lib = new DS8178Lib();
            err = ds8178lib.Init(GetSacnnerInfo);
            ds8178lib.CallbackFunc(GetSacnnerInfo);
            ds8178_cnt = ds8178lib.Scan();

            main_timer_init();
            adc_timer_init();
            power_set_timer_init();
            rf_rx_timer_init();
            rf_tx_timer_init();

            config_file_init(Application.StartupPath + "\\config.ini");

            //psu_connect_btn.PerformClick();
            //dmm_connect_btn.PerformClick();
            //devchk_connect_btn.PerformClick();

            db_init();

            zig_up_btn.PerformClick();

            for (int i = 0; i < 2; i++)
            {
                zig_up_btn.PerformClick();
                dev_pwr_all_off_btn.PerformClick();
                dev_pwr_all_on_btn.PerformClick();
            }

            psu_off_set();

            //adc_status = 1;
            //adc_timer.Start();

            op_status_lb.Text = "초기화 완료.";
            Delay(1000);

            dmm_status = 1;
            power_set_timer.Start();

            op_status_lb.Text = "작업대기 중.";
            Delay(1000);
        }

        private void dev_fw_set()
        {
            dev_chk_fail_cnt = 0;
            dev_chk_result_cnt = 0;

            for (int i = 0; i < 12; i++)
            {
                pb[i].Value = 0;
                lb[i].Text = "Wait..";
            }

            if (strFname == null)                           //파일을 먼저 선택해야 함.
            {
                MessageBox.Show("파일을 선택하세요.");
                return;
            }
#if false
			fw.FWWrite(strFname, false);
#endif

            string[] com = new string[12];                  //체크 된 컴포트를 읽어 온다.
            int j = 0;
            for (int i = 0; i < 12; i++)
            {
                if (cb[i].Checked)
                {
                    if (cbb[i].Text != "")
                    {
                        com[j++] = cbb[i].Text;
                    }
                }
            }
            //string[] com = { "COM5", "COM2" };
            byte[,] IEEE64 = new byte[12, 8];               //IEEE64를 할당한다. (코드 적용 안함 - 나중에 읽어오는 코드 추가해야함)
            string[] dev_ieee64_str;
            for (int i = 0; i < dev_chk_cnt; i++)
            {
                dev_ieee64_str = dev_ieee64_tb[i].Text.Split(' ');

                IEEE64[i, 7] = Convert.ToByte(dev_ieee64_str[0], 16);
                IEEE64[i, 6] = Convert.ToByte(dev_ieee64_str[1], 16);
                IEEE64[i, 5] = Convert.ToByte(dev_ieee64_str[2], 16);
                IEEE64[i, 4] = Convert.ToByte(dev_ieee64_str[3], 16);
                IEEE64[i, 3] = Convert.ToByte(dev_ieee64_str[4], 16);
                IEEE64[i, 2] = Convert.ToByte(dev_ieee64_str[5], 16);
                IEEE64[i, 1] = Convert.ToByte(dev_ieee64_str[6], 16);
                IEEE64[i, 0] = Convert.ToByte(dev_ieee64_str[7], 16);
            }

            if (j > 0)
            {
                fdn = new FWThreadDn();                             //선택 된 항목이 있을 경우 FWThreadDn 을 생성
                fdn.Run(j, strFname, com, IEEE64, ProgressBar, DownloadStatus);
            }
            else
            {
                MessageBox.Show("설정을 확인하세요.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dev_fw_set();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fw_load_btn.BackColor = Color.SkyBlue;

            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = "H00";
            openFileDlg.Filter = "MG2470(*.H00;*.HEX)|*.H00;*.HEX";

            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    string[] str = filename.Split('\\');
                    strFname = filename;
                    fw_file_label.Text = "펌웨어 파일 이름 : " + str[str.Length - 1];
                }
            }
            dev_auto_mode_btn.Enabled = true;
            //dev_id_mode_btn.BackColor = Color.Gray;
            fw_down_mode_btn.Enabled = true;
            board_check_btn.Enabled = true;
        }

        public void ProgressBar(int num, int percent)
        {
            Console.WriteLine(String.Format("Dev : {0} - {1}", num, percent));

            this.SetProgressBar(num, percent);
            //pb[num].Value = percent;
            //pb[num].
        }

        delegate void SetPercent(int num, int percent);

        private void SetProgressBar(int num, int percent)
        {
            if (this.pb[num].InvokeRequired)
            {
                SetPercent d = new SetPercent(SetProgressBar);
                this.Invoke(d, new object[] { num, percent });
            }
            else
            {
                this.pb[num].Value = percent;
            }
        }

        // 1 이 아닌 경우 에러.
        public void DownloadStatus(int num, int ret)    //리턴값대신 callback function 으로 대체
        {
            System.Diagnostics.Debug.WriteLine(num + "+" + ret);

            this.SetDownloadStatus(num, ret);
        }

        delegate void SetDownloadStatusLabel(int num, int ret);

        private void SetDownloadStatus(int num, int ret)
        {
            if (this.lb[num].InvokeRequired)
            {
                SetDownloadStatusLabel d = new SetDownloadStatusLabel(SetDownloadStatus);
                this.Invoke(d, new object[] { num, ret });
            }
            else
            {
                dev_chk_result_cnt++;

                if (ret == 1)
                {
                    this.lb[num].Text = "OK";
                }
                else
                {
                    this.lb[num].Text = "Fail";
                    dev_chk_fail_cnt++;
                }
            }
        }

        public void GetSacnnerInfo(string[] info)
        {
            this.SacnnerInfo(info);
        }

        delegate void EventDelegate(string[] info);

        private void SacnnerInfo(string[] info)
        {
            if (this.dev_ieee64_tb[dev_ieee64_chk_rdbtn_idx].InvokeRequired)
            {
                EventDelegate d = new EventDelegate(SacnnerInfo);
                this.Invoke(d, new object[] { info });
            }
            else
            {
                //string[] str_temp;
                if (info[1].Length == 16)
                {
                    string ieee64_temp = "";

                    for (int i = 0; i < 8; i++)
                    {
                        ieee64_temp += info[1].Substring((0 + i) * 2, 2) + " ";
                    }

                    if (dev_ieee64_set_rdbtn.Checked == true)
                    {
                        dev_ieee64_set_tb.Text = "";
                        dev_ieee64_set_tb.Text = ieee64_temp.Trim();
                    }
                    else
                    {
                        dev_ieee64_tb[dev_ieee64_chk_rdbtn_idx].Text = "";

                        dev_ieee64_tb[dev_ieee64_chk_rdbtn_idx].Text = ieee64_temp.Trim();

                        if (dev_ieee64_chk_rdbtn_idx == 11)
                        {
                            dev_ieee64_chk_rdbtn[0].Checked = true;
                        }
                        else
                        {
                            dev_ieee64_chk_rdbtn[dev_ieee64_chk_rdbtn_idx + 1].Checked = true;
                        }
                    }
                }
                else
                {
                    if (dev_ieee64_set_rdbtn.Checked == true)
                    {
                        dev_ieee64_set_tb.Text = "Wrong Format!";
                    }
                    else
                    {
                        dev_ieee64_tb[dev_ieee64_chk_rdbtn_idx].Text = "Wrong Format!";
                    }
                }
            }
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void zig_up_set()
        {
            daq_gpio_set(0, 4, 0);
        }
        private void zig_up_button_Click(object sender, EventArgs e)
        {
            zig_up_set();
        }

        private void zig_down_set()
        {
            daq_gpio_set(0, 4, 1);
        }
        private void zig_down_button_Click(object sender, EventArgs e)
        {
            zig_down_set();
        }

        private void device_reset_set()
        {
            daq_gpio_set(1, 7, 1);
            Delay(1000);
            daq_gpio_set(1, 7, 0);
        }
        private void device_reset_button_Click(object sender, EventArgs e)
        {
            device_reset_set();
        }

        private void isp_on_set()
        {
            daq_gpio_set(1, 2, 1);
        }
        private void isp_on_button_Click(object sender, EventArgs e)
        {
            isp_on_set();
        }

        private void isp_off_set()
        {
            daq_gpio_set(1, 2, 0);
        }
        private void isp_off_button_Click(object sender, EventArgs e)
        {
            isp_off_set();
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbk = (CheckBox)sender;

            if (cbk.Checked == true)
            {
                switch (cbk.Name)
                {

                    case "cb1": daq_gpio_set(0, 0, 1); break;
                    case "cb2": daq_gpio_set(0, 6, 1); break;
                    case "cb3": daq_gpio_set(1, 3, 1); break;
                    case "cb4": daq_gpio_set(0, 1, 1); break;
                    case "cb5": daq_gpio_set(0, 7, 1); break;
                    case "cb6": daq_gpio_set(1, 4, 1); break;
                    case "cb7": daq_gpio_set(0, 2, 1); break;
                    case "cb8": daq_gpio_set(1, 0, 1); break;
                    case "cb9": daq_gpio_set(1, 5, 1); break;
                    case "cb10": daq_gpio_set(0, 3, 1); break;
                    case "cb11": daq_gpio_set(1, 1, 1); break;
                    case "cb12": daq_gpio_set(1, 6, 1); break;
                }
            }
            else if (((CheckBox)sender).Checked == false)
            {
                switch (cbk.Name)
                {
                    case "cb1": daq_gpio_set(0, 0, 0); break;
                    case "cb2": daq_gpio_set(0, 6, 0); break;
                    case "cb3": daq_gpio_set(1, 3, 0); break;
                    case "cb4": daq_gpio_set(0, 1, 0); break;
                    case "cb5": daq_gpio_set(0, 7, 0); break;
                    case "cb6": daq_gpio_set(1, 4, 0); break;
                    case "cb7": daq_gpio_set(0, 2, 0); break;
                    case "cb8": daq_gpio_set(1, 0, 0); break;
                    case "cb9": daq_gpio_set(1, 5, 0); break;
                    case "cb10": daq_gpio_set(0, 3, 0); break;
                    case "cb11": daq_gpio_set(1, 1, 0); break;
                    case "cb12": daq_gpio_set(1, 6, 0); break;
                }
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbk = (RadioButton)sender;

            if (dev_ieee64_set_rdbtn.Checked == false)
            {
                if (rbk.Checked == true)
                {
                    switch (rbk.Name)
                    {
                        case "dev1_ieee64_chk_rdbtn": dev_ieee64_tb[0].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 0; break;
                        case "dev2_ieee64_chk_rdbtn": dev_ieee64_tb[1].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 1; break;
                        case "dev3_ieee64_chk_rdbtn": dev_ieee64_tb[2].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 2; break;
                        case "dev4_ieee64_chk_rdbtn": dev_ieee64_tb[3].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 3; break;
                        case "dev5_ieee64_chk_rdbtn": dev_ieee64_tb[4].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 4; break;
                        case "dev6_ieee64_chk_rdbtn": dev_ieee64_tb[5].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 5; break;
                        case "dev7_ieee64_chk_rdbtn": dev_ieee64_tb[6].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 6; break;
                        case "dev8_ieee64_chk_rdbtn": dev_ieee64_tb[7].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 7; break;
                        case "dev9_ieee64_chk_rdbtn": dev_ieee64_tb[8].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 8; break;
                        case "dev10_ieee64_chk_rdbtn": dev_ieee64_tb[9].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 9; break;
                        case "dev11_ieee64_chk_rdbtn": dev_ieee64_tb[10].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 10; break;
                        case "dev12_ieee64_chk_rdbtn": dev_ieee64_tb[11].ReadOnly = false; dev_ieee64_chk_rdbtn_idx = 11; break;
                    }
                }
                else if (rbk.Checked == false)
                {
                    switch (rbk.Name)
                    {
                        case "dev1_ieee64_chk_rdbtn": dev_ieee64_tb[0].ReadOnly = true; break;
                        case "dev2_ieee64_chk_rdbtn": dev_ieee64_tb[1].ReadOnly = true; break;
                        case "dev3_ieee64_chk_rdbtn": dev_ieee64_tb[2].ReadOnly = true; break;
                        case "dev4_ieee64_chk_rdbtn": dev_ieee64_tb[3].ReadOnly = true; break;
                        case "dev5_ieee64_chk_rdbtn": dev_ieee64_tb[4].ReadOnly = true; break;
                        case "dev6_ieee64_chk_rdbtn": dev_ieee64_tb[5].ReadOnly = true; break;
                        case "dev7_ieee64_chk_rdbtn": dev_ieee64_tb[6].ReadOnly = true; break;
                        case "dev8_ieee64_chk_rdbtn": dev_ieee64_tb[7].ReadOnly = true; break;
                        case "dev9_ieee64_chk_rdbtn": dev_ieee64_tb[8].ReadOnly = true; break;
                        case "dev10_ieee64_chk_rdbtn": dev_ieee64_tb[9].ReadOnly = true; break;
                        case "dev11_ieee64_chk_rdbtn": dev_ieee64_tb[10].ReadOnly = true; break;
                        case "dev12_ieee64_chk_rdbtn": dev_ieee64_tb[11].ReadOnly = true; break;
                    }
                }
            }
        }

        private void dev_pwr_all_on_set()
        {
            for (int i = 0; i < 12; i++)
            {
                cb[i].Checked = true;
                Delay(100);
            }
        }
        private void dev_pwr_all_on_button_Click(object sender, EventArgs e)
        {
            dev_pwr_all_on_set();
        }

        private void dev_pwr_all_off_set()
        {
            for (int i = 0; i < 12; i++)
            {
                cb[i].Checked = false;
                Delay(100);
            }
        }
        private void dev_pwr_all_off_button_Click(object sender, EventArgs e)
        {
            dev_pwr_all_off_set();
        }

        private void psu_connect_set()
        {
            if (psw3036_serialPort.IsOpen == false)
            {
                psw3036_serialPort.BaudRate = 115200;
                psw3036_serialPort.DataBits = 8;
                psw3036_serialPort.PortName = psw3036_port_cbb.SelectedItem.ToString();
                psw3036_serialPort.Open();
                psw3036_serialPort.Write("*RST\r\n");
                psw3036_serialPort.Write("*CLS\r\n");
            }
        }
        private void psu_connect_button_Click(object sender, EventArgs e)
        {
            psu_connect_set();
        }

        private void psu_on_set()
        {
            psu_set_v_value = 0;
            if (psw3036_serialPort.IsOpen == true)
            {
                psu_status = 1;
                psw3036_serialPort.Write("outp:stat:imm 1\r\n");
            }
        }
        private void psu_on_button_Click(object sender, EventArgs e)
        {
            psu_on_set();
        }

        private void psu_off_set()
        {
            psu_set_v_value = 0;
            if (psw3036_serialPort.IsOpen == true)
            {
                psu_status = 0;
                psw3036_serialPort.Write("outp:stat:imm 0\r\n");
            }
        }
        private void psu_off_button_Click(object sender, EventArgs e)
        {
            psu_off_set();
        }

        private void psu_set()
        {
            psu_power_set(psu_target_v_textBox.Text, psu_target_i_textBox.Text);
            psu_target_v_value = Convert.ToDouble(psu_target_v_textBox.Text);
        }
        private void psu_set_button_Click(object sender, EventArgs e)
        {
            psu_set();
        }

        private void config_save_btn_Click(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath;
            for (int i = 0; i < 12; i++)
            {
                if (cbb[i].SelectedItem.ToString() != "")
                {
                    WritePrivateProfileString("Section", "dev" + i.ToString(), cbb[i].SelectedItem.ToString(), @filepath + "\\config.ini");
                }
            }

            if (psw3036_port_cbb.SelectedItem.ToString() != "")
            {
                WritePrivateProfileString("Section", "psw3036", psw3036_port_cbb.SelectedItem.ToString(), @filepath + "\\config.ini");
            }

            if (psw3036_port_cbb.SelectedItem.ToString() != "")
            {
                WritePrivateProfileString("Section", "dmm", dmm_port_cbb.SelectedItem.ToString(), @filepath + "\\config.ini");
            }

            if (devchk_cbb.SelectedItem.ToString() != "")
            {
                WritePrivateProfileString("Section", "devchecker", devchk_cbb.SelectedItem.ToString(), @filepath + "\\config.ini");
            }
        }
        private void config_load_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = "ini";
            openFileDlg.Filter = "config(*.ini)|*.ini;";

            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    config_file_init(filename);
                }
            }
        }

        private void DMM_connect_set()
        {
            if (dmm_serialPort.IsOpen == false)
            {
                dmm_serialPort.BaudRate = 115200;
                dmm_serialPort.DataBits = 8;
                dmm_serialPort.PortName = dmm_port_cbb.SelectedItem.ToString();
                dmm_serialPort.Open();
                dmm_serialPort.WriteLine("*RST");
                dmm_serialPort.WriteLine("*CLS");
                dmm_serialPort.WriteLine("VDC");
                Delay(1000);
                dmm_serialPort.DiscardInBuffer();
                dmm_status = 1;
            }
        }
        private void DMM_connect_button_Click(object sender, EventArgs e)
        {
            DMM_connect_set();
        }

        private string dmm_get_vdc_value()
        {
            string dmm_value = "";

            if (dmm_serialPort.IsOpen == true)
            {
                dmm_serialPort.WriteLine("val?");
                dmm_value = dmm_serialPort.ReadLine();
                dmm_serialPort.ReadLine();
            }

            return dmm_value;
        }

        private void daq_gpio_set(int port, int bit, byte data)
        {
            ErrorCode err;
            for (int i = 0; i < 10; i++)
            {
                err = instantDoCtrl1.WriteBit(port, bit, data);
                if (err == 0)
                {
                    i = 10;
                }
            }
        }

        private void psu_power_set(string v, string i)
        {
            if (psw3036_serialPort.IsOpen == true)
            {
                if ((v != "") && (i != ""))
                {
                    psw3036_serialPort.Write("appl " + v + "," + i + "\r\n");
                }
            }
        }

        private void main_timer_init()
        {
            main_timer = new System.Timers.Timer();
            main_timer.Interval = 100;
            main_timer.Elapsed += new System.Timers.ElapsedEventHandler(main_timer_Elapsed);  //주기마다 실행되는 이벤트 등록
        }

        delegate void MainTimerEventFiredDelegate();
        void main_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new MainTimerEventFiredDelegate(main_timer_work));
        }

        private void main_timer_work()
        {
            if (op_status == 1)
            {
                if (main_timer_cnt == main_timer_wait)
                {
                    main_timer.Stop();

                    if (op_mode == 1)
                    {
                        if (op_step == 1)
                        {
                            op_status_lb.Text = "F/W 다운로드\r\n시작";
                            isp_on_set();
                            Delay(500);
                            device_reset_set();
                            Delay(500);
                            dev_fw_set();
                            Delay(100);

                            op_step = 2;
                        }
                        else if (op_step == 2)
                        {
                            if (dev_chk_result_cnt == dev_chk_cnt)
                            {
                                if (dev_chk_fail_cnt == 0)
                                {
                                    isp_off_set();
                                    Delay(100);
                                    device_reset_set();
                                    Delay(100);

                                    op_status_lb.Text = "F/W 다운로드\r\n완료";

                                    main_timer_cnt = 0;
                                    main_timer_wait = 50;
                                    op_step = 10;
                                    op_step_retry_cnt = 0;
                                }
                                else
                                {
                                    op_status_lb.Text = "F/W 다운로드\r\n실패";

                                    op_stop_btn.PerformClick();
                                    Delay(100);
                                }
                            }
                        }
                        else if (op_step == 3)
                        {
                            dev_iee64_rf_chk_set();
                            Delay(100);

                            if (op_step_retry_cnt == 0)
                            {
                                op_status_lb.Text = "IEEE64 주소 체크\r\n시작";
                            }
                            else
                            {
                                op_status_lb.Text = "IEEE64 주소 체크\r\n재시작";
                            }

                            main_timer_wait = 110;
                            main_timer_cnt = 0;
                            op_step = 4;
                        }
                        else if (op_step == 4)
                        {
                            for (int i = 0; i < dev_chk_cnt; i++)
                            {
                                if (dev_ieee64_rf_chk_lb[i].Text != "OK")
                                {
                                    dev_ieee64_rf_chk_lb[i].Text = "NG";
                                    dev_chk_fail_cnt++;
                                }
                                dev_mesasure_str_buf[i, 0] = dev_set_i_tb[i].Text;
                                dev_mesasure_str_buf[i, 1] = dev_ovp_v_tb[i].Text;
                                dev_mesasure_str_buf[i, 2] = dev_1st_v_tb[i].Text;
                                dev_mesasure_str_buf[i, 3] = dev_2nd_v_tb[i].Text;
                                dev_mesasure_str_buf[i, 4] = dev_adc_v_tb[i].Text;
                            }

                            if (dev_chk_fail_cnt == 0)
                            {
                                op_status_lb.Text = "IEEE64 주소 체크\r\n완료";

                                v_cal_step = 0;
                                op_step = 5;
                                op_step_retry_cnt = 0;
                            }
                            else
                            {
                                if (op_step_retry_cnt == op_step_retry)
                                {
                                    op_status_lb.Text = "IEEE64 주소 체크\r\n실패";

                                    op_stop_btn.PerformClick();
                                    Delay(100);
                                }
                                else
                                {
                                    op_step = 3;
                                    op_step_retry_cnt++;
                                }
                            }
                        }
                        else if (op_step == 5)
                        {
                            if (v_mode == 1) // 2V
                            {
                                if (v_cal_step == 14)
                                {
                                    op_step = 8;
                                }
                                else
                                {
                                    switch (v_cal_step)
                                    {
                                        case 0: psu_target_v_textBox.Text = "1.6"; break; // 1.6V
                                        case 1: psu_target_v_textBox.Text = "1.7"; break; // 1.7V
                                        case 2: psu_target_v_textBox.Text = "1.8"; break; // 1.8V
                                        case 3: psu_target_v_textBox.Text = "1.9"; break; // 1.9V
                                        case 4: psu_target_v_textBox.Text = "2.0"; break; // 2.0V
                                        case 5: psu_target_v_textBox.Text = "2.1"; break; // 2.1V
                                        case 6: psu_target_v_textBox.Text = "2.2"; break; // 2.2V
                                        case 7: psu_target_v_textBox.Text = "2.3"; break; // 2.3V
                                        case 8: psu_target_v_textBox.Text = "2.4"; break; // 2.4V
                                        case 9: psu_target_v_textBox.Text = "2.5"; break; // 2.5V
                                        case 10: psu_target_v_textBox.Text = "2.6"; break; // 2.6V
                                        case 11: psu_target_v_textBox.Text = "2.7"; break; // 2.7V
                                        case 12: psu_target_v_textBox.Text = "2.8"; break; // 2.8V
                                        case 13: psu_target_v_textBox.Text = "4.8"; break; // 4.8V
                                    }
                                }
                            }
                            else if ((v_mode == 2) || (v_mode == 3)) //6V,12V
                            {
                                if (v_cal_step == 2)
                                {
                                    op_step = 8;
                                }
                                else
                                {
                                    if (v_mode == 2) //6V
                                    {
                                        switch (v_cal_step)
                                        {
                                            case 0: psu_target_v_textBox.Text = "4.0"; break; // 4.0V
                                            case 1: psu_target_v_textBox.Text = "8.0"; break; // 8.0V
                                        }
                                    }
                                    else if (v_mode == 3) //12V
                                    {
                                        switch (v_cal_step)
                                        {
                                            case 0: psu_target_v_textBox.Text = "8.0"; break; // 8.0V
                                            case 1: psu_target_v_textBox.Text = "16.0"; break; // 16.0V
                                        }
                                    }
                                }
                            }
                            if (op_step_retry_cnt == 0)
                            {
                                op_status_lb.Text = psu_target_v_textBox.Text + "V 측정 전압\r\n보정 시작";
                            }

                            if (op_step != 8)
                            {
                                psu_set();
                                Delay(100);

                                main_timer_wait = 60;
                                main_timer_cnt = 0;
                                op_step = 6;
                            }
                        }

                        else if (op_step == 6)
                        {
                            dev_cal_set(v_mode, v_cal_step);
                            Delay(100);

                            main_timer_wait = 60;
                            main_timer_cnt = 0;
                            op_step = 7;
                        }

                        else if (op_step == 7)
                        {
                            dev_chk_fail_cnt = 0;

                            for (int i = 0; i < dev_chk_cnt; i++)
                            {
                                if (dev_cal_chk_lb[i].Text != "OK")
                                {
                                    dev_cal_chk_lb[i].Text = "NG";
                                    dev_chk_fail_cnt++;
                                }
                            }

                            if (dev_chk_fail_cnt == 0)
                            {
                                v_cal_step++;
                                op_step_retry_cnt = 0;
                            }
                            else
                            {
                                if (op_step_retry_cnt == op_step_retry)
                                {
                                    op_status_lb.Text = psu_target_v_textBox.Text + "V 측정 전압\r\n보정 실패";

                                    op_stop_btn.PerformClick();
                                    Delay(100);
                                }
                                else
                                {
                                    op_step_retry_cnt++;
                                    op_status_lb.Text = psu_target_v_textBox.Text + "V 측정 전압\r\n보정 재시작";
                                }
                            }
                            op_step = 5;
                        }

                        else if (op_step == 8)
                        {
                            op_status_lb.Text = "측정 전압\r\n보정 완료";
                            op_end_time_tb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            Delay(2000);

                            op_status_lb.Text = "작업 결과 DB 전송 시작";
                            op_step = 9;

                        }
                        else if (op_step == 9)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (db_con.State == ConnectionState.Open)
                                {
                                    //db_cmd = new MySqlCommand("INSERT INTO production(dateTime) VALUES('2019-02-21 04:39:01')", db_con);

                                    string temp_ieee64_str = dev_ieee64_tb[i].Text;
                                    temp_ieee64_str = temp_ieee64_str.Replace(" ", "");

                                    db_bms_pd = new DB_BmsProduction();
                                    db_cmd = new MySqlCommand("INSERT INTO " +
                                                              "production(" +
                                                              "" + db_bms_pd.field_str[0] + "," +  // dateTime
                                                              "" + db_bms_pd.field_str[1] + "," +  // completeDateTime
                                                              "" + db_bms_pd.field_str[3] + "," +  // type
                                                              "" + db_bms_pd.field_str[4] + "," +  // fwVersion 
                                                              "" + db_bms_pd.field_str[5] + "," +  // address
                                                              "" + db_bms_pd.field_str[9] + "," +  // inBarcode
                                                              "" + db_bms_pd.field_str[11] + "," +  // worker
                                                              "" + db_bms_pd.field_str[12] + "," +  // 1st v
                                                              "" + db_bms_pd.field_str[13] + "," +  // 2nd v
                                                              "" + db_bms_pd.field_str[14] + "," +  // OVP 
                                                              "" + db_bms_pd.field_str[15] + "," +  // ADC
                                                              "" + db_bms_pd.field_str[16] + "" +   // SetCurrent
                                                              ")" +
                                                              " VALUES (" +
                                                              "'" + op_start_time_tb.Text + "'," + // dateTime
                                                              "'" + op_end_time_tb.Text + "' ," + // completeDateTime
                                                              "" + v_mode + "," + // type
                                                              "'" + fw_version_tb.Text + "' ," + // fwVersion
                                                              "'" + temp_ieee64_str + "'," + // address
                                                              "'" + temp_ieee64_str + "'," + //inBarcode
                                                              "'" + worker_tb.Text + "'," + // worker
                                                              "" + Convert.ToDouble(dev_mesasure_str_buf[i, 2]) + "," + // 1st v
                                                              "" + Convert.ToDouble(dev_mesasure_str_buf[i, 3]) + "," + // 2nd v
                                                              "" + (int)(Convert.ToDouble(dev_mesasure_str_buf[i, 1]) * 1000) + "," + // ovp
                                                              "" + (int)(Convert.ToDouble(dev_mesasure_str_buf[i, 4]) * 1000) + "," + // adc
                                                              "" + (int)(Convert.ToDouble(dev_mesasure_str_buf[i, 0]) * 1000) + "" + // SetCurrent
                                                              ")", db_con);
                                    try
                                    {
                                        db_cmd.ExecuteNonQuery();
                                    }
                                    catch
                                    {
                                        //MessageBox.Show("DB Insert에 실패했습니다.");
                                    }
                                }
                            }

                            op_status_lb.Text = "작업 결과 DB 전송 완료";

                            op_stop_btn.PerformClick();
                            Delay(100);
                        }
                        else if (op_step == 0) board_check_cnt++;

                        else if (op_step == 10)
                        {

                            isp_off_set();
                            Delay(100);
                            device_reset_set();
                            Delay(500);

                            op_status_lb.Text = "데이터 측정\r\n시작";

                            adc_timer.Start();

                            op_step = 0;
                            //led off
                        }

                        if (board_check_cnt == 200)
                        {
                            board_check_cnt = 0;

                            adc_timer.Stop();

                            adc_timer_cnt = 0;

                            bd_chk_value_cnt = 0;

                            op_status_lb.Text = "데이터 측정\r\n완료";

                            op_end_time_tb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            bd_chk();
                            bd_avr_cal();

                            Delay(100);

                            op_stop_btn.PerformClick();

                            Delay(100);


                            if (db_check == true)
                            {
                                Delay(500);

                                for (int i = 0; i < 12; i++)
                                {
                                    if (dev_err_tb[i].Text == "Pass")
                                    {
                                        if (db_con.State == ConnectionState.Open)
                                        {
                                            //db_cmd = new MySqlCommand("INSERT INTO production(dateTime) VALUES('2019-02-21 04:39:01')", db_con);

                                            string temp_ieee64_str = dev_ieee64_tb[i].Text;
                                            string temp_ovp_str = dev_ovp_v_tb[i].Text;
                                            string temp_1st_str = dev_1st_v_tb[i].Text;
                                            string temp_2nd_str = dev_2nd_v_tb[i].Text;
                                            string temp_adc_str = dev_adc_v_tb[i].Text;
                                            temp_ieee64_str = temp_ieee64_str.Replace(" ", "");

                                            db_bms_pd = new DB_BmsProduction();
                                            db_cmd = new MySqlCommand("INSERT INTO " +
                                                                      "production(" +
                                                                      "dateTime, " +  // dateTime
                                                                      "completeDateTime, " +  // completeDateTime
                                                                      "type, " +  // type
                                                                      "fwVersion, " +  // fwVersion 
                                                                      "address, " +  // address
                                                                      "inBarcode, " +  // inBarcode
                                                                      "worker, " +  // worker
                                                                      "vOVP, " + //ovp V
                                                                      "v1st, " + //1st V
                                                                      "v2nd, " + //2nd V
                                                                      "vADC) " + //adc V
                                                                      " VALUES (" +
                                                                      "'" + op_start_time_tb.Text + "'," + // dateTime
                                                                      "'" + op_end_time_tb.Text + "' ," + // completeDateTime
                                                                      "" + v_mode + "," + // type
                                                                      "'" + fw_version_tb.Text + "' ," + // fwVersion
                                                                      "'" + temp_ieee64_str + "'," + // address
                                                                      "'" + temp_ieee64_str + "'," + //inBarcode
                                                                      "'" + worker_tb.Text + "'," + // worker
                                                                      "'" + temp_ovp_str + "'," +
                                                                      "'" + temp_1st_str + "'," +
                                                                      "'" + temp_2nd_str + "'," +
                                                                      "'" + temp_adc_str + "')" +
                                                                      " ON DUPLICATE KEY UPDATE" +
                                                                      " dateTime = '"
                                                                      + op_start_time_tb.Text + "'," +
                                                                      " completeDateTime = '"
                                                                      + op_end_time_tb.Text + "'," +
                                                                      " type = "
                                                                      + v_mode + "," +
                                                                      " fwVersion = '"
                                                                      + fw_version_tb.Text + "'," +
                                                                      " inBarcode = '"
                                                                      + temp_ieee64_str + "'," +
                                                                      " worker = '"
                                                                      + worker_tb.Text + "'," +
                                                                      " vOVP = '"
                                                                      + temp_ovp_str + "'," +
                                                                      " v1st = '"
                                                                      + temp_1st_str + "'," +
                                                                      " v2nd = '"
                                                                      + temp_2nd_str + "'," +
                                                                      " vADC = '"
                                                                      + temp_adc_str + "';", db_con);

                                            try
                                            {
                                                db_cmd.ExecuteNonQuery();
                                                op_status_lb.Text = " DB 저장\r\n완료";
                                            }
                                            catch (Exception e)
                                            {
                                                //label19.Text = e.ToString();
                                                //MessageBox.Show("DB Insert에 실패했습니다.");
                                                op_status_lb.Text = " 주소값 중복\r\n저장 실패";
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                    else if (op_mode == 2)
                    {
                        if (op_step == 1)
                        {
                            op_status_lb.Text = "Set & Device ID 설정 시작";

                            dev_id_set();
                            Delay(100);

                            main_timer_wait = 60;
                            main_timer_cnt = 0;
                            op_step = 2;
                        }
                        else if (op_step == 2)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (dev_sd_id_chk_lb[i].Text != "OK")
                                {
                                    dev_sd_id_chk_lb[i].Text = "NG";
                                }
                            }
                            op_status_lb.Text = "Set & Device ID 설정 완료";
                            Delay(2000);

                            op_step = 3;
                        }
                        else if (op_step == 3)
                        {
                            op_status_lb.Text = "작업 결과 DB 전송 시작";
                            Delay(2000);

                            if (db_con.State == ConnectionState.Open)
                            {
                                for (int i = 0; i < 12; i++)
                                {
                                    string temp_ieee64_str = dev_ieee64_tb[i].Text;
                                    temp_ieee64_str = temp_ieee64_str.Replace(" ", "");

                                    db_cmd = new MySqlCommand("UPDATE " +
                                                          "production " +
                                                          "SET setID = " + dev_s_id_tb[i].Text + " , " +
                                                          "deviceID = " + dev_d_id_tb[i].Text + " " +
                                                          "WHERE inBarcode='" + temp_ieee64_str + "'", db_con);
                                    try
                                    {
                                        db_cmd.ExecuteNonQuery();
                                    }
                                    catch
                                    {
                                        //MessageBox.Show("Set/Device ID Update에 실패했습니다.");
                                    }
                                }
                            }

                            op_status_lb.Text = "작업 결과 DB 전송 완료";
                            op_end_time_tb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            Delay(2000);

                            op_step = 4;
                        }
                        else if (op_step == 4)
                        {
                            op_stop_btn.PerformClick();
                            Delay(100);
                        }
                    }
                    else if (op_mode == 3)
                    {
                        if (op_step == 1)
                        {
                            op_status_lb.Text = "F/W 다운로드\r\n시작";
                            isp_on_set();
                            Delay(500);
                            device_reset_set();
                            Delay(500);
                            dev_fw_set();
                            Delay(100);

                            op_step = 2;
                        }
                        else if (op_step == 2)
                        {
                            if (dev_chk_result_cnt == dev_chk_cnt)
                            {
                                if (dev_chk_fail_cnt == 0)
                                {
                                    isp_off_set();
                                    Delay(100);
                                    device_reset_set();
                                    Delay(100);

                                    op_status_lb.Text = "F/W 다운로드\r\n완료";

                                    op_end_time_tb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    Delay(2000);

                                    op_stop_btn.PerformClick();
                                }
                                else
                                {
                                    op_status_lb.Text = "F/W 다운로드\r\n실패";

                                    op_stop_btn.PerformClick();
                                    Delay(100);
                                }
                            }
                        }
                    }
                    else if (op_mode == 4)
                    {
                        if (op_step == 1)
                        {
                            dev_iee64_rf_chk_set();
                            Delay(100);

                            if (op_step_retry_cnt == 0)
                            {
                                op_status_lb.Text = "IEEE64 주소 체크\r\n시작";
                            }
                            else
                            {
                                op_status_lb.Text = "IEEE64 주소 체크\r\n재시작";
                            }

                            main_timer_wait = 110;
                            main_timer_cnt = 0;
                            op_step = 2;
                        }
                        else if (op_step == 2)
                        {
                            for (int i = 0; i < dev_chk_cnt; i++)
                            {
                                if (dev_ieee64_rf_chk_lb[i].Text != "OK")
                                {
                                    dev_ieee64_rf_chk_lb[i].Text = "NG";
                                    dev_chk_fail_cnt++;
                                }
                                dev_mesasure_str_buf[i, 0] = dev_set_i_tb[i].Text;
                                dev_mesasure_str_buf[i, 1] = dev_ovp_v_tb[i].Text;
                                dev_mesasure_str_buf[i, 2] = dev_1st_v_tb[i].Text;
                                dev_mesasure_str_buf[i, 3] = dev_2nd_v_tb[i].Text;
                                dev_mesasure_str_buf[i, 4] = dev_adc_v_tb[i].Text;
                            }

                            if (dev_chk_fail_cnt == 0)
                            {
                                op_status_lb.Text = "IEEE64 주소 체크\r\n완료";

                                v_cal_step = 0;
                                op_step = 3;
                                op_step_retry_cnt = 0;
                            }
                            else
                            {
                                if (op_step_retry_cnt == op_step_retry)
                                {
                                    op_status_lb.Text = "IEEE64 주소 체크\r\n실패";

                                    op_stop_btn.PerformClick();
                                    Delay(100);
                                }
                                else
                                {
                                    op_step = 1;
                                    op_step_retry_cnt++;
                                }
                            }
                        }
                        if (op_step == 3)
                        {
                            if (v_mode == 1) // 2V
                            {
                                if (v_cal_step == 14)
                                {
                                    op_step = 6;
                                }
                                else
                                {
                                    switch (v_cal_step)
                                    {
                                        case 0: psu_target_v_textBox.Text = "1.6"; break; // 1.6V
                                        case 1: psu_target_v_textBox.Text = "1.7"; break; // 1.7V
                                        case 2: psu_target_v_textBox.Text = "1.8"; break; // 1.8V
                                        case 3: psu_target_v_textBox.Text = "1.9"; break; // 1.9V
                                        case 4: psu_target_v_textBox.Text = "2.0"; break; // 2.0V
                                        case 5: psu_target_v_textBox.Text = "2.1"; break; // 2.1V
                                        case 6: psu_target_v_textBox.Text = "2.2"; break; // 2.2V
                                        case 7: psu_target_v_textBox.Text = "2.3"; break; // 2.3V
                                        case 8: psu_target_v_textBox.Text = "2.4"; break; // 2.4V
                                        case 9: psu_target_v_textBox.Text = "2.5"; break; // 2.5V
                                        case 10: psu_target_v_textBox.Text = "2.6"; break; // 2.6V
                                        case 11: psu_target_v_textBox.Text = "2.7"; break; // 2.7V
                                        case 12: psu_target_v_textBox.Text = "2.8"; break; // 2.8V
                                        case 13: psu_target_v_textBox.Text = "4.8"; break; // 4.8V
                                    }
                                }
                            }
                            else if ((v_mode == 2) || (v_mode == 3)) //6V,12V
                            {
                                if (v_cal_step == 2)
                                {
                                    op_step = 6;
                                }
                                else
                                {
                                    if (v_mode == 2) //6V
                                    {
                                        switch (v_cal_step)
                                        {
                                            case 0: psu_target_v_textBox.Text = "4.0"; break; // 4.0V
                                            case 1: psu_target_v_textBox.Text = "8.0"; break; // 8.0V
                                        }
                                    }
                                    else if (v_mode == 3) //12V
                                    {
                                        switch (v_cal_step)
                                        {
                                            case 0: psu_target_v_textBox.Text = "8.0"; break; // 8.0V
                                            case 1: psu_target_v_textBox.Text = "16.0"; break; // 16.0V
                                        }
                                    }
                                }
                            }
                            if (op_step_retry_cnt == 0)
                            {
                                op_status_lb.Text = psu_target_v_textBox.Text + "V 측정 전압\r\n보정 시작";
                            }

                            if (op_step != 6)
                            {
                                psu_set();
                                Delay(100);

                                main_timer_wait = 60;
                                main_timer_cnt = 0;
                                op_step = 4;
                            }
                        }

                        else if (op_step == 4)
                        {
                            dev_cal_set(v_mode, v_cal_step);
                            Delay(100);

                            main_timer_wait = 60;
                            main_timer_cnt = 0;
                            op_step = 5;
                        }

                        else if (op_step == 5)
                        {
                            dev_chk_fail_cnt = 0;

                            for (int i = 0; i < dev_chk_cnt; i++)
                            {
                                if (dev_cal_chk_lb[i].Text != "OK")
                                {
                                    dev_cal_chk_lb[i].Text = "NG";
                                    dev_chk_fail_cnt++;
                                }
                            }

                            if (dev_chk_fail_cnt == 0)
                            {
                                v_cal_step++;
                                op_step_retry_cnt = 0;
                            }
                            else
                            {
                                if (op_step_retry_cnt == op_step_retry)
                                {
                                    op_status_lb.Text = psu_target_v_textBox.Text + "V 측정 전압\r\n보정 실패";

                                    op_stop_btn.PerformClick();
                                    Delay(100);
                                }
                                else
                                {
                                    op_step_retry_cnt++;
                                    op_status_lb.Text = psu_target_v_textBox.Text + "V 측정 전압\r\n보정 재시작";
                                }
                            }
                            op_step = 3;
                        }

                        else if (op_step == 6)
                        {
                            op_status_lb.Text = "측정 전압\r\n보정 완료";

                            op_end_time_tb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            Delay(2000);

                            op_stop_btn.PerformClick();
                            Delay(100);
                        }
                    }
                    else if (op_mode == 5) //보드 체크 부분
                    {
                        if (op_step == 0) board_check_cnt++;

                        if (op_step == 1)
                        {

                            isp_off_set();
                            Delay(100);
                            device_reset_set();
                            Delay(500);

                            op_status_lb.Text = "데이터 측정\r\n시작";

                            adc_timer.Start();

                            op_step = 0;
                            //led off
                        }

                        if (board_check_cnt == 200)
                        {
                            board_check_cnt = 0;

                            adc_timer.Stop();

                            adc_timer_cnt = 0;

                            bd_chk_value_cnt = 0;

                            op_status_lb.Text = "데이터 측정\r\n완료";

                            op_end_time_tb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            bd_chk();
                            bd_avr_cal();

                            Delay(100);

                            op_stop_btn.PerformClick();

                            Delay(100);


                            if (db_check == true)
                            {
                                Delay(500);

                                for (int i = 0; i < 12; i++)
                                {
                                    if (dev_err_tb[i].Text == "Pass")
                                    {
                                        if (db_con.State == ConnectionState.Open)
                                        {
                                            //db_cmd = new MySqlCommand("INSERT INTO production(dateTime) VALUES('2019-02-21 04:39:01')", db_con);

                                            string temp_ieee64_str = dev_ieee64_tb[i].Text;
                                            string temp_ovp_str = dev_ovp_v_tb[i].Text;
                                            string temp_1st_str = dev_1st_v_tb[i].Text;
                                            string temp_2nd_str = dev_2nd_v_tb[i].Text;
                                            string temp_adc_str = dev_adc_v_tb[i].Text;
                                            temp_ieee64_str = temp_ieee64_str.Replace(" ", "");

                                            db_bms_pd = new DB_BmsProduction();
                                            db_cmd = new MySqlCommand("INSERT INTO " +
                                                                      "production(" +
                                                                      "dateTime, " +  // dateTime
                                                                      "completeDateTime, " +  // completeDateTime
                                                                      "type, " +  // type
                                                                      "fwVersion, " +  // fwVersion 
                                                                      "address, " +  // address
                                                                      "inBarcode, " +  // inBarcode
                                                                      "worker, " +  // worker
                                                                      "vOVP, " + //ovp V
                                                                      "v1st, " + //1st V
                                                                      "v2nd, " + //2nd V
                                                                      "vADC) " + //adc V
                                                                      " VALUES (" +
                                                                      "'" + op_start_time_tb.Text + "'," + // dateTime
                                                                      "'" + op_end_time_tb.Text + "' ," + // completeDateTime
                                                                      "" + v_mode + "," + // type
                                                                      "'" + fw_version_tb.Text + "' ," + // fwVersion
                                                                      "'" + temp_ieee64_str + "'," + // address
                                                                      "'" + temp_ieee64_str + "'," + //inBarcode
                                                                      "'" + worker_tb.Text + "'," + // worker
                                                                      "'" + temp_ovp_str + "'," +
                                                                      "'" + temp_1st_str + "'," +
                                                                      "'" + temp_2nd_str + "'," +
                                                                      "'" + temp_adc_str + "')" +
                                                                      " ON DUPLICATE KEY UPDATE" +
                                                                      " dateTime = '"
                                                                      + op_start_time_tb.Text + "'," +
                                                                      " completeDateTime = '"
                                                                      + op_end_time_tb.Text + "'," +
                                                                      " type = "
                                                                      + v_mode + "," +
                                                                      " fwVersion = '"
                                                                      + fw_version_tb.Text + "'," +
                                                                      " inBarcode = '"
                                                                      + temp_ieee64_str + "'," +
                                                                      " worker = '"
                                                                      + worker_tb.Text + "'," +
                                                                      " vOVP = '"
                                                                      + temp_ovp_str + "'," +
                                                                      " v1st = '"
                                                                      + temp_1st_str + "'," +
                                                                      " v2nd = '"
                                                                      + temp_2nd_str + "'," +
                                                                      " vADC = '"
                                                                      + temp_adc_str + "';", db_con);

                                            try
                                            {
                                                db_cmd.ExecuteNonQuery();
                                                op_status_lb.Text = " DB 저장\r\n완료";
                                            }
                                            catch (Exception e)
                                            {
                                                //label19.Text = e.ToString();
                                                //MessageBox.Show("DB Insert에 실패했습니다.");
                                                op_status_lb.Text = " 주소값 중복\r\n저장 실패";
                                            }
                                        }
                                    }
                                }

                            }

                        }
                    }

                    if (op_status == 1)
                    {
                        main_timer.Start();
                    }
                }
                else
                {
                    main_timer_cnt++;
                }
            }

        }

        private void adc_timer_init()
        {
            adc_timer = new System.Timers.Timer();
            adc_timer.Interval = 10;
            adc_timer.Elapsed += new System.Timers.ElapsedEventHandler(adc_timer_Elapsed);  //주기마다 실행되는 이벤트 등록
        }

        delegate void AdcTimerEventFiredDelegate();
        void adc_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new AdcTimerEventFiredDelegate(adc_timer_work));
        }

        private void adc_timer_work()
        {
            ErrorCode err1;
            ErrorCode err2;

            adc_timer_cnt++;

            if (adc_status == 1)
            {
                adc_cnt++;

                err1 = instantAiCtrl1.Read(0, 32, adc1_buf);
                err2 = instantAiCtrl2.Read(0, 32, adc2_buf);

                if (adc_cnt > adc_dummy_cnt)
                {
                    for (int i = 0; i < 32; i++)
                    {
                        adc1_sum_buf[i] += adc1_buf[i];
                        adc2_sum_buf[i] += adc2_buf[i];
                    }

                    if (adc_cnt == (adc_dummy_cnt + adc_measure_cnt))
                    {
                        for (int i = 0; i < 32; i++)
                        {
                            adc1_avr_buf[i] = adc1_sum_buf[i] / adc_measure_cnt;
                            adc2_avr_buf[i] = adc2_sum_buf[i] / adc_measure_cnt;
                        }



                        int j = 0;
                        for (int i = 0; i < 6; i++)
                        {
                            if (i == 3) j++;
                            //dev_set_i_tb[i].Text = adc1_avr_buf[j].ToString("N3");
                            //dev_set_i_tb[i + 6].Text = adc2_avr_buf[j].ToString("N3");
                            double temp1 = ((adc1_avr_buf[j] - dev_set_i_offset[i]) / dev_set_i_scale[i]);
                            double temp2 = ((adc2_avr_buf[j] - dev_set_i_offset[i + 6]) / dev_set_i_scale[i + 6]);
                            dev_set_i_tb[i].Text = temp1.ToString("N3");
                            dev_set_i_tb[i + 6].Text = temp2.ToString("N3");
                            j++;
                            dev_ovp_v_tb[i].Text = (adc1_avr_buf[j] * 2).ToString("N3");
                            dev_ovp_v_tb[i + 6].Text = (adc2_avr_buf[j] * 2).ToString("N3");
                            j++;
                            dev_1st_v_tb[i].Text = adc1_avr_buf[j].ToString("N3");
                            dev_1st_v_tb[i + 6].Text = adc2_avr_buf[j].ToString("N3");
                            j++;
                            dev_2nd_v_tb[i].Text = adc1_avr_buf[j].ToString("N3");
                            dev_2nd_v_tb[i + 6].Text = adc2_avr_buf[j].ToString("N3");
                            j++;
                            dev_adc_v_tb[i].Text = adc1_avr_buf[j].ToString("N3");
                            dev_adc_v_tb[i + 6].Text = adc2_avr_buf[j].ToString("N3");
                            j++;

                        }


                        string[] adc_txt1 = new string[1];
                        string adc_txt2 = "";

                        for (int i = 0; i < 12; i++)
                        {
                            if (bd_chk_value_cnt < 20)
                            {
                                bd_chk_value[i, bd_chk_value_cnt, 0] = Convert.ToDouble(dev_set_i_tb[i].Text);
                                bd_chk_value[i, bd_chk_value_cnt, 1] = Convert.ToDouble(dev_ovp_v_tb[i].Text);
                                bd_chk_value[i, bd_chk_value_cnt, 2] = Convert.ToDouble(dev_1st_v_tb[i].Text);
                                bd_chk_value[i, bd_chk_value_cnt, 3] = Convert.ToDouble(dev_2nd_v_tb[i].Text);
                                bd_chk_value[i, bd_chk_value_cnt, 4] = Convert.ToDouble(dev_adc_v_tb[i].Text);
                            }
                            adc_txt2 +=

                                dev_set_i_tb[i].Text + "    " +

                                dev_ovp_v_tb[i].Text + "    " +

                                dev_1st_v_tb[i].Text + "    " +

                                dev_2nd_v_tb[i].Text + "    " +

                                dev_adc_v_tb[i].Text + "    " +

                                DateTime.Now.ToString("mmss") + "   ";

                        }
                        if (bd_chk_value_cnt != 20) bd_chk_value_cnt++;
                        string savePath = @"C:\Users\abc\Desktop\log\log.txt";
                        File.AppendAllLines(savePath, adc_txt1);
                        File.AppendAllText(savePath, adc_txt2);
                        using (StreamWriter sr = new StreamWriter(savePath, true))





                            //System.IO.File.WriteAllText(savePath, adc_txt, Encoding.Default);

                            Array.Clear(adc1_buf, 0, adc1_buf.Length);
                        Array.Clear(adc1_sum_buf, 0, adc1_sum_buf.Length);
                        Array.Clear(adc1_avr_buf, 0, adc1_avr_buf.Length);

                        Array.Clear(adc2_buf, 0, adc2_buf.Length);
                        Array.Clear(adc2_sum_buf, 0, adc2_sum_buf.Length);
                        Array.Clear(adc2_avr_buf, 0, adc2_avr_buf.Length);

                        adc_cnt = 0;
                    }
                }
            }


        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void power_set_timer_init()
        {
            power_set_timer = new System.Timers.Timer();
            power_set_timer.Interval = 100;
            power_set_timer.Elapsed += new System.Timers.ElapsedEventHandler(power_set_timer_Elapsed);  //주기마다 실행되는 이벤트 등록
        }

        delegate void PowersetTimerEventFiredDelegate();
        void power_set_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new PowersetTimerEventFiredDelegate(power_set_timer_work));
        }

        private void power_set_timer_work()
        {
            if (psu_status == 1)
            {
                if (power_set_timer_cnt == 5)
                {
                    power_set_timer_cnt = 0;
                    if (psu_target_v_textBox.Text != "")
                    {
                        double psu_preset_v_value = 0;
                        psu_preset_v_value = psu_set_v_value;

                        psu_set_v_value = dmm_f_value;
                        psu_set_v_value = psu_preset_v_value + (psu_target_v_value - dmm_f_value);
                        psu_set_v_textBox.Text = string.Format("{0:F3}", psu_set_v_value);
                        psu_seg_ctl.DigitText = psu_set_v_textBox.Text;
                        psu_power_set(psu_set_v_textBox.Text, psu_target_i_textBox.Text);
                    }
                }
                else
                {
                    if (power_set_timer_cnt > 5)
                    {
                        power_set_timer_cnt = 0;
                    }
                    power_set_timer_cnt++;
                }
            }

            if (dmm_status == 1)
            {
                if (dmm_cnt == 5)
                {
                    dmm_avr_value = dmm_sum_value / 5;

                    if (dmm_avr_value != 0)
                    {
                        dmm_v_textBox.Text = string.Format("{0:F3}", dmm_avr_value);
                        dmm_seg_ctl.DigitText = dmm_v_textBox.Text;
                    }
                    else
                    {
                        if (dmm_v_textBox.Text != "No Data")
                        {
                            dmm_v_textBox.Text = "No Data";
                        }
                    }
                    dmm_cnt = 0;
                    dmm_sum_value = 0;
                    dmm_avr_value = 0;
                }
                else
                {
                    dmm_cnt++;
                    dmm_str_value = dmm_get_vdc_value();
                    if (dmm_str_value != "")
                    {
                        dmm_f_value = Convert.ToDouble(dmm_str_value);
                        dmm_sum_value += dmm_f_value;
                    }
                }
            }
        }

        private void rf_rx_timer_init()
        {
            rf_rx_timer = new System.Timers.Timer();
            rf_rx_timer.Interval = 100;
            rf_rx_timer.Elapsed += new System.Timers.ElapsedEventHandler(rf_rx_timer_Elapsed);  //주기마다 실행되는 이벤트 등록
        }

        delegate void RfrxTimerEventFiredDelegate();

        void rf_rx_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new RfrxTimerEventFiredDelegate(rf_rx_timer_work));
        }

        private void rf_rx_timer_work()
        {
            rf_rx_timer_cnt++;
            if (rf_rx_timer_cnt == rf_rx_timer_wait && devchk_rx_flag == 1)
            {
                rf_rx_timer.Stop();
                rf_rx_timer_cnt = 0;
                devchk_rx_flag = 0;
                while (devchk_queue.ring_buf_len != 0)
                {
                    byte[] devchk_ieee64_adr = new byte[8];

                    devchek_serialPort_Parser(devchk_read_buf, devchk_read_buf_cnt);

                    if (((devchk_read_buf[0] == 0xAC) && (devchk_read_buf[1] == 0x48) && (devchk_read_buf[2] == 0x3B)) ||
                        ((devchk_read_buf[0] == 0xD0) && (devchk_read_buf[1] == 0x1D) && (devchk_read_buf[2] == 0x0A)) ||
                        ((devchk_read_buf[0] == 0xD0) && (devchk_read_buf[1] == 0x17) && (devchk_read_buf[2] == 0x0A)) ||
                        ((devchk_read_buf[0] == 0xD0) && (devchk_read_buf[1] == 0x18) && (devchk_read_buf[2] == 0x0A)) ||
                        ((devchk_read_buf[0] == 0xD0) && (devchk_read_buf[1] == 0x1A) && (devchk_read_buf[2] == 0x0A)) ||
                        ((devchk_read_buf[0] == 0xD0) && (devchk_read_buf[1] == 0x16) && (devchk_read_buf[2] == 0x0C)))
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            devchk_ieee64_adr[i] = devchk_read_buf[10 - i];
                        }

                        for (int i = 0; i < dev_chk_cnt; i++)
                        {
                            string temp_ieee64_str = dev_ieee64_tb[i].Text;
                            temp_ieee64_str = temp_ieee64_str.Replace(" ", "");
                            byte[] temp_ieee64_buf = ToByteArray(temp_ieee64_str);

                            if (temp_ieee64_buf.SequenceEqual(devchk_ieee64_adr)) // 내일
                            {
                                if (devchk_read_buf[1] == 0x48)
                                {
                                    dev_ieee64_rf_chk_lb[i].Text = "OK";
                                    dev_ieee64_low_chk_tb[i].Text = devchk_ieee64_adr[4].ToString("X2") + " " + devchk_ieee64_adr[5].ToString("X2") + " " +
                                                                    devchk_ieee64_adr[6].ToString("X2") + " " + devchk_ieee64_adr[7].ToString("X2");
                                    dev_ieee64_low_chk_tb[i].BackColor = Color.LightGreen;
                                }
                                else if (devchk_read_buf[1] == 0x1D) //2V Cal
                                {
                                    dev_cal_chk_lb[i].Text = "OK";
                                }
                                else if (devchk_read_buf[1] == 0x17) //6V,12V Cal 1st
                                {
                                    dev_cal_chk_lb[i].Text = "OK";
                                }
                                else if (devchk_read_buf[1] == 0x18) //6V,12V Cal 2nd
                                {
                                    dev_cal_chk_lb[i].Text = "OK";
                                }
                                else if (devchk_read_buf[1] == 0x1A)
                                {
                                    byte[] temp_v_buf = new byte[3];
                                    int temp_v_value = 0;
                                    double temp_v_d_value = 0;

                                    temp_v_buf[0] = devchk_read_buf[11];
                                    temp_v_buf[1] = devchk_read_buf[12];
                                    temp_v_value = BitConverter.ToInt16(temp_v_buf, 0);
                                    temp_v_d_value = (double)(temp_v_value) / 1000;
                                    dev_v_rd_tb[i].Text = string.Format("{0:F3}", temp_v_d_value);
                                }
                                else if (devchk_read_buf[1] == 0x16)
                                {
                                    int temp_sid;
                                    int temp_did;
                                    byte[] temp_sid_buf = new byte[4];
                                    byte[] temp_did_buf = new byte[4];

                                    temp_sid = Convert.ToInt32(dev_s_id_tb[i].Text);
                                    temp_did = Convert.ToInt32(dev_d_id_tb[i].Text);
                                    temp_sid_buf = BitConverter.GetBytes(temp_sid);
                                    temp_did_buf = BitConverter.GetBytes(temp_did);

                                    if ((temp_sid_buf[0] == devchk_read_buf[11]) && (temp_sid_buf[1] == devchk_read_buf[12]) &&
                                        (temp_did_buf[0] == devchk_read_buf[13]) && (temp_did_buf[1] == devchk_read_buf[14]))
                                    {
                                        dev_sd_id_chk_lb[i].Text = "OK";
                                        dev_s_id_tb[i].BackColor = Color.LightGreen;
                                        dev_d_id_tb[i].BackColor = Color.LightGreen;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void rf_tx_timer_init()
        {
            rf_tx_timer = new System.Timers.Timer();
            rf_tx_timer.Interval = 100;
            rf_tx_timer.Elapsed += new System.Timers.ElapsedEventHandler(rf_tx_timer_Elapsed);  //주기마다 실행되는 이벤트 등록
        }

        delegate void RftxTimerEventFiredDelegate();
        void rf_tx_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new RftxTimerEventFiredDelegate(rf_tx_timer_work));
        }

        private void rf_tx_timer_work()
        {
            rf_tx_timer_cnt++;

            if (rf_tx_timer_cnt == rf_tx_timer_wait && devchk_tx_flag == 1)
            {
                rf_tx_timer_cnt = 0;
                rf_tx_timer.Stop();

                for (int i = 0; i < 12; i++)
                {
                    string temp_ieee64_str = dev_ieee64_tb[i].Text;
                    temp_ieee64_str = temp_ieee64_str.Replace(" ", "");
                    devchk_write_data = ToByteArray(temp_ieee64_str);
                    Array.Reverse(devchk_write_data);

                    devchk_write_buf = new byte[128];
                    devchek_MakePkt(devchk_write_buf, 0xAC, 0x43, 0x08, devchk_write_data);
                    devchk_serialPort.Write(devchk_write_buf, 0, 12);
                    Delay(100);

                    devchk_write_data = new byte[] { 0x01 };
                    devchek_MakePkt(devchk_write_buf, 0xD0, 0x1A, 0x01, devchk_write_data);
                    devchk_serialPort.Write(devchk_write_buf, 0, 5);
                }
                devchk_rx_flag = 1;
                rf_rx_timer_wait = 10;
                rf_rx_timer.Start();
                rf_tx_timer.Start();
            }
        }

        private void devchk_serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (devchk_serialPort.BytesToRead > 0)
            {
                try
                {
                    devchk_queue.ring_buffer_push((byte)devchk_serialPort.ReadByte());
                }
                catch (TimeoutException ex)
                {
                    //Debug.WriteLine(ex.ToString());
                }
            }
        }
        private void devchek_serialPort_Parser(byte[] buf, byte buf_cnt)
        {
            byte header = 0;
            bool header_chk = true;
            byte length = 0;
            byte cmd = 0;
            byte chksum = 0;

            byte[] data_buf = new byte[256];
            byte pkt_chksum = 0;

            while (header_chk)
            {
                header = devchk_queue.ring_buffer_pop();
                if (header == 0XAC || header == 0XD0)
                {
                    header_chk = false;
                }
            }

            cmd = devchk_queue.ring_buffer_pop();
            length = devchk_queue.ring_buffer_pop();

            for (int i = 0; i < length; i++)
            {
                data_buf[i] = devchk_queue.ring_buffer_pop();
            }

            chksum = devchk_queue.ring_buffer_pop();

            buf[buf_cnt++] = header;
            buf[buf_cnt++] = cmd;
            buf[buf_cnt++] = length;
            Buffer.BlockCopy(data_buf, 0, buf, 3, length);
            buf_cnt += length;

            for (int i = 0; i < buf_cnt; i++)
            {
                pkt_chksum += buf[i];
            }
            if (chksum == pkt_chksum)
            {
                buf[buf_cnt++] = pkt_chksum;
            }
        }
        public static byte[] ToByteArray(String hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length / 2; i++) bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            return bytes;
        }

        private void dev_iee64_rf_chk_set()
        {
            if (devchk_serialPort.IsOpen == true)
            {
                for (int i = 0; i < 12; i++)
                {
                    dev_ieee64_rf_chk_lb[i].Text = "Wait..";
                    dev_ieee64_low_chk_tb[i].Text = "";
                    dev_ieee64_low_chk_tb[i].BackColor = Color.White;
                }
                devchk_write_buf = new byte[] { 0xAC, 0x48, 0x06, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFB };
                devchk_serialPort.Write(devchk_write_buf, 0, 10);

                dev_chk_fail_cnt = 0;
                dev_chk_result_cnt = 0;

                devchk_rx_flag = 1;
                rf_rx_timer_cnt = 0;
                rf_rx_timer_wait = 100;
                rf_rx_timer.Start();
            }
        }
        private void dev_ieee64_rf_chk_btn_Click(object sender, EventArgs e)
        {
            dev_iee64_rf_chk_set();
        }

        private void dev_cal_set(int mode, int step)
        {
            if (devchk_serialPort.IsOpen == true)
            {
                devchk_cal_v_value = (int)(psu_target_v_value * 1000);
                devchk_cal_v_buf = BitConverter.GetBytes(devchk_cal_v_value);

                for (int i = 0; i < 12; i++)
                {
                    dev_cal_chk_lb[i].Text = "Wait..";

                    string temp_ieee64_str = dev_ieee64_tb[i].Text;
                    temp_ieee64_str = temp_ieee64_str.Replace(" ", "");
                    devchk_write_data = ToByteArray(temp_ieee64_str);
                    Array.Reverse(devchk_write_data);

                    devchk_write_buf = new byte[128];
                    devchek_MakePkt(devchk_write_buf, 0xAC, 0x43, 0x08, devchk_write_data);
                    devchk_serialPort.Write(devchk_write_buf, 0, 12);
                    Delay(100);

                    devchk_write_buf = new byte[128];
                    if (mode == 1) // 2V
                    {
                        devchek_MakePkt(devchk_write_buf, 0xD0, 0x1D, 0x02, devchk_cal_v_buf);
                    }
                    else if (((mode == 2) || (mode == 3)) && (step == 0)) //6V,12V 1st
                    {
                        devchek_MakePkt(devchk_write_buf, 0xD0, 0x17, 0x02, devchk_cal_v_buf);
                    }
                    else if (((mode == 2) || (mode == 3)) && (step == 1)) //6V,12V 2nd
                    {
                        devchek_MakePkt(devchk_write_buf, 0xD0, 0x18, 0x02, devchk_cal_v_buf);
                    }
                    devchk_serialPort.Write(devchk_write_buf, 0, 6);
                }

                dev_chk_fail_cnt = 0;
                dev_chk_result_cnt = 0;

                devchk_rx_flag = 1;
                rf_rx_timer_wait = 50;
                rf_rx_timer.Start();
            }
        }
        private void dev_cal_btn_Click(object sender, EventArgs e)
        {
            //dev_cal_set();
        }

        private void devchek_MakePkt(byte[] buf, byte header, byte cmd, byte length, byte[] data)
        {
            buf[0] = header;
            buf[1] = cmd;
            buf[2] = length;
            for (int i = 0; i < length; i++)
            {
                buf[3 + i] = data[i];
            }

            buf[length + 3] = devchek_MakeChksum(buf, length + 3);
        }
        private byte devchek_MakeChksum(byte[] buf, int buf_length)
        {
            byte chksum = 0;

            for (int i = 0; i < buf_length; i++)
            {
                chksum += buf[i];
            }

            return chksum;
        }

        private void devchk_connect_set()
        {
            if (devchk_serialPort.IsOpen == false)
            {

                devchk_serialPort.BaudRate = 115200;
                devchk_serialPort.DataBits = 8;
                devchk_serialPort.PortName = devchk_cbb.SelectedItem.ToString();
                devchk_serialPort.ReadTimeout = 1000;
                devchk_serialPort.Open();

                devchk_write_buf = new byte[] { 0xAC, 0x45, 0x01, 0x0F, 0X01 };
                devchk_serialPort.Write(devchk_write_buf, 0, 5);
                devchk_write_buf = new byte[] { 0xAC, 0x44, 0x02, 0x34, 0X12, 0x38 };
                devchk_serialPort.Write(devchk_write_buf, 0, 6);
            }
        }
        private void devchk_connect_button_Click(object sender, EventArgs e)
        {
            devchk_connect_set();
        }

        private void dev_v_read_set()
        {
            if (devchk_serialPort.IsOpen == true && devchk_tx_flag == 0)
            {
                for (int i = 0; i < dev_chk_cnt; i++)
                {
                    dev_v_rd_tb[i].BackColor = Color.LightGray;
                    string temp_ieee64_str = dev_ieee64_tb[i].Text;
                    temp_ieee64_str = temp_ieee64_str.Replace(" ", "");
                    devchk_write_data = ToByteArray(temp_ieee64_str);
                    Array.Reverse(devchk_write_data);

                    devchk_write_buf = new byte[128];
                    devchek_MakePkt(devchk_write_buf, 0xAC, 0x43, 0x08, devchk_write_data);
                    devchk_serialPort.Write(devchk_write_buf, 0, 12);
                    Delay(100);

                    devchk_write_data = new byte[] { 0x01 };
                    devchek_MakePkt(devchk_write_buf, 0xD0, 0x1A, 0x01, devchk_write_data);
                    devchk_serialPort.Write(devchk_write_buf, 0, 5);
                }
                devchk_tx_flag = 1;
                rf_tx_timer_wait = 10;
                rf_tx_timer_cnt = 0;
                rf_tx_timer.Start();
            }
            else if (devchk_tx_flag == 1)
            {
                devchk_tx_flag = 0;
                devchk_rx_flag = 0;
                rf_tx_timer.Stop();
                rf_rx_timer.Stop();
                for (int i = 0; i < 12; i++)
                {
                    dev_v_rd_tb[i].Text = "Wait";
                }
            }
        }
        private void dev_v_read_btn_Click(object sender, EventArgs e)
        {
            dev_v_read_set();
        }

        private void dev_id_set()
        {
            if (devchk_serialPort.IsOpen == true)
            {
                for (int i = 0; i < 12; i++)
                {
                    string temp_ieee64_str = dev_ieee64_tb[i].Text;
                    temp_ieee64_str = temp_ieee64_str.Replace(" ", "");
                    devchk_write_data = ToByteArray(temp_ieee64_str);
                    Array.Reverse(devchk_write_data);

                    devchk_write_buf = new byte[128];
                    devchek_MakePkt(devchk_write_buf, 0xAC, 0x43, 0x08, devchk_write_data);
                    devchk_serialPort.Write(devchk_write_buf, 0, 12);
                    Delay(100);

                    devchk_write_data = new byte[128];
                    devchk_write_sid = new byte[3];
                    devchk_write_did = new byte[3];

                    int temp_sid;
                    int temp_did;

                    temp_sid = Convert.ToInt32(dev_s_id_tb[i].Text);
                    temp_did = Convert.ToInt32(dev_d_id_tb[i].Text);
                    devchk_write_sid = BitConverter.GetBytes(temp_sid);
                    devchk_write_did = BitConverter.GetBytes(temp_did);

                    Buffer.BlockCopy(devchk_write_sid, 0, devchk_write_data, 0, 2);
                    Buffer.BlockCopy(devchk_write_did, 0, devchk_write_data, 2, 2);

                    devchek_MakePkt(devchk_write_buf, 0xD0, 0x16, 0x04, devchk_write_data);
                    devchk_serialPort.Write(devchk_write_buf, 0, 8);
                }
                devchk_rx_flag = 1;
                rf_rx_timer_wait = 50;
                rf_rx_timer.Start();
            }
        }
        private void dev_id_set_btn_Click(object sender, EventArgs e)
        {
            dev_id_set();
        }

        private int db_init()
        {
            int status = 0;

            db_con_str = "Server=" + db_serber_name + "Database=" + db_database_name + "Uid=" + db_id + "Pwd=" + db_password + ";CharSet=utf8;";

            db_con = new MySqlConnection(db_con_str);
            db_con.Open();
            if (db_con.State == ConnectionState.Open)
            {
                status = 1;

            }
            else if (db_con.State == ConnectionState.Closed)
            {
                status = -1;
            }
            return status;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            db_init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (db_con.State == ConnectionState.Open)
            {
                //db_cmd = new MySqlCommand("INSERT INTO production(dateTime) VALUES('2019-02-21 04:39:01')", db_con);

                db_bms_pd = new DB_BmsProduction();
                db_cmd = new MySqlCommand("INSERT INTO " +
                                          "production(" +
                                          "" + db_bms_pd.field_str[0] + "," +  // dateTime
                                          "" + db_bms_pd.field_str[1] + "," +  // completeDateTime
                                          "" + db_bms_pd.field_str[3] + "," +  // type
                                          "" + db_bms_pd.field_str[4] + "," +  // fwVersion 
                                          "" + db_bms_pd.field_str[5] + "," +  // address
                                          "" + db_bms_pd.field_str[9] + "," +  // inBarcode
                                          "" + db_bms_pd.field_str[11] + "" +  // worker
                                          ")" +
                                          " VALUES (" +
                                          "'" + op_start_time_tb.Text + "'," + // dateTime
                                          "'" + op_end_time_tb.Text + "' ," + // completeDateTime
                                          "" + v_mode + "," + // type
                                          "'" + fw_version_tb.Text + "' ," + // fwVersion
                                          "'0015510000000003'," +
                                          "'0015510000000003'," +
                                          "'" + worker_tb.Text + "')", db_con);
                try
                {
                    db_cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("DB Insert에 실패했습니다.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (db_con.State == ConnectionState.Open)
            {
                for (int i = 0; i < 12; i++)
                {
                    string temp_ieee64_str = dev_ieee64_tb[i].Text;
                    temp_ieee64_str = temp_ieee64_str.Replace(" ", "");

                    db_cmd = new MySqlCommand("UPDATE " +
                                          "production " +
                                          "SET setID = " + dev_s_id_tb[i].Text + " , " +
                                          "deviceID = " + dev_d_id_tb[i].Text + " " +
                                          "WHERE inBarcode='" + temp_ieee64_str + "'", db_con);
                    try
                    {
                        db_cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        //MessageBox.Show("Set/Device ID Update에 실패했습니다.");
                    }
                }
            }
        }

        private void dev_2V_mode_btn_Click(object sender, EventArgs e)
        {
            v_mode = 1;
            dev_2V_mode_btn.BackColor = Color.SkyBlue;
            dev_6V_mode_btn.BackColor = Color.Gray;
            dev_12V_mode_btn.BackColor = Color.Gray;

            bd_chk_avr_ovp.Text = "1.740";
            bd_chk_avr_1st.Text = "4.950";
            bd_chk_avr_2nd.Text = "3.300";
            bd_chk_avr_adc.Text = "0.570";

            bd_chk_err_value_ovp.Text = "0.10";
            bd_chk_err_value_1st.Text = "0.10";
            bd_chk_err_value_2nd.Text = "0.30";            
            bd_chk_err_value_adc.Text = "0.03";

            bd_chk_dvdt_ovp.Text = "0.12";
                bd_chk_dvdt_1st.Text = "0.10";
            bd_chk_dvdt_2nd.Text = "0.30";
            bd_chk_dvdt_adc.Text = "0.05";
            //dvdt수정해야함

            daq_adc_init(v_mode);
            psu_target_v_textBox.Text = "2.0";
            psu_target_i_textBox.Text = "10.0";
            psu_set_btn.PerformClick();

            adc_status = 1;
            //수정adc_timer.Start();
        }

        private void dev_6V_mode_btn_Click(object sender, EventArgs e)
        {
            v_mode = 2;
            dev_2V_mode_btn.BackColor = Color.Gray;
            dev_6V_mode_btn.BackColor = Color.SkyBlue;
            dev_12V_mode_btn.BackColor = Color.Gray;

            bd_chk_avr_ovp.Text = "5.810";
            bd_chk_avr_1st.Text = "3.306";
            bd_chk_avr_2nd.Text = "3.242";
            bd_chk_avr_adc.Text = "1.342";

            bd_chk_err_value_ovp.Text = "0.10";
            bd_chk_err_value_1st.Text = "0.07";
            bd_chk_err_value_2nd.Text = "0.06";
            bd_chk_err_value_adc.Text = "0.03";

            bd_chk_dvdt_ovp.Text = "0.12";
            bd_chk_dvdt_1st.Text = "0.10";
            bd_chk_dvdt_2nd.Text = "0.02";
            bd_chk_dvdt_adc.Text = "0.01";
            //dvdt수정해야함

            daq_adc_init(v_mode);
            psu_target_v_textBox.Text = "6.0";
            psu_target_i_textBox.Text = "10.0";
            psu_set_btn.PerformClick();

            adc_status = 1;
            // adc_timer.Start();
        }

        private void dev_12V_mode_btn_Click(object sender, EventArgs e)
        {
            v_mode = 3;
            dev_2V_mode_btn.BackColor = Color.Gray;
            dev_6V_mode_btn.BackColor = Color.Gray;
            dev_12V_mode_btn.BackColor = Color.SkyBlue;

            bd_chk_avr_ovp.Text = "11.623";
            bd_chk_avr_1st.Text = "4.978";
            bd_chk_avr_2nd.Text = "3.278";
            bd_chk_avr_adc.Text = "1.270";

            bd_chk_err_value_ovp.Text = "0.30";
            bd_chk_err_value_1st.Text = "0.03";
            bd_chk_err_value_2nd.Text = "0.05";
            bd_chk_err_value_adc.Text = "0.02";

            bd_chk_dvdt_ovp.Text = "0.20";
            bd_chk_dvdt_1st.Text = "0.03";
            bd_chk_dvdt_2nd.Text = "0.05";
            bd_chk_dvdt_adc.Text = "0.02";

            daq_adc_init(v_mode);
            psu_target_v_textBox.Text = "12.0";
            psu_target_i_textBox.Text = "10.0";
            psu_set_btn.PerformClick();

            adc_status = 1;
            // adc_timer.Start();
        }

        private void dev_auto_mode_btn_Click(object sender, EventArgs e)
        {
            op_mode = 1;
            dev_auto_mode_btn.BackColor = Color.SkyBlue;
            //dev_id_mode_btn.BackColor = Color.Gray;
            fw_down_mode_btn.BackColor = Color.Gray;

            board_check_btn.BackColor = Color.Gray;
            //rf_chk_v_cal_mode_btn.BackColor = Color.Gray;

            fw_download_btn.Enabled = false;
            //dev_ieee64_rf_chk_btn.Enabled = false;
            //dev_v_cal_btn.Enabled = false;
            //dev_v_read_btn.Enabled = false;
            //dev_id_set_btn.Enabled = false;
            db_btn.Enabled = true;

        }

        private void dev_id_mode_btn_Click(object sender, EventArgs e)
        {
            op_mode = 2;
            dev_auto_mode_btn.BackColor = Color.Gray;
            //dev_id_mode_btn.BackColor = Color.SkyBlue;
            fw_down_mode_btn.BackColor = Color.Gray;
            //rf_chk_v_cal_mode_btn.BackColor = Color.Gray;

            fw_download_btn.Enabled = false;
            //dev_ieee64_rf_chk_btn.Enabled = false;
            //dev_v_cal_btn.Enabled = false;
            //dev_v_read_btn.Enabled = false;
            //dev_id_set_btn.Enabled = true;
        }

        private void fw_down_mode_btn_Click(object sender, EventArgs e)
        {
            op_mode = 3;
            dev_auto_mode_btn.BackColor = Color.Gray;
            //dev_id_mode_btn.BackColor = Color.Gray;
            fw_down_mode_btn.BackColor = Color.SkyBlue;
            //rf_chk_v_cal_mode_btn.BackColor = Color.Gray;

            board_check_btn.BackColor = Color.Gray;

            fw_download_btn.Enabled = true;
            //dev_ieee64_rf_chk_btn.Enabled = false;
            //dev_v_cal_btn.Enabled = false;
            //dev_v_read_btn.Enabled = false;
            //dev_id_set_btn.Enabled = false;
        }

        private void rf_chk_v_cal_mode_btn_Click(object sender, EventArgs e)
        {
            op_mode = 4;
            dev_auto_mode_btn.BackColor = Color.Gray;
            //dev_id_mode_btn.BackColor = Color.Gray;
            fw_down_mode_btn.BackColor = Color.Gray;
            //rf_chk_v_cal_mode_btn.BackColor = Color.SkyBlue;

            fw_download_btn.Enabled = false;
            //dev_ieee64_rf_chk_btn.Enabled = true;
            //dev_v_cal_btn.Enabled = true;
            //dev_v_read_btn.Enabled = false;
            //dev_id_set_btn.Enabled = false;
        }

        private void system_init()
        {
            cbb = new ComboBox[12];
            cbb[0] = cbb1; cbb[1] = cbb2; cbb[2] = cbb3; cbb[3] = cbb4; cbb[4] = cbb5; cbb[5] = cbb6;
            cbb[6] = cbb7; cbb[7] = cbb8; cbb[8] = cbb9; cbb[9] = cbb10; cbb[10] = cbb11; cbb[11] = cbb12;

            for (int i = 0; i < 12; i++)
            {
                cbb[i].Items.AddRange(
                    (from qP in System.IO.Ports.SerialPort.GetPortNames()
                     orderby System.Text.RegularExpressions.Regex.Replace(qP, "~\\d",
                     string.Empty).PadLeft(6, '0')
                     select qP).ToArray()
                );
            }
            lb = new Label[12];
            lb[0] = lb1; lb[1] = lb2; lb[2] = lb3; lb[3] = lb4; lb[4] = lb5; lb[5] = lb6;
            lb[6] = lb7; lb[7] = lb8; lb[8] = lb9; lb[9] = lb10; lb[10] = lb11; lb[11] = lb12;

            cb = new CheckBox[12];
            cb[0] = cb1; cb[1] = cb2; cb[2] = cb3; cb[3] = cb4; cb[4] = cb5; cb[5] = cb6;
            cb[6] = cb7; cb[7] = cb8; cb[8] = cb9; cb[9] = cb10; cb[10] = cb11; cb[11] = cb12;

            pb = new ProgressBar[12];
            pb[0] = pb1; pb[1] = pb2; pb[2] = pb3; pb[3] = pb4; pb[4] = pb5; pb[5] = pb6;
            pb[6] = pb7; pb[7] = pb8; pb[8] = pb9; pb[9] = pb10; pb[10] = pb11; pb[11] = pb12;

            dev_set_i_tb = new TextBox[12];
            dev_set_i_tb[0] = dev1_set_i_tb; dev_set_i_tb[1] = dev2_set_i_tb; dev_set_i_tb[2] = dev3_set_i_tb; dev_set_i_tb[3] = dev4_set_i_tb;
            dev_set_i_tb[4] = dev5_set_i_tb; dev_set_i_tb[5] = dev6_set_i_tb; dev_set_i_tb[6] = dev7_set_i_tb; dev_set_i_tb[7] = dev8_set_i_tb;
            dev_set_i_tb[8] = dev9_set_i_tb; dev_set_i_tb[9] = dev10_set_i_tb; dev_set_i_tb[10] = dev11_set_i_tb; dev_set_i_tb[11] = dev12_set_i_tb;

            dev_ovp_v_tb = new TextBox[12];
            dev_ovp_v_tb[0] = dev1_ovp_v_tb; dev_ovp_v_tb[1] = dev2_ovp_v_tb; dev_ovp_v_tb[2] = dev3_ovp_v_tb; dev_ovp_v_tb[3] = dev4_ovp_v_tb;
            dev_ovp_v_tb[4] = dev5_ovp_v_tb; dev_ovp_v_tb[5] = dev6_ovp_v_tb; dev_ovp_v_tb[6] = dev7_ovp_v_tb; dev_ovp_v_tb[7] = dev8_ovp_v_tb;
            dev_ovp_v_tb[8] = dev9_ovp_v_tb; dev_ovp_v_tb[9] = dev10_ovp_v_tb; dev_ovp_v_tb[10] = dev11_ovp_v_tb; dev_ovp_v_tb[11] = dev12_ovp_v_tb;

            dev_1st_v_tb = new TextBox[12];
            dev_1st_v_tb[0] = dev1_1st_v_tb; dev_1st_v_tb[1] = dev2_1st_v_tb; dev_1st_v_tb[2] = dev3_1st_v_tb; dev_1st_v_tb[3] = dev4_1st_v_tb;
            dev_1st_v_tb[4] = dev5_1st_v_tb; dev_1st_v_tb[5] = dev6_1st_v_tb; dev_1st_v_tb[6] = dev7_1st_v_tb; dev_1st_v_tb[7] = dev8_1st_v_tb;
            dev_1st_v_tb[8] = dev9_1st_v_tb; dev_1st_v_tb[9] = dev10_1st_v_tb; dev_1st_v_tb[10] = dev11_1st_v_tb; dev_1st_v_tb[11] = dev12_1st_v_tb;

            dev_2nd_v_tb = new TextBox[12];
            dev_2nd_v_tb[0] = dev1_2nd_v_tb; dev_2nd_v_tb[1] = dev2_2nd_v_tb; dev_2nd_v_tb[2] = dev3_2nd_v_tb; dev_2nd_v_tb[3] = dev4_2nd_v_tb;
            dev_2nd_v_tb[4] = dev5_2nd_v_tb; dev_2nd_v_tb[5] = dev6_2nd_v_tb; dev_2nd_v_tb[6] = dev7_2nd_v_tb; dev_2nd_v_tb[7] = dev8_2nd_v_tb;
            dev_2nd_v_tb[8] = dev9_2nd_v_tb; dev_2nd_v_tb[9] = dev10_2nd_v_tb; dev_2nd_v_tb[10] = dev11_2nd_v_tb; dev_2nd_v_tb[11] = dev12_2nd_v_tb;

            dev_adc_v_tb = new TextBox[12];
            dev_adc_v_tb[0] = dev1_adc_v_tb; dev_adc_v_tb[1] = dev2_adc_v_tb; dev_adc_v_tb[2] = dev3_adc_v_tb; dev_adc_v_tb[3] = dev4_adc_v_tb;
            dev_adc_v_tb[4] = dev5_adc_v_tb; dev_adc_v_tb[5] = dev6_adc_v_tb; dev_adc_v_tb[6] = dev7_adc_v_tb; dev_adc_v_tb[7] = dev8_adc_v_tb;
            dev_adc_v_tb[8] = dev9_adc_v_tb; dev_adc_v_tb[9] = dev10_adc_v_tb; dev_adc_v_tb[10] = dev11_adc_v_tb; dev_adc_v_tb[11] = dev12_adc_v_tb;

            dev_err_tb = new TextBox[12];
            dev_err_tb[0] = dev1_err_tb; dev_err_tb[1] = dev2_err_tb; dev_err_tb[2] = dev3_err_tb; dev_err_tb[3] = dev4_err_tb; dev_err_tb[4] = dev5_err_tb;
            dev_err_tb[5] = dev6_err_tb; dev_err_tb[6] = dev7_err_tb; dev_err_tb[7] = dev8_err_tb; dev_err_tb[8] = dev9_err_tb; dev_err_tb[9] = dev10_err_tb;
            dev_err_tb[10] = dev11_err_tb; dev_err_tb[11] = dev12_err_tb;


            dev_ieee64_tb = new TextBox[12];
            dev_ieee64_tb[0] = dev1_ieee64_tb; dev_ieee64_tb[1] = dev2_ieee64_tb; dev_ieee64_tb[2] = dev3_ieee64_tb; dev_ieee64_tb[3] = dev4_ieee64_tb;
            dev_ieee64_tb[4] = dev5_ieee64_tb; dev_ieee64_tb[5] = dev6_ieee64_tb; dev_ieee64_tb[6] = dev7_ieee64_tb; dev_ieee64_tb[7] = dev8_ieee64_tb;
            dev_ieee64_tb[8] = dev9_ieee64_tb; dev_ieee64_tb[9] = dev10_ieee64_tb; dev_ieee64_tb[10] = dev11_ieee64_tb; dev_ieee64_tb[11] = dev12_ieee64_tb;

            dev_ieee64_chk_rdbtn = new RadioButton[12];
            dev_ieee64_chk_rdbtn[0] = dev1_ieee64_chk_rdbtn; dev_ieee64_chk_rdbtn[1] = dev2_ieee64_chk_rdbtn;
            dev_ieee64_chk_rdbtn[2] = dev3_ieee64_chk_rdbtn; dev_ieee64_chk_rdbtn[3] = dev4_ieee64_chk_rdbtn;
            dev_ieee64_chk_rdbtn[4] = dev5_ieee64_chk_rdbtn; dev_ieee64_chk_rdbtn[5] = dev6_ieee64_chk_rdbtn;
            dev_ieee64_chk_rdbtn[6] = dev7_ieee64_chk_rdbtn; dev_ieee64_chk_rdbtn[7] = dev8_ieee64_chk_rdbtn;
            dev_ieee64_chk_rdbtn[8] = dev9_ieee64_chk_rdbtn; dev_ieee64_chk_rdbtn[9] = dev10_ieee64_chk_rdbtn;
            dev_ieee64_chk_rdbtn[10] = dev11_ieee64_chk_rdbtn; dev_ieee64_chk_rdbtn[11] = dev12_ieee64_chk_rdbtn;

            dev_ieee64_rf_chk_lb = new Label[12];
            /*dev_ieee64_rf_chk_lb[0] = dev1_ieee64_rf_chk_lb; dev_ieee64_rf_chk_lb[1] = dev2_ieee64_rf_chk_lb; dev_ieee64_rf_chk_lb[2] = dev3_ieee64_rf_chk_lb;
            dev_ieee64_rf_chk_lb[3] = dev4_ieee64_rf_chk_lb; dev_ieee64_rf_chk_lb[4] = dev5_ieee64_rf_chk_lb; dev_ieee64_rf_chk_lb[5] = dev6_ieee64_rf_chk_lb;
            dev_ieee64_rf_chk_lb[6] = dev7_ieee64_rf_chk_lb; dev_ieee64_rf_chk_lb[7] = dev8_ieee64_rf_chk_lb; dev_ieee64_rf_chk_lb[8] = dev9_ieee64_rf_chk_lb;
            dev_ieee64_rf_chk_lb[9] = dev10_ieee64_rf_chk_lb; dev_ieee64_rf_chk_lb[10] = dev11_ieee64_rf_chk_lb; dev_ieee64_rf_chk_lb[11] = dev12_ieee64_rf_chk_lb;
*/
            dev_ieee64_low_chk_tb = new TextBox[12];
            /*dev_ieee64_low_chk_tb[0] = dev1_ieee64_low_chk_tb; dev_ieee64_low_chk_tb[1] = dev2_ieee64_low_chk_tb; dev_ieee64_low_chk_tb[2] = dev3_ieee64_low_chk_tb;
            dev_ieee64_low_chk_tb[3] = dev4_ieee64_low_chk_tb; dev_ieee64_low_chk_tb[4] = dev5_ieee64_low_chk_tb; dev_ieee64_low_chk_tb[5] = dev6_ieee64_low_chk_tb;
            dev_ieee64_low_chk_tb[6] = dev7_ieee64_low_chk_tb; dev_ieee64_low_chk_tb[7] = dev8_ieee64_low_chk_tb; dev_ieee64_low_chk_tb[8] = dev9_ieee64_low_chk_tb;
            dev_ieee64_low_chk_tb[9] = dev10_ieee64_low_chk_tb; dev_ieee64_low_chk_tb[10] = dev11_ieee64_low_chk_tb; dev_ieee64_low_chk_tb[11] = dev12_ieee64_low_chk_tb;
            */
            dev_cal_chk_lb = new Label[12];
            dev_v_rd_tb = new TextBox[12];

            /*dev_cal_chk_lb[0] = dev1_cal_chk_lb; dev_cal_chk_lb[1] = dev2_cal_chk_lb; dev_cal_chk_lb[2] = dev3_cal_chk_lb; dev_cal_chk_lb[3] = dev4_cal_chk_lb;
            dev_cal_chk_lb[4] = dev5_cal_chk_lb; dev_cal_chk_lb[5] = dev6_cal_chk_lb; dev_cal_chk_lb[6] = dev7_cal_chk_lb; dev_cal_chk_lb[7] = dev8_cal_chk_lb;
            dev_cal_chk_lb[8] = dev9_cal_chk_lb; dev_cal_chk_lb[9] = dev10_cal_chk_lb; dev_cal_chk_lb[10] = dev11_cal_chk_lb; dev_cal_chk_lb[11] = dev12_cal_chk_lb;

            dev_v_rd_tb[0] = dev1_v_rd_tb; dev_v_rd_tb[1] = dev2_v_rd_tb; dev_v_rd_tb[2] = dev3_v_rd_tb; dev_v_rd_tb[3] = dev4_v_rd_tb;
            dev_v_rd_tb[4] = dev5_v_rd_tb; dev_v_rd_tb[5] = dev6_v_rd_tb; dev_v_rd_tb[6] = dev7_v_rd_tb; dev_v_rd_tb[7] = dev8_v_rd_tb;
            dev_v_rd_tb[8] = dev9_v_rd_tb; dev_v_rd_tb[9] = dev10_v_rd_tb; dev_v_rd_tb[10] = dev11_v_rd_tb; dev_v_rd_tb[11] = dev12_v_rd_tb;
            */
            dev_sd_id_chk_lb = new Label[12];
            dev_s_id_tb = new TextBox[12];

            /*
            dev_sd_id_chk_lb[0] = dev1_sd_id_chk_lb; dev_sd_id_chk_lb[1] = dev2_sd_id_chk_lb; dev_sd_id_chk_lb[2] = dev3_sd_id_chk_lb;
            dev_sd_id_chk_lb[3] = dev4_sd_id_chk_lb; dev_sd_id_chk_lb[4] = dev5_sd_id_chk_lb; dev_sd_id_chk_lb[5] = dev6_sd_id_chk_lb;
            dev_sd_id_chk_lb[6] = dev7_sd_id_chk_lb; dev_sd_id_chk_lb[7] = dev8_sd_id_chk_lb; dev_sd_id_chk_lb[8] = dev9_sd_id_chk_lb;
            dev_sd_id_chk_lb[9] = dev10_sd_id_chk_lb; dev_sd_id_chk_lb[10] = dev11_sd_id_chk_lb; dev_sd_id_chk_lb[11] = dev12_sd_id_chk_lb;

            dev_s_id_tb[0] = dev1_s_id_tb; dev_s_id_tb[1] = dev2_s_id_tb; dev_s_id_tb[2] = dev3_s_id_tb; dev_s_id_tb[3] = dev4_s_id_tb;
            dev_s_id_tb[4] = dev5_s_id_tb; dev_s_id_tb[5] = dev6_s_id_tb; dev_s_id_tb[6] = dev7_s_id_tb; dev_s_id_tb[7] = dev8_s_id_tb;
            dev_s_id_tb[8] = dev9_s_id_tb; dev_s_id_tb[9] = dev10_s_id_tb; dev_s_id_tb[10] = dev11_s_id_tb; dev_s_id_tb[11] = dev12_s_id_tb;
            */

            dev_d_id_tb = new TextBox[12];
            /*dev_d_id_tb[0] = dev1_d_id_tb; dev_d_id_tb[1] = dev2_d_id_tb; dev_d_id_tb[2] = dev3_d_id_tb; dev_d_id_tb[3] = dev4_d_id_tb;
            dev_d_id_tb[4] = dev5_d_id_tb; dev_d_id_tb[5] = dev6_d_id_tb; dev_d_id_tb[6] = dev7_d_id_tb; dev_d_id_tb[7] = dev8_d_id_tb;
            dev_d_id_tb[8] = dev9_d_id_tb; dev_d_id_tb[9] = dev10_d_id_tb; dev_d_id_tb[10] = dev11_d_id_tb; dev_d_id_tb[11] = dev12_d_id_tb;
            */

            dev_mesasure_str_buf = new string[12, 5];

            dev_set_i_offset = new double[12];
            dev_set_i_offset[0] = 3.070;
            dev_set_i_offset[1] = 3.142;
            dev_set_i_offset[2] = 3.180;
            dev_set_i_offset[3] = 3.106;
            dev_set_i_offset[4] = 3.195;
            dev_set_i_offset[5] = 3.129;
            dev_set_i_offset[6] = 3.239;
            dev_set_i_offset[7] = 3.236;
            dev_set_i_offset[8] = 3.236;
            dev_set_i_offset[9] = 3.190;
            dev_set_i_offset[10] = 3.251;
            dev_set_i_offset[11] = 3.166;

            dev_set_i_scale = new double[12];

            dev_set_i_scale[0] = 0.00368;
            dev_set_i_scale[1] = 0.00346;
            dev_set_i_scale[2] = 0.00372;
            dev_set_i_scale[3] = 0.00380;
            dev_set_i_scale[4] = 0.00357;
            dev_set_i_scale[5] = 0.00353;
            dev_set_i_scale[6] = 0.00353;
            dev_set_i_scale[7] = 0.00341;
            dev_set_i_scale[8] = 0.00341;
            dev_set_i_scale[9] = 0.00368;
            dev_set_i_scale[10] = 0.00332;
            dev_set_i_scale[11] = 0.00313;


            for (int i = 0; i < 12; i++)
            {
                cb[i].Checked = false;
                cb[i].CheckedChanged += cb_CheckedChanged;

                lb[i].Text = "Wait..";

                dev_ieee64_chk_rdbtn[i].CheckedChanged += rb_CheckedChanged;

                dev_ieee64_tb[i].ReadOnly = true;

                pb[i].Minimum = 0;
                pb[i].Maximum = 100;
                pb[i].Step = 5;
                pb[i].Value = 0;
            }

            dev_2V_mode_btn.BackColor = SystemColors.Control;
            dev_6V_mode_btn.BackColor = SystemColors.Control;
            dev_12V_mode_btn.BackColor = SystemColors.Control;

            dev_auto_mode_btn.Enabled = false;
            //dev_id_mode_btn.BackColor = Color.Gray;
            fw_down_mode_btn.Enabled = false;
            board_check_btn.Enabled = false;
            //            rf_chk_v_cal_mode_btn.BackColor = Color.Gray;

            fw_download_btn.Enabled = false;
            //           dev_ieee64_rf_chk_btn.Enabled = false;
            //         dev_v_cal_btn.Enabled = false;
            //       dev_v_read_btn.Enabled = false;
            //dev_id_set_btn.Enabled = false;
        }

        private int config_file_init(string filename)
        {
            int err = 0;

            if (filename != "")
            {
                string[] str = filename.Split('\\');
                strConfigname = filename;
                config_file_label.Text = "Config File Name : \r\n" + str[str.Length - 1];

                StringBuilder temp = new StringBuilder(255);
                for (int i = 0; i < 12; i++)
                {
                    GetPrivateProfileString("SECTION", "dev" + i.ToString(), "", temp, 255, @filename);
                    cbb[i].SelectedItem = temp.ToString();
                }

                GetPrivateProfileString("SECTION", "psw3036", "", temp, 255, @filename);
                psw3036_port_cbb.SelectedItem = temp.ToString();

                GetPrivateProfileString("SECTION", "dmm", "", temp, 255, @filename);
                dmm_port_cbb.SelectedItem = temp.ToString();

                GetPrivateProfileString("SECTION", "devchecker", "", temp, 255, @filename);
                devchk_cbb.SelectedItem = temp.ToString();

                err = 1;
            }
            else
            {
                err = -1;
            }

            return err;
        }

        void daq_adc_init(int mode)
        {
            int j = 0;
            for (int i = 0; i < 6; i++)
            {
                if (i == 3) j++;
                instantAiCtrl1.Channels[j].ValueRange = ValueRange.V_0To5;//8
                instantAiCtrl2.Channels[j].ValueRange = ValueRange.V_0To5;//8
                j++; // j 1
                if (mode == 1)
                {
                    instantAiCtrl1.Channels[j].ValueRange = ValueRange.V_0To5;
                    instantAiCtrl2.Channels[j].ValueRange = ValueRange.V_0To5;
                }
                else if (mode == 2 || mode == 3)
                {
                    instantAiCtrl1.Channels[j].ValueRange = ValueRange.V_0To10;//7
                    instantAiCtrl2.Channels[j].ValueRange = ValueRange.V_0To10;//7
                }
                j++; // j 2
                instantAiCtrl1.Channels[j].ValueRange = ValueRange.V_0To10;
                instantAiCtrl2.Channels[j].ValueRange = ValueRange.V_0To10;
                j++;
                instantAiCtrl1.Channels[j].ValueRange = ValueRange.V_0To5;
                instantAiCtrl2.Channels[j].ValueRange = ValueRange.V_0To5;
                j++;
                instantAiCtrl1.Channels[j].ValueRange = ValueRange.V_0To5;
                instantAiCtrl2.Channels[j].ValueRange = ValueRange.V_0To5;
                j++;
            }
        }

        private void op_start_btn_Click(object sender, EventArgs e)//작업 시작 버튼
        {
            dev_chk_cnt = 0;

            
            for (int i = 0; i < 12; i++)
            {
                if (dev_ieee64_tb[i].Text == "주소값 대기")
                {
                    dev_chk_cnt = dev_chk_cnt + 1;
                }
                dev_err_tb[i].Text = ""; // err판정 초기화
                dev_ovp_v_tb[i].BackColor = Color.White;
                dev_1st_v_tb[i].BackColor = Color.White;
                dev_2nd_v_tb[i].BackColor = Color.White;
                dev_adc_v_tb[i].BackColor = Color.White;
            }

            if ((v_mode == 0) || (op_mode == 0) || (worker_tb.Text == "") || (dev_chk_cnt != 0))
            {
                MessageBox.Show("작업 설정을 확인 하세요");
            }
            else
            {
                op_start_btn.BackColor = Color.SkyBlue;
                op_stop_btn.BackColor = SystemColors.Control;

                op_start_time_tb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                op_end_time_tb.Text = "대기 중.";

                dev_chk_cnt = 0;

                for (int i = 0; i < 12; i++)
                {
                    if (cb[i].Checked == true)
                    {
                        dev_chk_cnt++;
                    }
                }

                if (v_mode == 1)
                {
                    psu_target_v_textBox.Text = "2.0";
                    psu_target_i_textBox.Text = "10.0";
                }
                else if (v_mode == 2)
                {
                    psu_target_v_textBox.Text = "6.0";
                    psu_target_i_textBox.Text = "5.0";
                }
                else if (v_mode == 3)
                {
                    psu_target_v_textBox.Text = "12.0";
                    psu_target_i_textBox.Text = "5.0";
                }

                psu_set_btn.PerformClick();

                Delay(500);
                zig_down_btn.PerformClick();
                Delay(2000);
                //dev_pwr_all_on_btn.PerformClick();
                psu_on_set();

                op_step = 1;
                op_step_retry_cnt = 0;
                op_status = 1;

                main_timer_cnt = 0;
                main_timer.Start();
            }
        }

        private void op_stop_btn_Click(object sender, EventArgs e)
        {
            
            op_start_btn.BackColor = SystemColors.Control;
            op_stop_btn.BackColor = Color.SkyBlue;

            Delay(500);
            zig_up_btn.PerformClick();
            Delay(2000);
            //dev_pwr_all_off_btn.PerformClick();
            psu_off_set();

            op_step = 0;
            op_status = 0;
            adc_timer_cnt = 0;
            adc_timer.Stop();
            main_timer_cnt = 0;
            main_timer.Stop();
        }

        private void dev_ieee64_set_btn_Click(object sender, EventArgs e)
        {
            string temp_ieee64_str = dev_ieee64_set_tb.Text.Replace(" ", "");
            ulong temp_ieee64 = UInt64.Parse(temp_ieee64_str, System.Globalization.NumberStyles.HexNumber);

            for (int i = 0; i < 12; i++)
            {
                temp_ieee64_str = temp_ieee64.ToString("X16");

                dev_ieee64_tb[i].Text = "";
                for (int j = 0; j < 8; j++)
                {
                    dev_ieee64_tb[i].Text += temp_ieee64_str.Substring((0 + j) * 2, 2) + " ";
                }

                temp_ieee64 = temp_ieee64 + 1;
            }


        }

        private void dev_id_nb_set_btn_Click(object sender, EventArgs e)
        {
            int temp_s_id = Convert.ToInt32(dev_s_id_tb[0].Text);
            int temp_d_id = Convert.ToInt32(dev_d_id_tb[0].Text);

            for (int i = 0; i < 12; i++)
            {
                dev_s_id_tb[i].Text = temp_s_id.ToString();
                dev_d_id_tb[i].Text = temp_d_id.ToString();
                temp_d_id = temp_d_id + 1;
            }
        }
        private void db_btn_Click(object sender, EventArgs e)
        {
            if (db_check == false)
            {
                db_btn.BackColor = Color.SkyBlue;
                db_check = true;
            }
            else
            {
                db_btn.BackColor = SystemColors.Control;
                db_check = false;

            }

        }
        private void board_check_btn_Click(object sender, EventArgs e)
        {
            op_mode = 5;

            dev_auto_mode_btn.BackColor = Color.Gray;
            //dev_id_mode_btn.BackColor = Color.Gray;

            fw_down_mode_btn.BackColor = Color.Gray;
            board_check_btn.BackColor = Color.SkyBlue;

            //rf_chk_v_cal_mode_btn.BackColor = Color.Gray;

            fw_download_btn.Enabled = true;
            db_btn.Enabled = true;

        }

        private void export_excel()
        {

            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            try
            {
                excelApp = new Excel.Application();

                wb = excelApp.Workbooks.Open(@"D:\test\test.xlsx");
                ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;
                //첫번째 워크시트 선택

                Excel.Range rng = ws.Range["H40", "H40"];

                object[,] data = new object[40, 40];

                for (int r = 0; r < 40; r++)
                {
                    for (int c = 0; c < 40; c++)
                    {
                        // data[r, c] = Data[r, c];
                    }
                }

                rng.Value = data;
                wb.Save();
                wb.Close();
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excelApp);
            }
        }
        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }
        private void bd_chk()
        {
            //보드체크 판정

            double bd_chk_err_value_ovp_db = Convert.ToDouble(bd_chk_err_value_ovp.Text);
            double bd_chk_err_value_1st_db = Convert.ToDouble(bd_chk_err_value_1st.Text);
            double bd_chk_err_value_2nd_db = Convert.ToDouble(bd_chk_err_value_2nd.Text);
            double bd_chk_err_value_adc_db = Convert.ToDouble(bd_chk_err_value_adc.Text);

            double bd_chk_avr_ovp_db = Convert.ToDouble(bd_chk_avr_ovp.Text);
            double bd_chk_avr_1st_db = Convert.ToDouble(bd_chk_avr_1st.Text);
            double bd_chk_avr_2nd_db = Convert.ToDouble(bd_chk_avr_2nd.Text);
            double bd_chk_avr_adc_db = Convert.ToDouble(bd_chk_avr_adc.Text);

            double bd_chk_dvdt_ovp_db = Convert.ToDouble(bd_chk_dvdt_ovp.Text);
            double bd_chk_dvdt_1st_db = Convert.ToDouble(bd_chk_dvdt_1st.Text);
            double bd_chk_dvdt_2nd_db = Convert.ToDouble(bd_chk_dvdt_2nd.Text);
            double bd_chk_dvdt_adc_db = Convert.ToDouble(bd_chk_dvdt_adc.Text);

            double bd_chk_max_ovp = 0;
            double bd_chk_max_1st = 0;
            double bd_chk_max_2nd = 0;
            double bd_chk_max_adc = 0;

            for (int x = 0; x < 12; x++)
            {
                err_board_num[x] = 0;
            }

            for (int i = 0; i < dev_chk_cnt; i++)
            {
                dev_ovp_v_tb[i].BackColor = Color.LimeGreen;
                dev_1st_v_tb[i].BackColor = Color.LimeGreen;
                dev_2nd_v_tb[i].BackColor = Color.LimeGreen;
                dev_adc_v_tb[i].BackColor = Color.LimeGreen;

                dev_err_tb[i].Text = "Pass";
                
                bd_err_dvdt_ovp_cnt = 0;
                bd_err_dvdt_1st_cnt = 0;
                bd_err_dvdt_2nd_cnt = 0;
                bd_err_dvdt_adc_cnt = 0;

                for (int j = 0; j < 19; j++)//최대 변화량값만 저장하기
                {

                    if ((Math.Abs(bd_chk_value[i, j, 1] - bd_chk_value[i, j+1, 1])) > bd_chk_dvdt_ovp_db)
                    {
                        //if (bd_chk_max_ovp < Math.Abs(bd_chk_value[i, j, 1])) bd_chk_max_ovp = Math.Abs(bd_chk_value[i, j, 1]);

                        bd_err_dvdt_ovp_cnt++;

                        if (bd_err_dvdt_ovp_cnt > 2)
                        {
                            dev_ovp_v_tb[i].BackColor = Color.OrangeRed;
                            dev_err_tb[i].Text = "Fail";
                            err_board_num[i] = 1; //ovp err

                            //if (bd_err_dvdt_cnt > 0) bd_err_dvdt_flag[y] = 1
                        }
                    }
                    if ((Math.Abs(bd_chk_value[i, j, 2] - bd_chk_value[i, j + 1, 2])) > bd_chk_dvdt_1st_db)
                    {
                        //   if (bd_chk_max_1st < Math.Abs(bd_chk_value[i, j, 2])) bd_chk_max_1st = Math.Abs(bd_chk_value[i, j, 2]);

                        bd_err_dvdt_1st_cnt++;

                        if (bd_err_dvdt_1st_cnt > 2)
                        {
                            dev_1st_v_tb[i].BackColor = Color.OrangeRed;
                            dev_err_tb[i].Text = "Fail";
                            err_board_num[i] += 3; //1st err
                        }
                    }

                    if ((Math.Abs(bd_chk_value[i, j, 3] - bd_chk_value[i, j+1, 3])) > bd_chk_dvdt_2nd_db)
                    {
                       // if (bd_chk_max_2nd < Math.Abs(bd_chk_value[i, j, 3])) bd_chk_max_2nd = Math.Abs(bd_chk_value[i, j, 3]);

                        bd_err_dvdt_2nd_cnt++;

                        if (bd_err_dvdt_2nd_cnt > 2)
                        {
                            err_board_num[i] += 5; //2nd err
                            dev_2nd_v_tb[i].BackColor = Color.OrangeRed;
                            dev_err_tb[i].Text = "Fail";
                        }
                    }

                    if ((Math.Abs(bd_chk_value[i, j, 4] - bd_chk_value[i, j+1, 4])) > bd_chk_dvdt_adc_db)
                    {
                       // if (bd_chk_max_adc < Math.Abs(bd_chk_value[i, j, 4])) bd_chk_max_adc = Math.Abs(bd_chk_value[i, j, 4]);
                        bd_err_dvdt_adc_cnt++;

                        if (bd_err_dvdt_adc_cnt > 2)
                        {
                            err_board_num[i] += 7; //adc err
                            dev_adc_v_tb[i].BackColor = Color.OrangeRed;
                            dev_err_tb[i].Text = "Fail";
                        }
                    }
                }
            }
            //평균값 비교

            for (int x = 0; x < dev_chk_cnt; x++)
            {
                bd_err_avr_ovp_cnt = 0;
                bd_err_avr_1st_cnt = 0;
                bd_err_avr_2nd_cnt = 0;
                bd_err_avr_adc_cnt = 0;

                for (int y = 0; y < 20; y++)
                {
                    if (Math.Abs(bd_chk_value[x, y, 1] - bd_chk_avr_ovp_db) > bd_chk_err_value_ovp_db)
                    {
                        bd_err_avr_ovp_cnt++;

                        if (bd_err_avr_ovp_cnt > 2)
                        {
                            err_board_num[x] += 1; //ovp err
                            dev_ovp_v_tb[x].BackColor = Color.OrangeRed;
                            dev_err_tb[x].Text = "Fail";

                        }
                    }
                    if (Math.Abs(bd_chk_value[x, y, 2] - bd_chk_avr_1st_db) > bd_chk_err_value_1st_db)
                    {
                        bd_err_avr_1st_cnt++;

                        if(bd_err_avr_1st_cnt > 2)
                        {
                            err_board_num[x] += 3; //1st err
                            dev_1st_v_tb[x].BackColor = Color.OrangeRed;
                            dev_err_tb[x].Text = "Fail";
                        }

                    }
                    if (Math.Abs(bd_chk_value[x, y, 3] - bd_chk_avr_2nd_db) > bd_chk_err_value_2nd_db)
                    {
                        bd_err_avr_2nd_cnt++;


                        if (bd_err_avr_2nd_cnt > 2)
                        {
                            err_board_num[x] += 5; //2nd err
                            dev_2nd_v_tb[x].BackColor = Color.OrangeRed;
                            dev_err_tb[x].Text = "Fail";
                        }
                    }
                    if (Math.Abs(bd_chk_value[x, y, 4] - bd_chk_avr_adc_db) > bd_chk_err_value_adc_db)
                    {
                        bd_err_avr_adc_cnt++;

                        if (bd_err_avr_adc_cnt > 2)
                        {
                            err_board_num[x] += 7; //adc err
                            dev_adc_v_tb[x].BackColor = Color.OrangeRed;
                            dev_err_tb[x].Text = "Fail";
                        }
                    }                
                }
            }            
        }
        private void bd_avr_cal()
        {
            double bd_chk_sum_i = 0;
            double bd_chk_sum_ovp = 0;
            double bd_chk_sum_1st = 0;
            double bd_chk_sum_2nd = 0;
            double bd_chk_sum_adc = 0;

            for (int num = 0; num < 12; num++)
            {
                bd_chk_sum_i = 0;
                bd_chk_sum_ovp = 0;
                bd_chk_sum_1st = 0;
                bd_chk_sum_2nd = 0;
                bd_chk_sum_adc = 0;

                if (num < dev_chk_cnt)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        bd_chk_sum_i += bd_chk_value[num, i, 0];
                        bd_chk_sum_ovp += bd_chk_value[num, i, 1];
                        bd_chk_sum_1st += bd_chk_value[num, i, 2];
                        bd_chk_sum_2nd += bd_chk_value[num, i, 3];
                        bd_chk_sum_adc += bd_chk_value[num, i, 4];
                    }

                    dev_set_i_tb[num].Text = Math.Round(bd_chk_sum_i / 20,3).ToString();
                    dev_ovp_v_tb[num].Text = Math.Round(bd_chk_sum_ovp / 20, 3).ToString();
                    dev_1st_v_tb[num].Text = Math.Round(bd_chk_sum_1st / 20, 3).ToString();
                    dev_2nd_v_tb[num].Text = Math.Round(bd_chk_sum_2nd / 20, 3).ToString();
                    dev_adc_v_tb[num].Text = Math.Round(bd_chk_sum_adc / 20, 3).ToString();
                }
                else
                {
                    dev_set_i_tb[num].Text = "0";
                    dev_ovp_v_tb[num].Text = "0";
                    dev_1st_v_tb[num].Text = "0";
                    dev_2nd_v_tb[num].Text = "0";
                    dev_adc_v_tb[num].Text = "0";
                    dev_err_tb[num].Text = "Fail";
                }

            }
        }
    }
}
    
     
