using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BMSMonitor.Utils;
using IniManager;

using MySql.Data.MySqlClient;



namespace BMSMonitor
{
	public partial class MainFrm : Form
	{
		public string optionIniPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\MAROOON\BMSManufacturer";
		public static string optionIniPathName = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\MAROOON\BMSManufacturer\setup.ini";
		public static string tagBookIniPathName = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\MAROOON\BMSManufacturer\tagBook.ini";
		public static string SetupDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\MAROOON\BMSManufacturer\setup\";
		public static string errorLogDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\MAROOON\BMSManufacturer\errorLog\";
		public static string captureDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\MAROOON\BMSManufacturer\capture\";

		public static string strSrvName;
		public static string strSrvID;
		public static string strSrvPass;


		public static MySqlConnection con = null;
		public static MySqlCommand cmd = null;

		public static bool bServerState = false;

		//public Server m_server = null;

		public MainFrm()
		{
			InitializeComponent();

			sidePanel.Top = button1.Top;
			sidePanel.Height = button1.Height;

			DirectoryInfo di = new DirectoryInfo(optionIniPath);
			if (!di.Exists)
			{
				di.Create();
			}

			iniClass ini = new iniClass();
			strSrvName = ini.GetIniValue("Server", "name", MainFrm.optionIniPathName);
			if (strSrvName == "")
			{
				strSrvName = "maroomcs.myqnapcloud.com:3306";
			}
			strSrvID = ini.GetIniValue("Server", "id", MainFrm.optionIniPathName);
			strSrvPass = ini.GetIniValue("Server", "pass", MainFrm.optionIniPathName);
			if (strSrvPass != "")
			{
				SimpleEncrypt en = new SimpleEncrypt();
				strSrvPass = en.Decrypt(strSrvPass);
				strSrvPass = strSrvPass.Trim('\0');

			}
			//tbServerName.Text = strServerName;
			//tbServerId.Text = strServerId;
			mainControl1.BringToFront();			
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			sidePanel.Top = button2.Top;
			sidePanel.Height = button2.Height;
			inquiryControl1.BringToFront();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			sidePanel.Top = button1.Top;
			sidePanel.Height = button1.Height;
			mainControl1.BringToFront();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			sidePanel.Top = button3.Top;
			sidePanel.Height = button3.Height;
			asControl1.BringToFront();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			sidePanel.Top = btnSetup.Top;
			sidePanel.Height = btnSetup.Height;
			setupControl1.BringToFront();
		}

		private void btnRelease_Click(object sender, EventArgs e)
		{
			sidePanel.Top = btnRelease.Top;
			sidePanel.Height = btnRelease.Height;
			releaseControl2.BringToFront();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void MainFrm_Shown(object sender, EventArgs e)
		{

			//System.Threading.Thread.Sleep(2000);

			string strconn = "Server=" + strSrvName + ";Database=bms_manufacturer;Uid=" + strSrvID + ";Pwd=" + strSrvPass + ";CharSet=utf8;";
			con = new MySqlConnection(strconn);

			//con.Open();
			//if (con.State == ConnectionState.Open)
			{
				bServerState = true;
				using (waitFrm frm = new waitFrm(inquiryControl1.GetBuyer))
				{
					frm.ShowDialog(this);
				}

				if (inquiryControl1.cbbBuyer.Items.Count > 0)
				{
					inquiryControl1.cbbBuyer.SelectedIndex = 0;

					for (int i = 1; i < inquiryControl1.cbbBuyer.Items.Count; i++)
					{
						releaseControl2.cbBuyer.Items.Add(inquiryControl1.cbbBuyer.Items[i].ToString());
					}
					releaseControl2.cbBuyer.SelectedIndex = 0;
				}
			}


			mainControl1.GetInfo();
			//else
			//{
			//	bServerState = false;
			//	MessageBox.Show("서버에 연결할 수 없습니다. 설정을 확인하세요.");
			//}
		}


	}
}
