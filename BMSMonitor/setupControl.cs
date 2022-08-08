using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IniManager;
using BMSMonitor.Utils;

namespace BMSMonitor
{
	//string strServerName;
	public partial class setupControl : UserControl
	{
		iniClass ini;
		string strServerName;
		string strServerId;
		string strServerPass;

		public setupControl()
		{
			InitializeComponent();

			tbServerPass.Text = "";
			tbServerPass.PasswordChar = '*';
			tbServerPass.MaxLength = 14;


			ini = new iniClass();
			strServerName = ini.GetIniValue("Server", "name", MainFrm.optionIniPathName);
			if (strServerName == "")
			{
				strServerName = "maroomcs.myqnapcloud.com:3306";
			}
			strServerId = ini.GetIniValue("Server", "id", MainFrm.optionIniPathName);
			strServerPass = ini.GetIniValue("Server", "pass", MainFrm.optionIniPathName);
			if (strServerPass != "")
			{
				SimpleEncrypt en = new SimpleEncrypt();
				tbServerPass.Text = en.Decrypt(strServerPass);
				tbServerPass.Text = tbServerPass.Text.Trim('\0');
			}

			tbServerName.Text = strServerName;
			tbServerId.Text = strServerId;


			MainFrm.strSrvName = tbServerName.Text;
			MainFrm.strSrvID = tbServerId.Text;
			MainFrm.strSrvPass = tbServerPass.Text;
		}

		private void setupControl_Load(object sender, EventArgs e)
		{
			ini = new iniClass();
			strServerName = ini.GetIniValue("Server", "name", MainFrm.optionIniPathName);
			if (strServerName == "")
			{
				strServerName = "maroomcs.myqnapcloud.com:3306";
			}
			strServerId = ini.GetIniValue("Server", "id", MainFrm.optionIniPathName);
			strServerPass = ini.GetIniValue("Server", "pass", MainFrm.optionIniPathName);
			if (strServerPass != "")
			{
				SimpleEncrypt en = new SimpleEncrypt();
				tbServerPass.Text = en.Decrypt(strServerPass);
				tbServerPass.Text = tbServerPass.Text.Trim('\0');

			}
			tbServerName.Text = strServerName;
			tbServerId.Text = strServerId;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			ini = new iniClass();
			ini.SetIniValue("Server", "name", tbServerName.Text, MainFrm.optionIniPathName);
			ini.SetIniValue("Server", "id", tbServerId.Text, MainFrm.optionIniPathName);

			SimpleEncrypt en = new SimpleEncrypt();
			ini.SetIniValue("Server", "pass", en.Encrypt(tbServerPass.Text), MainFrm.optionIniPathName);

			MessageBox.Show("저장되었습니다.");

			MainFrm.strSrvName = tbServerName.Text;
			MainFrm.strSrvID = tbServerId.Text;
			MainFrm.strSrvPass = tbServerPass.Text;
		}
	}
}
