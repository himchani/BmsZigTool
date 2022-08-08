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
	public partial class mainControl : UserControl
	{
		public mainControl()
		{
			InitializeComponent();
		}

		public void GetInfo()
		{
			MainFrm.con.Open();

			using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM bms_manufacturer.production", MainFrm.con))
			{
				int count = Convert.ToInt32(cmd.ExecuteScalar());

				lbTotalCnt.Text = count.ToString();
			}


			using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM bms_manufacturer.production WHERE deliveryDateTime <> 'null'", MainFrm.con))
			{
				int count = Convert.ToInt32(cmd.ExecuteScalar());

				lbReleaseCnt.Text = count.ToString();
			}

			using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM bms_manufacturer.production WHERE type=1", MainFrm.con))
			{
				int count = Convert.ToInt32(cmd.ExecuteScalar());

				lbTotal202.Text = count.ToString();
			}

			using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM bms_manufacturer.production WHERE type=2", MainFrm.con))
			{
				int count = Convert.ToInt32(cmd.ExecuteScalar());

				lbTotal206.Text = count.ToString();
			}

			using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM bms_manufacturer.production WHERE type=3", MainFrm.con))
			{
				int count = Convert.ToInt32(cmd.ExecuteScalar());

				lbTotal212.Text = count.ToString();
			}


			using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM bms_manufacturer.production WHERE type=1 AND deliveryDateTime <> 'null'", MainFrm.con))
			{
				int count = Convert.ToInt32(cmd.ExecuteScalar());

				lbRel202.Text = count.ToString();
			}

			using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM bms_manufacturer.production WHERE type=2 AND deliveryDateTime <> 'null'", MainFrm.con))
			{
				int count = Convert.ToInt32(cmd.ExecuteScalar());

				lbRel206.Text = count.ToString();
			}

			using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM bms_manufacturer.production WHERE type=3 AND deliveryDateTime <> 'null'", MainFrm.con))
			{
				int count = Convert.ToInt32(cmd.ExecuteScalar());

				lbRel212.Text = count.ToString();
			}
			MainFrm.con.Close();


		}
	}
}
