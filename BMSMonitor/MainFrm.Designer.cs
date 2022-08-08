namespace BMSMonitor
{
	partial class MainFrm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.sidePanel = new System.Windows.Forms.Panel();
			this.exitBtn = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnSetup = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnRelease = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.asControl1 = new BMSMonitor.asControl();
			this.inquiryControl1 = new BMSMonitor.inquiryControl();
			this.setupControl1 = new BMSMonitor.setupControl();
			this.releaseControl2 = new BMSMonitor.releaseControl();
			this.mainControl1 = new BMSMonitor.mainControl();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.sidePanel);
			this.panel1.Controls.Add(this.exitBtn);
			this.panel1.Controls.Add(this.btnSetup);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.btnRelease);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(134, 461);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox1.Location = new System.Drawing.Point(0, 414);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(134, 47);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// sidePanel
			// 
			this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.sidePanel.Location = new System.Drawing.Point(0, 0);
			this.sidePanel.Name = "sidePanel";
			this.sidePanel.Size = new System.Drawing.Size(10, 54);
			this.sidePanel.TabIndex = 2;
			// 
			// exitBtn
			// 
			this.exitBtn.FlatAppearance.BorderSize = 0;
			this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitBtn.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.exitBtn.ForeColor = System.Drawing.Color.White;
			this.exitBtn.ImageIndex = 6;
			this.exitBtn.ImageList = this.imageList1;
			this.exitBtn.Location = new System.Drawing.Point(0, 270);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(177, 54);
			this.exitBtn.TabIndex = 6;
			this.exitBtn.Text = "종료";
			this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			this.imageList1.Images.SetKeyName(0, "iconfinder_General_Office_09_3592869.png");
			this.imageList1.Images.SetKeyName(1, "iconfinder_General_Office_31_3592824.png");
			this.imageList1.Images.SetKeyName(2, "iconfinder_General_Office_48_3592847.png");
			this.imageList1.Images.SetKeyName(3, "iconfinder_General_Office_49_3592832.png");
			this.imageList1.Images.SetKeyName(4, "iconfinder_General_Office_56_3592841.png");
			this.imageList1.Images.SetKeyName(5, "iconfinder_General_Office_61_3592836.png");
			this.imageList1.Images.SetKeyName(6, "iconfinder_General_Office_24_3592821.png");
			// 
			// btnSetup
			// 
			this.btnSetup.FlatAppearance.BorderSize = 0;
			this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetup.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSetup.ForeColor = System.Drawing.Color.White;
			this.btnSetup.ImageIndex = 4;
			this.btnSetup.ImageList = this.imageList1;
			this.btnSetup.Location = new System.Drawing.Point(0, 216);
			this.btnSetup.Name = "btnSetup";
			this.btnSetup.Size = new System.Drawing.Size(177, 54);
			this.btnSetup.TabIndex = 5;
			this.btnSetup.Text = "설정";
			this.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSetup.UseVisualStyleBackColor = true;
			this.btnSetup.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.ImageIndex = 2;
			this.button3.ImageList = this.imageList1;
			this.button3.Location = new System.Drawing.Point(0, 108);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(177, 54);
			this.button3.TabIndex = 3;
			this.button3.Text = "A/S";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.ImageKey = "iconfinder_General_Office_09_3592869.png";
			this.button2.ImageList = this.imageList1;
			this.button2.Location = new System.Drawing.Point(0, 54);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(177, 54);
			this.button2.TabIndex = 2;
			this.button2.Text = "조회";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.ImageKey = "iconfinder_General_Office_61_3592836.png";
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(177, 54);
			this.button1.TabIndex = 1;
			this.button1.Text = "메인";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnRelease
			// 
			this.btnRelease.FlatAppearance.BorderSize = 0;
			this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRelease.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnRelease.ForeColor = System.Drawing.Color.White;
			this.btnRelease.ImageIndex = 1;
			this.btnRelease.ImageList = this.imageList1;
			this.btnRelease.Location = new System.Drawing.Point(0, 162);
			this.btnRelease.Name = "btnRelease";
			this.btnRelease.Size = new System.Drawing.Size(177, 54);
			this.btnRelease.TabIndex = 4;
			this.btnRelease.Text = "출고";
			this.btnRelease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRelease.UseVisualStyleBackColor = true;
			this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(134, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(780, 10);
			this.panel2.TabIndex = 20;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.Gray;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(134, 439);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(780, 22);
			this.statusStrip1.TabIndex = 21;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(765, 17);
			this.toolStripStatusLabel1.Spring = true;
			this.toolStripStatusLabel1.Text = "http://www.maroo-on.com";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// asControl1
			// 
			this.asControl1.BackColor = System.Drawing.Color.Gray;
			this.asControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.asControl1.Location = new System.Drawing.Point(134, 10);
			this.asControl1.Name = "asControl1";
			this.asControl1.Size = new System.Drawing.Size(780, 451);
			this.asControl1.TabIndex = 10;
			// 
			// inquiryControl1
			// 
			this.inquiryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inquiryControl1.Location = new System.Drawing.Point(134, 0);
			this.inquiryControl1.Name = "inquiryControl1";
			this.inquiryControl1.Size = new System.Drawing.Size(780, 461);
			this.inquiryControl1.TabIndex = 2;
			// 
			// setupControl1
			// 
			this.setupControl1.BackColor = System.Drawing.Color.Gray;
			this.setupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.setupControl1.Location = new System.Drawing.Point(134, 0);
			this.setupControl1.Name = "setupControl1";
			this.setupControl1.Size = new System.Drawing.Size(780, 461);
			this.setupControl1.TabIndex = 1;
			// 
			// releaseControl2
			// 
			this.releaseControl2.BackColor = System.Drawing.Color.Gray;
			this.releaseControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.releaseControl2.Location = new System.Drawing.Point(134, 0);
			this.releaseControl2.Name = "releaseControl2";
			this.releaseControl2.Size = new System.Drawing.Size(780, 461);
			this.releaseControl2.TabIndex = 4;
			// 
			// mainControl1
			// 
			this.mainControl1.BackColor = System.Drawing.Color.Gray;
			this.mainControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainControl1.ForeColor = System.Drawing.Color.Transparent;
			this.mainControl1.Location = new System.Drawing.Point(134, 0);
			this.mainControl1.Name = "mainControl1";
			this.mainControl1.Size = new System.Drawing.Size(780, 461);
			this.mainControl1.TabIndex = 3;
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(914, 461);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.asControl1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.inquiryControl1);
			this.Controls.Add(this.setupControl1);
			this.Controls.Add(this.releaseControl2);
			this.Controls.Add(this.mainControl1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(930, 500);
			this.Name = "MainFrm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BMS 생산이력조회 V1.0.0";
			this.Shown += new System.EventHandler(this.MainFrm_Shown);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel sidePanel;
		private System.Windows.Forms.Button btnSetup;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button exitBtn;
		private BMSMonitor.setupControl setupControl1;
		private inquiryControl inquiryControl1;
		private mainControl mainControl1;
		private asControl asControl1;
		private releaseControl releaseControl2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel2;		
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnRelease;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		
	}
}

