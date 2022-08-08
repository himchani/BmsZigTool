namespace BMSMonitor
{
	partial class inquiryControl
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnQuery = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbTotalCnt = new System.Windows.Forms.Label();
			this.tbSetID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbbBuyer = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.cbShip = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.출고완료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.현재날짜시간ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.날짜시간선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.폐기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.메모ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aS이력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnQuery
			// 
			this.btnQuery.BackColor = System.Drawing.Color.DimGray;
			this.btnQuery.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnQuery.FlatAppearance.BorderSize = 0;
			this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuery.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnQuery.ForeColor = System.Drawing.Color.White;
			this.btnQuery.Location = new System.Drawing.Point(0, 0);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new System.Drawing.Size(101, 75);
			this.btnQuery.TabIndex = 0;
			this.btnQuery.Text = "조회";
			this.btnQuery.UseVisualStyleBackColor = false;
			this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.lbTotalCnt);
			this.panel1.Controls.Add(this.tbSetID);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cbbBuyer);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.cbShip);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dateTimePicker2);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.btnQuery);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 75);
			this.panel1.TabIndex = 1;
			// 
			// lbTotalCnt
			// 
			this.lbTotalCnt.AutoSize = true;
			this.lbTotalCnt.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbTotalCnt.ForeColor = System.Drawing.Color.White;
			this.lbTotalCnt.Location = new System.Drawing.Point(696, 7);
			this.lbTotalCnt.Name = "lbTotalCnt";
			this.lbTotalCnt.Size = new System.Drawing.Size(0, 25);
			this.lbTotalCnt.TabIndex = 10;
			// 
			// tbSetID
			// 
			this.tbSetID.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSetID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tbSetID.Location = new System.Drawing.Point(479, 44);
			this.tbSetID.MaxLength = 5;
			this.tbSetID.Name = "tbSetID";
			this.tbSetID.Size = new System.Drawing.Size(100, 22);
			this.tbSetID.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(415, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 21);
			this.label4.TabIndex = 8;
			this.label4.Text = "SetID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(213, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "Buyer";
			// 
			// cbbBuyer
			// 
			this.cbbBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cbbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbbBuyer.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cbbBuyer.ForeColor = System.Drawing.Color.White;
			this.cbbBuyer.FormattingEnabled = true;
			this.cbbBuyer.Location = new System.Drawing.Point(279, 40);
			this.cbbBuyer.Name = "cbbBuyer";
			this.cbbBuyer.Size = new System.Drawing.Size(121, 29);
			this.cbbBuyer.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.Cyan;
			this.label2.Location = new System.Drawing.Point(733, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "건";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label18.ForeColor = System.Drawing.Color.Cyan;
			this.label18.Location = new System.Drawing.Point(651, 7);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(31, 25);
			this.label18.TabIndex = 5;
			this.label18.Text = "총";
			// 
			// cbShip
			// 
			this.cbShip.AutoSize = true;
			this.cbShip.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cbShip.ForeColor = System.Drawing.Color.White;
			this.cbShip.Location = new System.Drawing.Point(120, 44);
			this.cbShip.Name = "cbShip";
			this.cbShip.Size = new System.Drawing.Size(93, 25);
			this.cbShip.TabIndex = 4;
			this.cbShip.Text = "출고완료";
			this.cbShip.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(340, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "~";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePicker2.Location = new System.Drawing.Point(371, 6);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(208, 29);
			this.dateTimePicker2.TabIndex = 2;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Gray;
			this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
			this.dateTimePicker1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.dateTimePicker1.Location = new System.Drawing.Point(120, 6);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(205, 29);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(0, 75);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Purple;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(800, 366);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
			this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
			this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.출고완료ToolStripMenuItem,
            this.폐기ToolStripMenuItem,
            this.메모ToolStripMenuItem,
            this.aS이력ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(138, 92);
			// 
			// 출고완료ToolStripMenuItem
			// 
			this.출고완료ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재날짜시간ToolStripMenuItem,
            this.날짜시간선택ToolStripMenuItem});
			this.출고완료ToolStripMenuItem.Name = "출고완료ToolStripMenuItem";
			this.출고완료ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.출고완료ToolStripMenuItem.Text = "출고완료";
			// 
			// 현재날짜시간ToolStripMenuItem
			// 
			this.현재날짜시간ToolStripMenuItem.Name = "현재날짜시간ToolStripMenuItem";
			this.현재날짜시간ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.현재날짜시간ToolStripMenuItem.Text = "현재날짜";
			this.현재날짜시간ToolStripMenuItem.Click += new System.EventHandler(this.현재날짜시간ToolStripMenuItem_Click);
			// 
			// 날짜시간선택ToolStripMenuItem
			// 
			this.날짜시간선택ToolStripMenuItem.Name = "날짜시간선택ToolStripMenuItem";
			this.날짜시간선택ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.날짜시간선택ToolStripMenuItem.Text = "날짜선택";
			this.날짜시간선택ToolStripMenuItem.Click += new System.EventHandler(this.날짜시간선택ToolStripMenuItem_Click);
			// 
			// 폐기ToolStripMenuItem
			// 
			this.폐기ToolStripMenuItem.Name = "폐기ToolStripMenuItem";
			this.폐기ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.폐기ToolStripMenuItem.Text = "폐기";
			this.폐기ToolStripMenuItem.Click += new System.EventHandler(this.폐기ToolStripMenuItem_Click);
			// 
			// 메모ToolStripMenuItem
			// 
			this.메모ToolStripMenuItem.Name = "메모ToolStripMenuItem";
			this.메모ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.메모ToolStripMenuItem.Text = "메모";
			this.메모ToolStripMenuItem.Click += new System.EventHandler(this.메모ToolStripMenuItem_Click);
			// 
			// aS이력ToolStripMenuItem
			// 
			this.aS이력ToolStripMenuItem.Name = "aS이력ToolStripMenuItem";
			this.aS이력ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.aS이력ToolStripMenuItem.Text = "AS이력등록";
			this.aS이력ToolStripMenuItem.Click += new System.EventHandler(this.aS이력ToolStripMenuItem_Click);
			// 
			// inquiryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "inquiryControl";
			this.Size = new System.Drawing.Size(800, 441);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnQuery;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbShip;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label18;
		public System.Windows.Forms.ComboBox cbbBuyer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbSetID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbTotalCnt;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 출고완료ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 폐기ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 메모ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 현재날짜시간ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 날짜시간선택ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aS이력ToolStripMenuItem;
	}
}
