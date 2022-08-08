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
	public partial class inquiryControl : UserControl
	{
		//private MySqlConnection con = null;
		//private MySqlCommand cmd = null;
		//private string strconn = "Server=" + MainFrm.strSrvName + ";Database=bms_manufacturer;Uid=" + MainFrm.strSrvID + ";Pwd=" + MainFrm.strSrvPass + ";";

		private MySqlDataAdapter mySqlDataAdapter;

		public inquiryControl()
		{
			InitializeComponent();
#if false
			using (waitFrm frm = new waitFrm(GetBuyer))
			{
				frm.ShowDialog(this);
			}
#endif

			dataGridView1.RowHeadersVisible = false;
		}



		private void btnQuery_Click(object sender, EventArgs e)
		{
			string[] header = {"번호", "시작날짜", "종료날짜", "출고날짜", "종류", "버전", "IEEE64", "SETID", "DEVID", "BUYER", "바코드1", "바코드2", "작업자", "5V", "3.3V", "V1", "V2", "V3", "V4",
								  "V5", "V6", "V7", "V8", "V9", "V10", "V11", "V12", "V13", "V14", "V15", "V16", "수리", "폐기", "메모"};
			MainFrm.con.Open();


			if (MainFrm.con.State == ConnectionState.Open)
			{
				string strComp = "";
				string strShip;

				if (cbbBuyer.SelectedIndex != 0)		//buyer 선택.
				{
					strComp = " where (buyer=" + cbbBuyer.SelectedIndex + ")";
				}

				string dt1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
				string dt2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

				if (strComp == "")
				{
					strComp = " where (dateTime >= '" + dt1 + "' and dateTime <= '" + dt2 + "')";
				}
				else strComp += "and (dateTime >= '" + dt1 + "' and dateTime <= '" + dt2 + "')";


				const string quote = "\"";
				if (cbShip.Checked)
				{
					//strShip = " is not null)";
					strShip = " is not null) or (deliveryDateTime <> " + quote + "0000-00-00 00:00:00" + quote + "))";
					strComp = strComp.Replace("dateTime", "deliveryDateTime");
				}
				else {
					
					strShip = " is null) or (deliveryDateTime = " + quote + "0000-00-00 00:00:00" + quote + "))";
				}

				if (strComp == "")		//buyer 조건 없음.
				{
					strComp = " where ((deliveryDateTime" + strShip;
				}
				else
				{
					strComp += " and ((deliveryDateTime" + strShip;
				}


				if (tbSetID.Text != "")
				{
					strComp += " and (setID =" + tbSetID.Text + ")";
				}

				mySqlDataAdapter = new MySqlDataAdapter("select * from production" + strComp, MainFrm.con);
				DataSet DS = new DataSet();
				mySqlDataAdapter.Fill(DS);


				dataGridView1.DataSource = DS.Tables[0];
				//this.CloseConnection();
				int i = 0;
				foreach (DataGridViewColumn col in dataGridView1.Columns)
				{
					col.HeaderText = header[i++];
					col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				}

				dataGridView1.Columns[2].Visible = false;
				for (i = 13; i < 13 + 18; i++)
				{
					dataGridView1.Columns[i].Visible = false;	//5V, 3.3V, V1~16
				}

				lbTotalCnt.Text = dataGridView1.Rows.Count.ToString();
				MainFrm.con.Close();


				dataGridView1.ReadOnly = true;
				//dataGridView1.ColumnHeadersVisible = false;
			}
		}


		delegate void StringArgReturningVoidDelegate(string text);
		private void AddItem(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (this.cbbBuyer.InvokeRequired)
			{
				StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AddItem);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.cbbBuyer.Items.Add(text);
			}
		}


		public void GetBuyer()
		{
			int i = 0;
			string strconn = "Server=" + MainFrm.strSrvName + ";Database=bms_manufacturer;Uid=" + MainFrm.strSrvID + ";Pwd=" + MainFrm.strSrvPass + ";";
			string sql = "SELECT buyer FROM bms_manufacturer.buyerlist";

			//MySqlConnection con = new MySqlConnection(strconn);

			AddItem("전체");

			try
			{
				MainFrm.con.Open();

				if (MainFrm.con.State == ConnectionState.Open)
				{
					MySqlCommand cmd = new MySqlCommand(sql, MainFrm.con);

					IAsyncResult cres = cmd.BeginExecuteReader();
					MySqlDataReader rdr = cmd.EndExecuteReader(cres);
					while (rdr.Read())
					{
						//cbbBuyer.Items.Add(rdr.GetString(0));

						string buyer = rdr.GetString(0);
						Console.WriteLine(buyer);
						AddItem(buyer);
						i++;
						//cbbBuyer.Items.Add(buyer);
					}

					MainFrm.con.Close();
				}
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

		private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
		{
#if false
			if (e.Button == MouseButtons.Right)
			{
				ContextMenu m = new ContextMenu();
				m.MenuItems.Add(new MenuItem("출하완료"));

				int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

				if (currentMouseOverRow >= 0)
				{
					m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
				}

				m.Show(dataGridView1, new Point(e.X, e.Y));
			}
#endif
		}

		private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (cbShip.Checked) return;

			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				if (e.Button == MouseButtons.Right)
				{
					DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];


					// Here you can do whatever you want with the cell
					this.dataGridView1.CurrentCell = clickedCell;  // Select the clicked cell, for instance

					// Get mouse position relative to the vehicles grid
					var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);

					// Show the context menu
					this.contextMenuStrip1.Show(dataGridView1, relativeMousePosition);
				}
			}
		}

		private void 출고완료ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}


		private bool SQL_Open(MySqlConnection con)
		{
			try
			{
				con.Open();

				if (con.State == ConnectionState.Open) return true;
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
			return false;
		}

		private void SQL_Close(MySqlConnection con)
		{
			con.Close();
			con = null;
		}

		private void 폐기ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 메모ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string strMemo = null;

			if (SQL_Open(MainFrm.con) == false)
			{
				return;
			}


			memoFrm frm = new memoFrm();
			frm.Location = dataGridView1.PointToClient(Cursor.Position);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				strMemo = frm.PassValue;

				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					if (row.Selected)
					{

						var comm = MainFrm.con.CreateCommand();
						comm.CommandText = "UPDATE production SET memo=?memo WHERE serial=?serial";
						comm.Parameters.AddWithValue("?memo", strMemo);
						comm.Parameters.AddWithValue("?serial", row.Cells[0].Value.ToString());

						//string strCmd = "UPDATE production SET memo= \"" + strMemo + "\"" + " WHERE serial=" + row.Cells[0].Value;

						try
						{
							//MySqlCommand cmd = new MySqlCommand(strCmd, MainFrm.con);
							comm.ExecuteNonQuery();
						}
						catch
						{
							MessageBox.Show("Serial : " + row.Cells[0].Value + " DB업데이트에 실패했습니다.");
						}
					}
				}
				MessageBox.Show("완료되었습니다.");
			}
			SQL_Close(MainFrm.con);
		}

		private void 현재날짜시간ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//insert deleveryDateTime

			if (SQL_Open(MainFrm.con) == false)
			{
				return;
			}

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Selected)
				{
					string strDateTime = DateTime.Now.ToString("yyyy-MM-dd");
					string strCmd = "UPDATE production SET deliveryDateTime= '" + strDateTime + "'" + " WHERE serial=" + row.Cells[0].Value;

					try
					{
						MySqlCommand cmd = new MySqlCommand(strCmd, MainFrm.con);
						cmd.ExecuteNonQuery();
					}
					catch
					{
						MessageBox.Show("Serial : " + row.Cells[0].Value + " DB업데이트에 실패했습니다.");
					}
				}
			}
			MessageBox.Show("완료되었습니다.");

			SQL_Close(MainFrm.con);
		}

		private void 날짜시간선택ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			datetimeFrm frm = new datetimeFrm();

			frm.Left = Cursor.Position.X;
			frm.Top = Cursor.Position.Y;


			if (frm.ShowDialog() == DialogResult.OK)
			{
				string strDateTime = frm.PassValue;

				if (SQL_Open(MainFrm.con) == false)
				{
					return;
				}

				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					if (row.Selected)
					{
						//string strDateTime = DateTime.Now.ToString("yyyy-MM-dd");
						string strCmd = "UPDATE production SET deliveryDateTime= '" + strDateTime + "'" + " WHERE serial=" + row.Cells[0].Value;

						try
						{
							MySqlCommand cmd = new MySqlCommand(strCmd, MainFrm.con);
							cmd.ExecuteNonQuery();
						}
						catch
						{
							MessageBox.Show("Serial : " + row.Cells[0].Value + " DB업데이트에 실패했습니다.");
						}
					}
				}
				MessageBox.Show("완료되었습니다.");

				SQL_Close(MainFrm.con);
			}
		}

		private void aS이력ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			asFrm frm = new asFrm();

			//Point pos = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);

			//frm.Location = dataGridView1.PointToClient(Cursor.Position);
			frm.Location = Cursor.Position;

			if (frm.ShowDialog() == DialogResult.OK)
			{
				string[] strArry = frm.GetCause;		//0:증상, 원인, 1:수리내역, 2:입고날짜, 3:출고날짜.

				if (!SQL_Open(MainFrm.con))
				{
					MessageBox.Show("DB에 연결할 수 없습니다.");
					return;
				}

				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
				{
					//row.Cells[0].Value;		//serial;

					string strCmd = "INSERT INTO service (devSerial, inDateTime, outDateTime, fault, repair) VALUES (" +  row.Cells[0].Value + ", '" + strArry[2] + "', '" + strArry[3] + "', '" +
						strArry[0] + "', '" + strArry[1] + "')";

					MainFrm.cmd = new MySqlCommand(strCmd, MainFrm.con);
					MainFrm.cmd.ExecuteNonQuery();

				}
				SQL_Close(MainFrm.con);
			}
		}

		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Console.WriteLine("mouse double click");

			detailFrm frm = new detailFrm(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex]);
			frm.Location = dataGridView1.PointToClient(Cursor.Position);
			frm.ShowDialog(this);
		}
	}
}
