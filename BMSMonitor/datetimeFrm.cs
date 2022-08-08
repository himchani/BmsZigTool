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
	public partial class datetimeFrm : Form
	{
		private string strDateTime;

		public datetimeFrm()
		{
			InitializeComponent();

			dateTimePicker1.CustomFormat = "yyyy-MM-dd";
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//dateTimePicker1.Format

			DateTime dt = dateTimePicker1.Value;
			strDateTime = dt.ToString("yyyy-MM-dd");

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		public string PassValue
		{
			get { return this.strDateTime; } // Form2에서 얻은(get) 값을 다른폼(Form1)으로 전달 목적
			set { this.strDateTime = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
