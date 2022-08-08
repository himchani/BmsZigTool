using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMSMonitor
{
	public partial class detailFrm : Form
	{
		DataGridViewRow seletedRow;
		public detailFrm(DataGridViewRow row)
		{
			InitializeComponent();
			seletedRow = row;
		}

		protected override void WndProc(ref Message m)		//make move form
		{
			switch (m.Msg)
			{
				case 0x84:
					base.WndProc(ref m);
					if ((int)m.Result == 0x1)
					{
						m.Result = (IntPtr)0x2;
					}
					return;
			}
			base.WndProc(ref m);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void detailFrm_Load(object sender, EventArgs e)
		{
			string strInfo = "";
			Console.WriteLine("detailFrm_Load");
			int type = (int)seletedRow.Cells[4].Value;
			uint setid = (uint)seletedRow.Cells[7].Value;
			uint devid = (uint)seletedRow.Cells[8].Value;

			strInfo = setid.ToString() + "\r\n";
			strInfo += devid.ToString() + "\r\n";

			strInfo += seletedRow.Cells[6].Value.ToString().Insert(8, "-") + "\r\n";		//IEEE64

			if (type == 1) strInfo += "2V\n";
			else if (type == 2) strInfo += "6V\n";
			else if (type == 3) strInfo += "12V\n";

			tbInfo.Text = strInfo;

			string strCal = "";
			for (int i = 0; i < 16; i++)
			{
				strCal += seletedRow.Cells[15 + i].Value.ToString() + " ";
				if (i == 7 || i == 15) strCal += "\r\n";
			}

			strCal += seletedRow.Cells[13].Value.ToString() + " ";
			strCal += seletedRow.Cells[14].Value.ToString() + " ";

			tbCal.Text = strCal;

			tbMemo.Text = seletedRow.Cells[33].Value.ToString();
		}
	}
}
