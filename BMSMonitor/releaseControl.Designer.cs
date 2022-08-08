namespace BMSMonitor
{
	partial class releaseControl
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

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnInit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dtPick = new System.Windows.Forms.DateTimePicker();
			this.tbCnt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbBuyer = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnApply = new System.Windows.Forms.Button();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.btnInit);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.dtPick);
			this.panel1.Controls.Add(this.tbCnt);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbType);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbBuyer);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btnApply);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 75);
			this.panel1.TabIndex = 2;
			// 
			// btnInit
			// 
			this.btnInit.BackColor = System.Drawing.Color.DarkBlue;
			this.btnInit.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnInit.FlatAppearance.BorderSize = 0;
			this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInit.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnInit.ForeColor = System.Drawing.Color.White;
			this.btnInit.Location = new System.Drawing.Point(558, 0);
			this.btnInit.Name = "btnInit";
			this.btnInit.Size = new System.Drawing.Size(121, 75);
			this.btnInit.TabIndex = 17;
			this.btnInit.Text = "초기화";
			this.btnInit.UseVisualStyleBackColor = false;
			this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkBlue;
			this.button1.Dock = System.Windows.Forms.DockStyle.Right;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(679, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 75);
			this.button1.TabIndex = 16;
			this.button1.Text = "바코드스캔";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dtPick
			// 
			this.dtPick.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.dtPick.CalendarMonthBackground = System.Drawing.Color.Gray;
			this.dtPick.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
			this.dtPick.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dtPick.Location = new System.Drawing.Point(130, 41);
			this.dtPick.Name = "dtPick";
			this.dtPick.Size = new System.Drawing.Size(152, 29);
			this.dtPick.TabIndex = 15;
			// 
			// tbCnt
			// 
			this.tbCnt.BackColor = System.Drawing.Color.White;
			this.tbCnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCnt.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbCnt.Location = new System.Drawing.Point(369, 43);
			this.tbCnt.MaxLength = 500;
			this.tbCnt.Name = "tbCnt";
			this.tbCnt.Size = new System.Drawing.Size(67, 29);
			this.tbCnt.TabIndex = 14;
			this.tbCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(321, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 21);
			this.label2.TabIndex = 13;
			this.label2.Text = "수량";
			// 
			// cbType
			// 
			this.cbType.BackColor = System.Drawing.Color.MidnightBlue;
			this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbType.FormattingEnabled = true;
			this.cbType.Items.AddRange(new object[] {
            "B-202",
            "B-206",
            "B-212"});
			this.cbType.Location = new System.Drawing.Point(369, 6);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(81, 29);
			this.cbType.TabIndex = 12;
			this.cbType.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(321, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 21);
			this.label1.TabIndex = 11;
			this.label1.Text = "종류";
			this.label1.Visible = false;
			// 
			// cbBuyer
			// 
			this.cbBuyer.BackColor = System.Drawing.Color.DimGray;
			this.cbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBuyer.FormattingEnabled = true;
			this.cbBuyer.Location = new System.Drawing.Point(183, 6);
			this.cbBuyer.Name = "cbBuyer";
			this.cbBuyer.Size = new System.Drawing.Size(121, 29);
			this.cbBuyer.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(126, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "Buyer";
			// 
			// btnApply
			// 
			this.btnApply.BackColor = System.Drawing.Color.DarkBlue;
			this.btnApply.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnApply.FlatAppearance.BorderSize = 0;
			this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApply.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnApply.ForeColor = System.Drawing.Color.White;
			this.btnApply.Location = new System.Drawing.Point(0, 0);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(101, 75);
			this.btnApply.TabIndex = 0;
			this.btnApply.Text = "적용";
			this.btnApply.UseVisualStyleBackColor = false;
			this.btnApply.Click += new System.EventHandler(this.btnQuery_Click);
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToResizeRows = false;
			this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv.Location = new System.Drawing.Point(0, 75);
			this.dgv.Name = "dgv";
			this.dgv.RowTemplate.Height = 23;
			this.dgv.Size = new System.Drawing.Size(800, 366);
			this.dgv.TabIndex = 3;
			this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "번호";
			this.Column1.Name = "Column1";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Set ID";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Device ID";
			this.Column6.Name = "Column6";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "PCB바코드";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "케이스바코드";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "시리얼";
			this.Column4.Name = "Column4";
			// 
			// releaseControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.panel1);
			this.Name = "releaseControl";
			this.Size = new System.Drawing.Size(800, 441);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.ComboBox cbBuyer;
		public System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbCnt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.DateTimePicker dtPick;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.Button btnInit;

	}
}
