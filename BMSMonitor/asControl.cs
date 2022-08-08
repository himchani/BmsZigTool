using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BMSMonitor
{
	public partial class asControl : UserControl
	{
		private MySqlDataAdapter mySqlDataAdapter = null;

		public asControl()
		{
			InitializeComponent();
			cbbType.SelectedIndex = 0;
			dataGridView1.RowHeadersVisible = false;

			
		}

		private void btnQuery_Click(object sender, EventArgs e)
		{
			string[] header = {"번호", "입고일", "출고일", "증상", "수리내역", "메모"};
			MainFrm.con.Open();
			if (MainFrm.con.State == ConnectionState.Open)
			{
				DateTime dt1 = dateTimePicker1.Value;
				DateTime dt2 = dateTimePicker2.Value;

				int ret = DateTime.Compare(dt1, dt2);
				if (ret > 0) {	//dt1 > dt2 일 경우.
					MessageBox.Show("시작날짜가 종료날짜 보다 큽니다.");
					return;
				}

				int i = 0;
				string strCmd = "SELECT * FROM service WHERE (inDateTime >= '" + dt1.ToString("yyyy-MM-dd") + "' and inDateTime <= '" + dt2.ToString("yyyy-MM-dd") + "')";





				try
				{
					mySqlDataAdapter = new MySqlDataAdapter(strCmd, MainFrm.con);
					DataSet DS = new DataSet();
					mySqlDataAdapter.Fill(DS);
					//mySqlDataAdapter.Dispose();

					string strQuery;
					bool bFirst = false;
					foreach (DataRow dr in DS.Tables[0].Rows)
					{
						strQuery = "SELECT setID, deviceID, inBarcode, outBarcode FROM production WHERE (serial = " + dr[1] + ")";

						if (cbbType.SelectedIndex != 0)
						{
							strQuery += " and (type = " + cbbType.SelectedIndex + ")";
						}

						MySqlDataAdapter da = new MySqlDataAdapter(strQuery, MainFrm.con);

						DataSet da_info = new DataSet();
						da.Fill(da_info);

						if (da_info.Tables[0].Rows.Count > 0)
						{

							if (!bFirst)
							{
								DS.Tables[0].Columns.Add(da_info.Tables[0].Columns[0].ToString(), da_info.Tables[0].Columns[0].DataType);
								DS.Tables[0].Columns.Add(da_info.Tables[0].Columns[1].ToString(), da_info.Tables[0].Columns[1].DataType);
								DS.Tables[0].Columns.Add(da_info.Tables[0].Columns[2].ToString(), da_info.Tables[0].Columns[2].DataType);
								DS.Tables[0].Columns.Add(da_info.Tables[0].Columns[3].ToString(), da_info.Tables[0].Columns[3].DataType);
								bFirst = true;								
							}

							dr[7] = da_info.Tables[0].Rows[0].ItemArray[0];
							dr[8] = da_info.Tables[0].Rows[0].ItemArray[1];
							dr[9] = da_info.Tables[0].Rows[0].ItemArray[2];
							dr[10] = da_info.Tables[0].Rows[0].ItemArray[3];
						}
						else
						{
							dr.Delete();
						}
						i++;
					}

					if (bFirst)
					{
						dataGridView1.DataSource = DS.Tables[0];
						dataGridView1.Columns[0].Visible = false;

						foreach (DataGridViewColumn col in dataGridView1.Columns)
						{
							col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
						}
					}
					
				}
				catch
				{
					//MessageBox.Show("Serial : " + row.Cells[0].Value + " DB업데이트에 실패했습니다.");
				}

				lbCount.Text = String.Format("총 {0} 건", i);
				MainFrm.con.Close();
			}
		}
	}
}
