namespace BMSMonitor
{
	partial class setupControl
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbServerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbServerId = new System.Windows.Forms.TextBox();
			this.tbServerPass = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(32, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "DB 주소";
			// 
			// tbServerName
			// 
			this.tbServerName.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.tbServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbServerName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tbServerName.ForeColor = System.Drawing.Color.White;
			this.tbServerName.Location = new System.Drawing.Point(165, 30);
			this.tbServerName.Name = "tbServerName";
			this.tbServerName.Size = new System.Drawing.Size(431, 26);
			this.tbServerName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(32, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(32, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "PASSWORD";
			// 
			// tbServerId
			// 
			this.tbServerId.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.tbServerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbServerId.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tbServerId.ForeColor = System.Drawing.Color.White;
			this.tbServerId.Location = new System.Drawing.Point(165, 64);
			this.tbServerId.Name = "tbServerId";
			this.tbServerId.Size = new System.Drawing.Size(216, 26);
			this.tbServerId.TabIndex = 2;
			// 
			// tbServerPass
			// 
			this.tbServerPass.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.tbServerPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbServerPass.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tbServerPass.ForeColor = System.Drawing.Color.White;
			this.tbServerPass.Location = new System.Drawing.Point(165, 99);
			this.tbServerPass.Name = "tbServerPass";
			this.tbServerPass.Size = new System.Drawing.Size(216, 26);
			this.tbServerPass.TabIndex = 3;
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnOk.FlatAppearance.BorderSize = 0;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(399, 193);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(197, 58);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "확인";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnTest
			// 
			this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnTest.FlatAppearance.BorderSize = 0;
			this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTest.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnTest.ForeColor = System.Drawing.Color.White;
			this.btnTest.Location = new System.Drawing.Point(165, 193);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(197, 58);
			this.btnTest.TabIndex = 4;
			this.btnTest.Text = "테스트";
			this.btnTest.UseVisualStyleBackColor = false;
			// 
			// setupControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tbServerPass);
			this.Controls.Add(this.tbServerId);
			this.Controls.Add(this.tbServerName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "setupControl";
			this.Size = new System.Drawing.Size(855, 437);
			this.Load += new System.EventHandler(this.setupControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbServerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbServerId;
		private System.Windows.Forms.TextBox tbServerPass;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnTest;

	}
}
