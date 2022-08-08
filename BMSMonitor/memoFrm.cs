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
	public partial class memoFrm : Form
	{
		private string strMemo;

		public memoFrm()
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
			strMemo = textBox1.Text;
			this.DialogResult =  DialogResult.OK;
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		public string PassValue
		{
			get { return this.strMemo; }
			set { this.strMemo = value; }
		}

	}
}
