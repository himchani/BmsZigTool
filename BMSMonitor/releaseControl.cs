using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using ScannerLib;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace BMSMonitor
{
	public partial class releaseControl : UserControl
	{
		//DS8178Lib m_ds8718 = new DS8178Lib();
		public releaseControl()
		{
			InitializeComponent();


			dgv.RowHeadersVisible = false;
			//if (m_ds8718.Init(Barcode) == false)
			//{
			//	MessageBox.Show("스캐너 초기화에 실패하였습니다");
			//}

			//GetBuyer();
		}

		private void btnQuery_Click(object sender, EventArgs e)
		{
			
#if false
			if (cbType.SelectedIndex == -1)
			{
				MessageBox.Show("BMS 타입을 선태해 주세요.");
				return;
			}
#endif

			if (dgv.Rows.Count == 0)
			{
				MessageBox.Show("출고할 BMS 의 QR코드를 스캔 후 적용하세요.");
				return;
			}


			int type = 0;	//이미 생산단계에서 type은 정해져 있음.
			int buyer = cbBuyer.SelectedIndex + 1;
			int nums = dgv.Rows.Count;
			int setID = Int32.Parse(dgv.Rows[0].Cells[1].Value.ToString());
			DateTime dt1 = dtPick.Value;

			int cnt = 1;

			try
			{
				MainFrm.con.Open();
				string sql = "INSERT INTO bms_manufacturer.release (outDateTime,numOfDevices,buyer,devType,setID,";
				string value;

				value = "('" + dt1.ToString("yyyy-MM-dd 00:00:00") + "'," + nums + "," + buyer + "," + type + "," + setID + ",";

				foreach (DataGridViewRow row in dgv.Rows)
				{
					sql += "devSerial" + cnt + ",";
					value += row.Cells[5].Value + ",";
					cnt++;
				}
			
				sql = sql.Substring(0, (sql.Length - 1));
				sql += ") VALUES ";
				value = value.Substring(0, (value.Length - 1));
				value += ")";
				sql += value;

				MySqlCommand cmd = new MySqlCommand(sql, MainFrm.con);
				cmd.ExecuteNonQuery();

				foreach (DataGridViewRow row in dgv.Rows)
				{
					string sql2 = "UPDATE bms_manufacturer.production set outBarcode='" + row.Cells[4].Value.ToString() + "'," +
						"deliveryDateTime='" +  dt1.ToString("yyyy-MM-dd 00:00:00") + "' where serial=" + row.Cells[5].Value.ToString();
					MySqlCommand cmd2 = new MySqlCommand(sql2, MainFrm.con);					
					cmd2.ExecuteNonQuery();
				}
						
				MainFrm.con.Close();

				dgv.Rows.Clear();
				MessageBox.Show("DB 전송이 완료되었습니다.");
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.Message);
				MainFrm.con.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tbCnt.Text == "")
			{
				MessageBox.Show("올바른 수량을 입력하세요.");
				return;
			}

			barcodeFrm frm = new barcodeFrm(Int16.Parse(tbCnt.Text));
			frm.SendMsg += new barcodeFrm.SendMsgDele(BarcodeList_Msg);

			Point parentPoint = this.Location;
			frm.StartPosition = FormStartPosition.Manual;
			frm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
			frm.Show();
		}


		void BarcodeList_Msg(Object obj1, Object obj2)
		{
			int num = (int)obj1;
			string[] buf = (string[])obj2;


			if (num == -1)	//DeleteRow
			{
				if (dgv.Rows.Count > 0)
				{
					dgv.Rows.Remove(dgv.Rows[dgv.Rows.Count-1]);
				}
			}
			else
			{

				try
				{
					if (dgv.InvokeRequired)
					{

						dgv.Invoke(new MethodInvoker(delegate
						{
							dgv.Rows.Add();
							dgv.Rows[dgv.Rows.Count - 1].Cells[0].Value = dgv.Rows.Count;//num.ToString();
							dgv.Rows[dgv.Rows.Count - 1].Cells[3].Value = buf[0];
							dgv.Rows[dgv.Rows.Count - 1].Cells[4].Value = buf[1];
						}));
					}

					FindDB();

				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.ToString());
				}
			}
			//dgv.Rows.Add(msg[0]);
			//dgv.Rows.Add(msg[1]);
		}

		private void FindDB()
		{
			try
			{
				DataSet ds = new DataSet();
				//MySqlDataAdapter 클래스를 이용하여 비연결 모드로 데이타 가져오기
				string inBarcode = dgv.Rows[dgv.Rows.Count - 1].Cells[3].Value.ToString();
				string sql = "SELECT serial, setID, deviceID  FROM bms_manufacturer.production WHERE inBarcode='";
				sql += inBarcode + "'";

				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, MainFrm.con);
				adpt.Fill(ds, "members");
				if (ds.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow r in ds.Tables[0].Rows)
					{
						//Console.WriteLine(r["serial"]);
						dgv.Rows[dgv.Rows.Count - 1].Cells[5].Value = r["serial"].ToString();
						dgv.Rows[dgv.Rows.Count - 1].Cells[1].Value = r["setID"].ToString();
						dgv.Rows[dgv.Rows.Count - 1].Cells[2].Value = r["deviceID"].ToString();
					}
				}
				else
				{
					MessageBox.Show("PCB바코드 " + inBarcode + " 를 DB에서 검색할 수 없습니다.");
				}
				//MainFrm.con.Close();
			}
			catch (MySqlException ex)
			{
				switch (ex.Number)
				{
					case 0:
						MessageBox.Show("Cannot connect to server. Contact administrator");
						break;
					case 1045:
						MessageBox.Show("Invalid username/password, please try again");
						break;
					default:
						MessageBox.Show(ex.Message);
						break;
				}
			}
		}


		private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			dgv.Rows.Clear();

			if (Application.OpenForms["barcodeFrm"] != null) Application.OpenForms["barcodeFrm"].Close();
			//frm.Close();
		}
	}
}
