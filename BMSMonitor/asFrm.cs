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
	public partial class asFrm : Form
	{

		private string[] strTmp = new string[4];

		public asFrm()
		{
			InitializeComponent();
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
			strTmp[0] = tbFault.Text;
			strTmp[1] = tbRepair.Text;
			strTmp[2] = dateTimePicker1.Value.ToString("yyyy-MM-dd");;
			strTmp[3] = dateTimePicker2.Value.ToString("yyyy-MM-dd"); ;

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		public string[] GetCause
		{
			get { return this.strTmp; }
			set { this.strTmp = value; }
		}

		private void button3_DragDrop(object sender, DragEventArgs e)
		{

		}
	}
}
