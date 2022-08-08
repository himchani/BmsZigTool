using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BMSMonitor
{
	public partial class waitFrm : Form
	{
		public Action Worker { get; set; }
		public waitFrm(Action worker)
		{
			InitializeComponent();
			if (worker == null)
			{
				throw new ArgumentNullException();
			}
			Worker = worker;

		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
		}
	}
}
