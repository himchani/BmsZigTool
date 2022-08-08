using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScannerLib;

namespace BMSMonitor
{
	public partial class barcodeFrm : Form
	{
		int numofbms;
		int curCnt;
		bool bInit = false;

		//string strPcbBarcode, strCaseBarcode;
		int stat;

		public delegate void SendMsgDele(Object obj1, Object obj2);
		public event SendMsgDele SendMsg;

		DS8178Lib m_ds8718;

		public barcodeFrm(int cnt)
		{
			InitializeComponent();

			m_ds8718 = new DS8178Lib();

			try
			{
				if (m_ds8718.Init(GetBarcode) == false)
				{
					MessageBox.Show("스캐너 초기화에 실패하였습니다");
				}
				else
				{
					m_ds8718.Scan();
					bInit = true;
				}
				stat = 0;
				curCnt = 1;
				numofbms = cnt;

				lbStatus.Text = "현재 " + curCnt + " / " + numofbms + " 스캔 중";


			}
			catch (Exception ex)
			{
				MessageBox.Show("스캐너 연결을 확인해 주세요. " + ex.Message);				
			}

			//SendMsg(arrTmp);//
		}

		void GetBarcode(string[] ret)
		{
			if (curCnt > numofbms) return;


			if (stat == 0)
			{
				stat = 1;
				if (tbPcb.InvokeRequired)
				{
					tbPcb.Invoke(new MethodInvoker(delegate
					{
						tbPcb.Clear();
						tbPcb.Text = ret[1];
					}));
				}

			}
			else if (stat == 1)
			{

				if (tbCase.InvokeRequired)
				{
					tbCase.Invoke(new MethodInvoker(delegate
					{
						tbCase.Clear();
						tbCase.Text = ret[1];
					}));
				}

				stat = 0;

				string[] buf = new string[2];
				buf[0] = tbPcb.Text;
				buf[1] = tbCase.Text;


				if (String.Compare(buf[0], buf[1]) == 0)
				{
					if (tbPcb.InvokeRequired)
					{
						tbPcb.Invoke(new MethodInvoker(delegate {tbPcb.Clear();}));
					}
					if (tbCase.InvokeRequired)
					{
						tbCase.Invoke(new MethodInvoker(delegate { tbCase.Clear(); }));
					}

					MessageBox.Show("바코드가 동일합니다. 다시 스캔해주세요.");
					stat = 0;
					return;
				}

				SendMsg(curCnt, buf);//
				if (curCnt == numofbms) {
					//MessageBox.Show("바코드스캔이 완료되었습니다.");
					if (lbStatus.InvokeRequired)
					{
						lbStatus.Invoke(new MethodInvoker(delegate
						{
							//lbStatus
							lbStatus.Text = "현재 " + curCnt + " / " + numofbms + " 스캔 이 완료되었습니다.";
						}));
					}
					curCnt++;

				}
				else {
					curCnt++;

					if (lbStatus.InvokeRequired)
					{
						lbStatus.Invoke(new MethodInvoker(delegate
						{
							//lbStatus
							lbStatus.Text = "현재 " + curCnt + " / " + numofbms + " 스캔 중";
						}));
					}

					//lbStatus.Text = "현재 " + curCnt + " / " + numofbms + " 스캔 중";
				}
			}
		}		

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (bInit == false) return;

			if (curCnt > 1)
			{
				curCnt--;
				lbStatus.Text = "현재 " + curCnt + " / " + numofbms + " 스캔 중";
				tbCase.Clear();
				tbPcb.Clear();

				SendMsg(-1, null);
			}
		}
	}
}
