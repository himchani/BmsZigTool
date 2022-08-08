namespace SampleApp
{
	partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fw_download_btn = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.pb3 = new System.Windows.Forms.ProgressBar();
            this.pb6 = new System.Windows.Forms.ProgressBar();
            this.pb5 = new System.Windows.Forms.ProgressBar();
            this.pb4 = new System.Windows.Forms.ProgressBar();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.cbb2 = new System.Windows.Forms.ComboBox();
            this.cbb3 = new System.Windows.Forms.ComboBox();
            this.cbb4 = new System.Windows.Forms.ComboBox();
            this.cbb5 = new System.Windows.Forms.ComboBox();
            this.cbb6 = new System.Windows.Forms.ComboBox();
            this.fw_load_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cbb7 = new System.Windows.Forms.ComboBox();
            this.pb7 = new System.Windows.Forms.ProgressBar();
            this.pb8 = new System.Windows.Forms.ProgressBar();
            this.cbb8 = new System.Windows.Forms.ComboBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.pb10 = new System.Windows.Forms.ProgressBar();
            this.cbb10 = new System.Windows.Forms.ComboBox();
            this.cb10 = new System.Windows.Forms.CheckBox();
            this.pb9 = new System.Windows.Forms.ProgressBar();
            this.cbb9 = new System.Windows.Forms.ComboBox();
            this.cb9 = new System.Windows.Forms.CheckBox();
            this.pb12 = new System.Windows.Forms.ProgressBar();
            this.cbb12 = new System.Windows.Forms.ComboBox();
            this.cb12 = new System.Windows.Forms.CheckBox();
            this.pb11 = new System.Windows.Forms.ProgressBar();
            this.cbb11 = new System.Windows.Forms.ComboBox();
            this.cb11 = new System.Windows.Forms.CheckBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.zig_up_btn = new System.Windows.Forms.Button();
            this.zig_down_btn = new System.Windows.Forms.Button();
            this.isp_on_btn = new System.Windows.Forms.Button();
            this.device_reset_btn = new System.Windows.Forms.Button();
            this.isp_off_btn = new System.Windows.Forms.Button();
            this.instantAiCtrl1 = new Automation.BDaq.InstantAiCtrl(this.components);
            this.instantAiCtrl2 = new Automation.BDaq.InstantAiCtrl(this.components);
            this.instantDiCtrl1 = new Automation.BDaq.InstantDiCtrl(this.components);
            this.instantDoCtrl1 = new Automation.BDaq.InstantDoCtrl(this.components);
            this.psw3036_serialPort = new System.IO.Ports.SerialPort(this.components);
            this.psu_on_btn = new System.Windows.Forms.Button();
            this.psu_off_btn = new System.Windows.Forms.Button();
            this.psu_set_v_textBox = new System.Windows.Forms.TextBox();
            this.psu_target_i_textBox = new System.Windows.Forms.TextBox();
            this.psu_set_btn = new System.Windows.Forms.Button();
            this.psu_set_v_label = new System.Windows.Forms.Label();
            this.psu_target_i_label = new System.Windows.Forms.Label();
            this.dmm_v_label = new System.Windows.Forms.Label();
            this.dmm_v_textBox = new System.Windows.Forms.TextBox();
            this.dev1_label = new System.Windows.Forms.Label();
            this.dev2_label = new System.Windows.Forms.Label();
            this.dev4_label = new System.Windows.Forms.Label();
            this.dev3_label = new System.Windows.Forms.Label();
            this.dev8_label = new System.Windows.Forms.Label();
            this.dev7_label = new System.Windows.Forms.Label();
            this.dev6_label = new System.Windows.Forms.Label();
            this.dev5_label = new System.Windows.Forms.Label();
            this.dev12_label = new System.Windows.Forms.Label();
            this.dev11_label = new System.Windows.Forms.Label();
            this.dev10_label = new System.Windows.Forms.Label();
            this.dev9_label = new System.Windows.Forms.Label();
            this.dev_pwr_all_on_btn = new System.Windows.Forms.Button();
            this.dev_pwr_all_off_btn = new System.Windows.Forms.Button();
            this.dev1_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev2_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev4_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev3_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev8_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev7_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev6_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev5_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev12_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev11_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev10_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev9_set_i_tb = new System.Windows.Forms.TextBox();
            this.dev12_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev11_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev10_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev9_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev8_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev7_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev6_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev5_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev4_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev3_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev2_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev1_ovp_v_tb = new System.Windows.Forms.TextBox();
            this.dev12_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev11_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev10_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev9_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev8_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev7_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev6_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev5_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev4_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev3_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev2_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev1_2nd_v_tb = new System.Windows.Forms.TextBox();
            this.dev12_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev11_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev10_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev9_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev8_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev7_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev6_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev5_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev4_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev3_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev2_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev1_1st_v_tb = new System.Windows.Forms.TextBox();
            this.dev12_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev11_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev10_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev9_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev8_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev7_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev6_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev5_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev4_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev3_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev2_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev1_adc_v_tb = new System.Windows.Forms.TextBox();
            this.dev_set_i_lb = new System.Windows.Forms.Label();
            this.dev_ovp_v_lb = new System.Windows.Forms.Label();
            this.dev_1st_v_lb = new System.Windows.Forms.Label();
            this.dev_2nd_v_lb = new System.Windows.Forms.Label();
            this.dev_adc_v_lb = new System.Windows.Forms.Label();
            this.dev1_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev2_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev3_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev4_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev5_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev6_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev7_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev8_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev9_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev10_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev11_ieee64_tb = new System.Windows.Forms.TextBox();
            this.dev12_ieee64_tb = new System.Windows.Forms.TextBox();
            this.psw3036_port_cbb = new System.Windows.Forms.ComboBox();
            this.dmm_port_cbb = new System.Windows.Forms.ComboBox();
            this.dev1_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.fw_down_gb = new System.Windows.Forms.GroupBox();
            this.dev_ieee64_set_btn = new System.Windows.Forms.Button();
            this.dev_ieee64_set_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev_ieee64_set_tb = new System.Windows.Forms.TextBox();
            this.dev12_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev11_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev10_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev9_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev8_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev7_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev6_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev5_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev4_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev3_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.dev2_ieee64_chk_rdbtn = new System.Windows.Forms.RadioButton();
            this.fw_file_label = new System.Windows.Forms.Label();
            this.dev_2V_mode_btn = new System.Windows.Forms.Button();
            this.dev_6V_mode_btn = new System.Windows.Forms.Button();
            this.dev_12V_mode_btn = new System.Windows.Forms.Button();
            this.config_file_label = new System.Windows.Forms.Label();
            this.config_save_btn = new System.Windows.Forms.Button();
            this.config_load_btn = new System.Windows.Forms.Button();
            this.psu_connect_btn = new System.Windows.Forms.Button();
            this.dmm_connect_btn = new System.Windows.Forms.Button();
            this.dmm_serialPort = new System.IO.Ports.SerialPort(this.components);
            this.devchk_cbb = new System.Windows.Forms.ComboBox();
            this.devchk_connect_btn = new System.Windows.Forms.Button();
            this.psu_target_v_label = new System.Windows.Forms.Label();
            this.psu_target_v_textBox = new System.Windows.Forms.TextBox();
            this.devchk_serialPort = new System.IO.Ports.SerialPort(this.components);
            this.daq_adc_gb = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dev12_err_tb = new System.Windows.Forms.TextBox();
            this.dev11_err_tb = new System.Windows.Forms.TextBox();
            this.dev10_err_tb = new System.Windows.Forms.TextBox();
            this.dev9_err_tb = new System.Windows.Forms.TextBox();
            this.dev8_err_tb = new System.Windows.Forms.TextBox();
            this.dev7_err_tb = new System.Windows.Forms.TextBox();
            this.dev6_err_tb = new System.Windows.Forms.TextBox();
            this.dev5_err_tb = new System.Windows.Forms.TextBox();
            this.dev4_err_tb = new System.Windows.Forms.TextBox();
            this.dev3_err_tb = new System.Windows.Forms.TextBox();
            this.dev2_err_tb = new System.Windows.Forms.TextBox();
            this.dev1_err_tb = new System.Windows.Forms.TextBox();
            this.setting_gb = new System.Windows.Forms.GroupBox();
            this.op_stop_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.op_start_btn = new System.Windows.Forms.Button();
            this.op_end_time_tb = new System.Windows.Forms.TextBox();
            this.op_end_time_lb = new System.Windows.Forms.Label();
            this.op_start_time_tb = new System.Windows.Forms.TextBox();
            this.op_start_time_lb = new System.Windows.Forms.Label();
            this.fw_version_tb = new System.Windows.Forms.TextBox();
            this.fw_version_lb = new System.Windows.Forms.Label();
            this.mode_lb = new System.Windows.Forms.Label();
            this.worker_tb = new System.Windows.Forms.TextBox();
            this.worker_lb = new System.Windows.Forms.Label();
            this.db_btn = new System.Windows.Forms.Button();
            this.board_check_btn = new System.Windows.Forms.Button();
            this.machine_setting_gb = new System.Windows.Forms.GroupBox();
            this.op_status_lb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.psu_seg_ctl_lb = new System.Windows.Forms.Label();
            this.dmm_seg_ctl_lb = new System.Windows.Forms.Label();
            this.psu_seg_ctl = new Owf.Controls.DigitalDisplayControl();
            this.dmm_seg_ctl = new Owf.Controls.DigitalDisplayControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.bd_chk_avr_ovp = new System.Windows.Forms.TextBox();
            this.bd_chk_err_value_ovp = new System.Windows.Forms.TextBox();
            this.bd_chk_dvdt_ovp = new System.Windows.Forms.TextBox();
            this.bd_chk_avr_1st = new System.Windows.Forms.TextBox();
            this.bd_chk_err_value_1st = new System.Windows.Forms.TextBox();
            this.bd_chk_dvdt_1st = new System.Windows.Forms.TextBox();
            this.bd_chk_avr_2nd = new System.Windows.Forms.TextBox();
            this.bd_chk_err_value_2nd = new System.Windows.Forms.TextBox();
            this.bd_chk_dvdt_2nd = new System.Windows.Forms.TextBox();
            this.bd_chk_avr_adc = new System.Windows.Forms.TextBox();
            this.bd_chk_err_value_adc = new System.Windows.Forms.TextBox();
            this.bd_chk_dvdt_adc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dev_auto_mode_btn = new System.Windows.Forms.Button();
            this.fw_down_mode_btn = new System.Windows.Forms.Button();
            this.fw_down_gb.SuspendLayout();
            this.daq_adc_gb.SuspendLayout();
            this.setting_gb.SuspendLayout();
            this.machine_setting_gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fw_download_btn
            // 
            this.fw_download_btn.Location = new System.Drawing.Point(18, 22);
            this.fw_download_btn.Name = "fw_download_btn";
            this.fw_download_btn.Size = new System.Drawing.Size(98, 42);
            this.fw_download_btn.TabIndex = 2;
            this.fw_download_btn.Text = "시작";
            this.fw_download_btn.UseVisualStyleBackColor = true;
            this.fw_download_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(179, 139);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(98, 23);
            this.pb1.TabIndex = 4;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(179, 192);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(98, 23);
            this.pb2.TabIndex = 5;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(179, 245);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(98, 23);
            this.pb3.TabIndex = 6;
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(179, 410);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(98, 23);
            this.pb6.TabIndex = 9;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(179, 354);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(98, 23);
            this.pb5.TabIndex = 8;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(179, 298);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(98, 23);
            this.pb4.TabIndex = 7;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(70, 145);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(15, 14);
            this.cb1.TabIndex = 11;
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(70, 198);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(15, 14);
            this.cb2.TabIndex = 12;
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(70, 251);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(15, 14);
            this.cb3.TabIndex = 11;
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(70, 304);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(15, 14);
            this.cb4.TabIndex = 12;
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(70, 360);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(15, 14);
            this.cb5.TabIndex = 12;
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Location = new System.Drawing.Point(70, 416);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(15, 14);
            this.cb6.TabIndex = 11;
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(102, 142);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(71, 23);
            this.cbb1.TabIndex = 13;
            // 
            // cbb2
            // 
            this.cbb2.FormattingEnabled = true;
            this.cbb2.Location = new System.Drawing.Point(102, 195);
            this.cbb2.Name = "cbb2";
            this.cbb2.Size = new System.Drawing.Size(71, 23);
            this.cbb2.TabIndex = 13;
            // 
            // cbb3
            // 
            this.cbb3.FormattingEnabled = true;
            this.cbb3.Location = new System.Drawing.Point(102, 248);
            this.cbb3.Name = "cbb3";
            this.cbb3.Size = new System.Drawing.Size(71, 23);
            this.cbb3.TabIndex = 14;
            // 
            // cbb4
            // 
            this.cbb4.FormattingEnabled = true;
            this.cbb4.Location = new System.Drawing.Point(102, 301);
            this.cbb4.Name = "cbb4";
            this.cbb4.Size = new System.Drawing.Size(71, 23);
            this.cbb4.TabIndex = 13;
            // 
            // cbb5
            // 
            this.cbb5.FormattingEnabled = true;
            this.cbb5.Location = new System.Drawing.Point(102, 357);
            this.cbb5.Name = "cbb5";
            this.cbb5.Size = new System.Drawing.Size(71, 23);
            this.cbb5.TabIndex = 13;
            // 
            // cbb6
            // 
            this.cbb6.FormattingEnabled = true;
            this.cbb6.Location = new System.Drawing.Point(102, 413);
            this.cbb6.Name = "cbb6";
            this.cbb6.Size = new System.Drawing.Size(71, 23);
            this.cbb6.TabIndex = 14;
            // 
            // fw_load_btn
            // 
            this.fw_load_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.fw_load_btn.Location = new System.Drawing.Point(11, 188);
            this.fw_load_btn.Name = "fw_load_btn";
            this.fw_load_btn.Size = new System.Drawing.Size(192, 38);
            this.fw_load_btn.TabIndex = 15;
            this.fw_load_btn.Text = "펌웨어 로드";
            this.fw_load_btn.UseVisualStyleBackColor = true;
            this.fw_load_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 848);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1233, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Location = new System.Drawing.Point(70, 472);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(15, 14);
            this.cb7.TabIndex = 17;
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cbb7
            // 
            this.cbb7.FormattingEnabled = true;
            this.cbb7.Location = new System.Drawing.Point(102, 469);
            this.cbb7.Name = "cbb7";
            this.cbb7.Size = new System.Drawing.Size(71, 23);
            this.cbb7.TabIndex = 18;
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(179, 466);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(98, 23);
            this.pb7.TabIndex = 19;
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(179, 522);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(98, 23);
            this.pb8.TabIndex = 22;
            // 
            // cbb8
            // 
            this.cbb8.FormattingEnabled = true;
            this.cbb8.Location = new System.Drawing.Point(102, 522);
            this.cbb8.Name = "cbb8";
            this.cbb8.Size = new System.Drawing.Size(71, 23);
            this.cbb8.TabIndex = 21;
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Location = new System.Drawing.Point(70, 528);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(15, 14);
            this.cb8.TabIndex = 20;
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // pb10
            // 
            this.pb10.Location = new System.Drawing.Point(179, 634);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(98, 23);
            this.pb10.TabIndex = 28;
            // 
            // cbb10
            // 
            this.cbb10.FormattingEnabled = true;
            this.cbb10.Location = new System.Drawing.Point(102, 633);
            this.cbb10.Name = "cbb10";
            this.cbb10.Size = new System.Drawing.Size(71, 23);
            this.cbb10.TabIndex = 27;
            // 
            // cb10
            // 
            this.cb10.AutoSize = true;
            this.cb10.Location = new System.Drawing.Point(70, 635);
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size(15, 14);
            this.cb10.TabIndex = 26;
            this.cb10.UseVisualStyleBackColor = true;
            // 
            // pb9
            // 
            this.pb9.Location = new System.Drawing.Point(179, 578);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(98, 23);
            this.pb9.TabIndex = 25;
            // 
            // cbb9
            // 
            this.cbb9.FormattingEnabled = true;
            this.cbb9.Location = new System.Drawing.Point(104, 579);
            this.cbb9.Name = "cbb9";
            this.cbb9.Size = new System.Drawing.Size(71, 23);
            this.cbb9.TabIndex = 24;
            // 
            // cb9
            // 
            this.cb9.AutoSize = true;
            this.cb9.Location = new System.Drawing.Point(70, 582);
            this.cb9.Name = "cb9";
            this.cb9.Size = new System.Drawing.Size(15, 14);
            this.cb9.TabIndex = 23;
            this.cb9.UseVisualStyleBackColor = true;
            // 
            // pb12
            // 
            this.pb12.Location = new System.Drawing.Point(181, 746);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(98, 23);
            this.pb12.TabIndex = 34;
            // 
            // cbb12
            // 
            this.cbb12.FormattingEnabled = true;
            this.cbb12.Location = new System.Drawing.Point(107, 747);
            this.cbb12.Name = "cbb12";
            this.cbb12.Size = new System.Drawing.Size(71, 23);
            this.cbb12.TabIndex = 33;
            // 
            // cb12
            // 
            this.cb12.AutoSize = true;
            this.cb12.Location = new System.Drawing.Point(70, 751);
            this.cb12.Name = "cb12";
            this.cb12.Size = new System.Drawing.Size(15, 14);
            this.cb12.TabIndex = 32;
            this.cb12.UseVisualStyleBackColor = true;
            // 
            // pb11
            // 
            this.pb11.Location = new System.Drawing.Point(179, 690);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(98, 23);
            this.pb11.TabIndex = 31;
            // 
            // cbb11
            // 
            this.cbb11.FormattingEnabled = true;
            this.cbb11.Location = new System.Drawing.Point(104, 690);
            this.cbb11.Name = "cbb11";
            this.cbb11.Size = new System.Drawing.Size(71, 23);
            this.cbb11.TabIndex = 30;
            // 
            // cb11
            // 
            this.cb11.AutoSize = true;
            this.cb11.Location = new System.Drawing.Point(70, 696);
            this.cb11.Name = "cb11";
            this.cb11.Size = new System.Drawing.Size(15, 14);
            this.cb11.TabIndex = 29;
            this.cb11.UseVisualStyleBackColor = true;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb1.Location = new System.Drawing.Point(283, 140);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(63, 25);
            this.lb1.TabIndex = 35;
            this.lb1.Text = "Wait..";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb2.Location = new System.Drawing.Point(283, 193);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(63, 25);
            this.lb2.TabIndex = 36;
            this.lb2.Text = "Wait..";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb4.Location = new System.Drawing.Point(283, 299);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(63, 25);
            this.lb4.TabIndex = 38;
            this.lb4.Text = "Wait..";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb3.Location = new System.Drawing.Point(283, 246);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(63, 25);
            this.lb3.TabIndex = 37;
            this.lb3.Text = "Wait..";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb8.Location = new System.Drawing.Point(283, 524);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(63, 25);
            this.lb8.TabIndex = 42;
            this.lb8.Text = "Wait..";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb7.Location = new System.Drawing.Point(283, 467);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(63, 25);
            this.lb7.TabIndex = 41;
            this.lb7.Text = "Wait..";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb6.Location = new System.Drawing.Point(283, 411);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(63, 25);
            this.lb6.TabIndex = 40;
            this.lb6.Text = "Wait..";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb5.Location = new System.Drawing.Point(283, 355);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(63, 25);
            this.lb5.TabIndex = 39;
            this.lb5.Text = "Wait..";
            // 
            // lb12
            // 
            this.lb12.AutoSize = true;
            this.lb12.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb12.Location = new System.Drawing.Point(283, 744);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(63, 25);
            this.lb12.TabIndex = 46;
            this.lb12.Text = "Wait..";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb11.Location = new System.Drawing.Point(283, 688);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(63, 25);
            this.lb11.TabIndex = 45;
            this.lb11.Text = "Wait..";
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb10.Location = new System.Drawing.Point(282, 635);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(63, 25);
            this.lb10.TabIndex = 44;
            this.lb10.Text = "Wait..";
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb9.Location = new System.Drawing.Point(283, 578);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(63, 25);
            this.lb9.TabIndex = 43;
            this.lb9.Text = "Wait..";
            // 
            // zig_up_btn
            // 
            this.zig_up_btn.Location = new System.Drawing.Point(6, 22);
            this.zig_up_btn.Name = "zig_up_btn";
            this.zig_up_btn.Size = new System.Drawing.Size(85, 36);
            this.zig_up_btn.TabIndex = 48;
            this.zig_up_btn.Text = "Zig Up";
            this.zig_up_btn.UseVisualStyleBackColor = true;
            this.zig_up_btn.Click += new System.EventHandler(this.zig_up_button_Click);
            // 
            // zig_down_btn
            // 
            this.zig_down_btn.Location = new System.Drawing.Point(97, 22);
            this.zig_down_btn.Name = "zig_down_btn";
            this.zig_down_btn.Size = new System.Drawing.Size(84, 36);
            this.zig_down_btn.TabIndex = 49;
            this.zig_down_btn.Text = "Zig Down";
            this.zig_down_btn.UseVisualStyleBackColor = true;
            this.zig_down_btn.Click += new System.EventHandler(this.zig_down_button_Click);
            // 
            // isp_on_btn
            // 
            this.isp_on_btn.Location = new System.Drawing.Point(6, 469);
            this.isp_on_btn.Name = "isp_on_btn";
            this.isp_on_btn.Size = new System.Drawing.Size(85, 36);
            this.isp_on_btn.TabIndex = 50;
            this.isp_on_btn.Text = "ISP ON";
            this.isp_on_btn.UseVisualStyleBackColor = true;
            this.isp_on_btn.Click += new System.EventHandler(this.isp_on_button_Click);
            // 
            // device_reset_btn
            // 
            this.device_reset_btn.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.device_reset_btn.Location = new System.Drawing.Point(6, 427);
            this.device_reset_btn.Name = "device_reset_btn";
            this.device_reset_btn.Size = new System.Drawing.Size(85, 36);
            this.device_reset_btn.TabIndex = 51;
            this.device_reset_btn.Text = "Device Reset";
            this.device_reset_btn.UseVisualStyleBackColor = true;
            this.device_reset_btn.Click += new System.EventHandler(this.device_reset_button_Click);
            // 
            // isp_off_btn
            // 
            this.isp_off_btn.Location = new System.Drawing.Point(97, 469);
            this.isp_off_btn.Name = "isp_off_btn";
            this.isp_off_btn.Size = new System.Drawing.Size(84, 36);
            this.isp_off_btn.TabIndex = 52;
            this.isp_off_btn.Text = "ISP OFF";
            this.isp_off_btn.UseVisualStyleBackColor = true;
            this.isp_off_btn.Click += new System.EventHandler(this.isp_off_button_Click);
            // 
            // instantAiCtrl1
            // 
            this.instantAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantAiCtrl1._StateStream")));
            // 
            // instantAiCtrl2
            // 
            this.instantAiCtrl2._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantAiCtrl2._StateStream")));
            // 
            // instantDiCtrl1
            // 
            this.instantDiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDiCtrl1._StateStream")));
            // 
            // instantDoCtrl1
            // 
            this.instantDoCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDoCtrl1._StateStream")));
            // 
            // psw3036_serialPort
            // 
            this.psw3036_serialPort.BaudRate = 115200;
            this.psw3036_serialPort.PortName = "COM8";
            // 
            // psu_on_btn
            // 
            this.psu_on_btn.Location = new System.Drawing.Point(6, 224);
            this.psu_on_btn.Name = "psu_on_btn";
            this.psu_on_btn.Size = new System.Drawing.Size(85, 38);
            this.psu_on_btn.TabIndex = 55;
            this.psu_on_btn.Text = "PSU ON";
            this.psu_on_btn.UseVisualStyleBackColor = true;
            this.psu_on_btn.Click += new System.EventHandler(this.psu_on_button_Click);
            // 
            // psu_off_btn
            // 
            this.psu_off_btn.Location = new System.Drawing.Point(97, 224);
            this.psu_off_btn.Name = "psu_off_btn";
            this.psu_off_btn.Size = new System.Drawing.Size(84, 38);
            this.psu_off_btn.TabIndex = 56;
            this.psu_off_btn.Text = "PSU OFF";
            this.psu_off_btn.UseVisualStyleBackColor = true;
            this.psu_off_btn.Click += new System.EventHandler(this.psu_off_button_Click);
            // 
            // psu_set_v_textBox
            // 
            this.psu_set_v_textBox.Location = new System.Drawing.Point(105, 154);
            this.psu_set_v_textBox.Name = "psu_set_v_textBox";
            this.psu_set_v_textBox.Size = new System.Drawing.Size(74, 23);
            this.psu_set_v_textBox.TabIndex = 57;
            // 
            // psu_target_i_textBox
            // 
            this.psu_target_i_textBox.Location = new System.Drawing.Point(105, 130);
            this.psu_target_i_textBox.Name = "psu_target_i_textBox";
            this.psu_target_i_textBox.Size = new System.Drawing.Size(74, 23);
            this.psu_target_i_textBox.TabIndex = 58;
            this.psu_target_i_textBox.Text = "10.0";
            // 
            // psu_set_btn
            // 
            this.psu_set_btn.Location = new System.Drawing.Point(97, 181);
            this.psu_set_btn.Name = "psu_set_btn";
            this.psu_set_btn.Size = new System.Drawing.Size(84, 37);
            this.psu_set_btn.TabIndex = 59;
            this.psu_set_btn.Text = "PSU SET";
            this.psu_set_btn.UseVisualStyleBackColor = true;
            this.psu_set_btn.Click += new System.EventHandler(this.psu_set_button_Click);
            // 
            // psu_set_v_label
            // 
            this.psu_set_v_label.AutoSize = true;
            this.psu_set_v_label.Location = new System.Drawing.Point(12, 157);
            this.psu_set_v_label.Name = "psu_set_v_label";
            this.psu_set_v_label.Size = new System.Drawing.Size(76, 15);
            this.psu_set_v_label.TabIndex = 60;
            this.psu_set_v_label.Text = "PSU Set V : ";
            // 
            // psu_target_i_label
            // 
            this.psu_target_i_label.AutoSize = true;
            this.psu_target_i_label.Location = new System.Drawing.Point(12, 137);
            this.psu_target_i_label.Name = "psu_target_i_label";
            this.psu_target_i_label.Size = new System.Drawing.Size(92, 15);
            this.psu_target_i_label.TabIndex = 61;
            this.psu_target_i_label.Text = "PSU Target I : ";
            // 
            // dmm_v_label
            // 
            this.dmm_v_label.AutoSize = true;
            this.dmm_v_label.Location = new System.Drawing.Point(40, 357);
            this.dmm_v_label.Name = "dmm_v_label";
            this.dmm_v_label.Size = new System.Drawing.Size(63, 15);
            this.dmm_v_label.TabIndex = 62;
            this.dmm_v_label.Text = "DMM V : ";
            // 
            // dmm_v_textBox
            // 
            this.dmm_v_textBox.Location = new System.Drawing.Point(109, 353);
            this.dmm_v_textBox.Name = "dmm_v_textBox";
            this.dmm_v_textBox.Size = new System.Drawing.Size(74, 23);
            this.dmm_v_textBox.TabIndex = 63;
            // 
            // dev1_label
            // 
            this.dev1_label.AutoSize = true;
            this.dev1_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev1_label.Location = new System.Drawing.Point(14, 142);
            this.dev1_label.Name = "dev1_label";
            this.dev1_label.Size = new System.Drawing.Size(38, 30);
            this.dev1_label.TabIndex = 64;
            this.dev1_label.Text = "#1";
            // 
            // dev2_label
            // 
            this.dev2_label.AutoSize = true;
            this.dev2_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev2_label.Location = new System.Drawing.Point(14, 195);
            this.dev2_label.Name = "dev2_label";
            this.dev2_label.Size = new System.Drawing.Size(38, 30);
            this.dev2_label.TabIndex = 65;
            this.dev2_label.Text = "#2";
            // 
            // dev4_label
            // 
            this.dev4_label.AutoSize = true;
            this.dev4_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev4_label.Location = new System.Drawing.Point(14, 301);
            this.dev4_label.Name = "dev4_label";
            this.dev4_label.Size = new System.Drawing.Size(38, 30);
            this.dev4_label.TabIndex = 67;
            this.dev4_label.Text = "#4";
            // 
            // dev3_label
            // 
            this.dev3_label.AutoSize = true;
            this.dev3_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev3_label.Location = new System.Drawing.Point(14, 248);
            this.dev3_label.Name = "dev3_label";
            this.dev3_label.Size = new System.Drawing.Size(38, 30);
            this.dev3_label.TabIndex = 66;
            this.dev3_label.Text = "#3";
            // 
            // dev8_label
            // 
            this.dev8_label.AutoSize = true;
            this.dev8_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev8_label.Location = new System.Drawing.Point(10, 525);
            this.dev8_label.Name = "dev8_label";
            this.dev8_label.Size = new System.Drawing.Size(38, 30);
            this.dev8_label.TabIndex = 71;
            this.dev8_label.Text = "#8";
            // 
            // dev7_label
            // 
            this.dev7_label.AutoSize = true;
            this.dev7_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev7_label.Location = new System.Drawing.Point(14, 469);
            this.dev7_label.Name = "dev7_label";
            this.dev7_label.Size = new System.Drawing.Size(38, 30);
            this.dev7_label.TabIndex = 70;
            this.dev7_label.Text = "#7";
            // 
            // dev6_label
            // 
            this.dev6_label.AutoSize = true;
            this.dev6_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev6_label.Location = new System.Drawing.Point(14, 413);
            this.dev6_label.Name = "dev6_label";
            this.dev6_label.Size = new System.Drawing.Size(38, 30);
            this.dev6_label.TabIndex = 69;
            this.dev6_label.Text = "#6";
            // 
            // dev5_label
            // 
            this.dev5_label.AutoSize = true;
            this.dev5_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev5_label.Location = new System.Drawing.Point(14, 357);
            this.dev5_label.Name = "dev5_label";
            this.dev5_label.Size = new System.Drawing.Size(38, 30);
            this.dev5_label.TabIndex = 68;
            this.dev5_label.Text = "#5";
            // 
            // dev12_label
            // 
            this.dev12_label.AutoSize = true;
            this.dev12_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev12_label.Location = new System.Drawing.Point(6, 749);
            this.dev12_label.Name = "dev12_label";
            this.dev12_label.Size = new System.Drawing.Size(50, 30);
            this.dev12_label.TabIndex = 75;
            this.dev12_label.Text = "#12";
            // 
            // dev11_label
            // 
            this.dev11_label.AutoSize = true;
            this.dev11_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev11_label.Location = new System.Drawing.Point(6, 693);
            this.dev11_label.Name = "dev11_label";
            this.dev11_label.Size = new System.Drawing.Size(50, 30);
            this.dev11_label.TabIndex = 74;
            this.dev11_label.Text = "#11";
            // 
            // dev10_label
            // 
            this.dev10_label.AutoSize = true;
            this.dev10_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev10_label.Location = new System.Drawing.Point(6, 637);
            this.dev10_label.Name = "dev10_label";
            this.dev10_label.Size = new System.Drawing.Size(50, 30);
            this.dev10_label.TabIndex = 73;
            this.dev10_label.Text = "#10";
            // 
            // dev9_label
            // 
            this.dev9_label.AutoSize = true;
            this.dev9_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev9_label.Location = new System.Drawing.Point(9, 581);
            this.dev9_label.Name = "dev9_label";
            this.dev9_label.Size = new System.Drawing.Size(38, 30);
            this.dev9_label.TabIndex = 72;
            this.dev9_label.Text = "#9";
            // 
            // dev_pwr_all_on_btn
            // 
            this.dev_pwr_all_on_btn.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev_pwr_all_on_btn.Location = new System.Drawing.Point(6, 268);
            this.dev_pwr_all_on_btn.Name = "dev_pwr_all_on_btn";
            this.dev_pwr_all_on_btn.Size = new System.Drawing.Size(85, 36);
            this.dev_pwr_all_on_btn.TabIndex = 76;
            this.dev_pwr_all_on_btn.Text = "Dev Power All ON";
            this.dev_pwr_all_on_btn.UseVisualStyleBackColor = true;
            this.dev_pwr_all_on_btn.Click += new System.EventHandler(this.dev_pwr_all_on_button_Click);
            // 
            // dev_pwr_all_off_btn
            // 
            this.dev_pwr_all_off_btn.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev_pwr_all_off_btn.Location = new System.Drawing.Point(97, 268);
            this.dev_pwr_all_off_btn.Name = "dev_pwr_all_off_btn";
            this.dev_pwr_all_off_btn.Size = new System.Drawing.Size(85, 36);
            this.dev_pwr_all_off_btn.TabIndex = 77;
            this.dev_pwr_all_off_btn.Text = "Dev Power All OFF";
            this.dev_pwr_all_off_btn.UseVisualStyleBackColor = true;
            this.dev_pwr_all_off_btn.Click += new System.EventHandler(this.dev_pwr_all_off_button_Click);
            // 
            // dev1_set_i_tb
            // 
            this.dev1_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev1_set_i_tb.Location = new System.Drawing.Point(52, 44);
            this.dev1_set_i_tb.Name = "dev1_set_i_tb";
            this.dev1_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev1_set_i_tb.TabIndex = 78;
            this.dev1_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev2_set_i_tb
            // 
            this.dev2_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev2_set_i_tb.Location = new System.Drawing.Point(52, 71);
            this.dev2_set_i_tb.Name = "dev2_set_i_tb";
            this.dev2_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev2_set_i_tb.TabIndex = 79;
            this.dev2_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev4_set_i_tb
            // 
            this.dev4_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev4_set_i_tb.Location = new System.Drawing.Point(52, 128);
            this.dev4_set_i_tb.Name = "dev4_set_i_tb";
            this.dev4_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev4_set_i_tb.TabIndex = 81;
            this.dev4_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev3_set_i_tb
            // 
            this.dev3_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev3_set_i_tb.Location = new System.Drawing.Point(52, 99);
            this.dev3_set_i_tb.Name = "dev3_set_i_tb";
            this.dev3_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev3_set_i_tb.TabIndex = 80;
            this.dev3_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev8_set_i_tb
            // 
            this.dev8_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev8_set_i_tb.Location = new System.Drawing.Point(52, 237);
            this.dev8_set_i_tb.Name = "dev8_set_i_tb";
            this.dev8_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev8_set_i_tb.TabIndex = 85;
            this.dev8_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev7_set_i_tb
            // 
            this.dev7_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev7_set_i_tb.Location = new System.Drawing.Point(52, 209);
            this.dev7_set_i_tb.Name = "dev7_set_i_tb";
            this.dev7_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev7_set_i_tb.TabIndex = 84;
            this.dev7_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev6_set_i_tb
            // 
            this.dev6_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev6_set_i_tb.Location = new System.Drawing.Point(52, 182);
            this.dev6_set_i_tb.Name = "dev6_set_i_tb";
            this.dev6_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev6_set_i_tb.TabIndex = 83;
            this.dev6_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev5_set_i_tb
            // 
            this.dev5_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev5_set_i_tb.Location = new System.Drawing.Point(52, 155);
            this.dev5_set_i_tb.Name = "dev5_set_i_tb";
            this.dev5_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev5_set_i_tb.TabIndex = 82;
            this.dev5_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev12_set_i_tb
            // 
            this.dev12_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev12_set_i_tb.Location = new System.Drawing.Point(52, 345);
            this.dev12_set_i_tb.Name = "dev12_set_i_tb";
            this.dev12_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev12_set_i_tb.TabIndex = 89;
            this.dev12_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev11_set_i_tb
            // 
            this.dev11_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev11_set_i_tb.Location = new System.Drawing.Point(52, 318);
            this.dev11_set_i_tb.Name = "dev11_set_i_tb";
            this.dev11_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev11_set_i_tb.TabIndex = 88;
            this.dev11_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev10_set_i_tb
            // 
            this.dev10_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev10_set_i_tb.Location = new System.Drawing.Point(52, 291);
            this.dev10_set_i_tb.Name = "dev10_set_i_tb";
            this.dev10_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev10_set_i_tb.TabIndex = 87;
            this.dev10_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev9_set_i_tb
            // 
            this.dev9_set_i_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev9_set_i_tb.Location = new System.Drawing.Point(52, 264);
            this.dev9_set_i_tb.Name = "dev9_set_i_tb";
            this.dev9_set_i_tb.Size = new System.Drawing.Size(56, 21);
            this.dev9_set_i_tb.TabIndex = 86;
            this.dev9_set_i_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev12_ovp_v_tb
            // 
            this.dev12_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev12_ovp_v_tb.Location = new System.Drawing.Point(114, 345);
            this.dev12_ovp_v_tb.Name = "dev12_ovp_v_tb";
            this.dev12_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev12_ovp_v_tb.TabIndex = 101;
            this.dev12_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev11_ovp_v_tb
            // 
            this.dev11_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev11_ovp_v_tb.Location = new System.Drawing.Point(114, 318);
            this.dev11_ovp_v_tb.Name = "dev11_ovp_v_tb";
            this.dev11_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev11_ovp_v_tb.TabIndex = 100;
            this.dev11_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev10_ovp_v_tb
            // 
            this.dev10_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev10_ovp_v_tb.Location = new System.Drawing.Point(114, 291);
            this.dev10_ovp_v_tb.Name = "dev10_ovp_v_tb";
            this.dev10_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev10_ovp_v_tb.TabIndex = 99;
            this.dev10_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev9_ovp_v_tb
            // 
            this.dev9_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev9_ovp_v_tb.Location = new System.Drawing.Point(114, 264);
            this.dev9_ovp_v_tb.Name = "dev9_ovp_v_tb";
            this.dev9_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev9_ovp_v_tb.TabIndex = 98;
            this.dev9_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev8_ovp_v_tb
            // 
            this.dev8_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev8_ovp_v_tb.Location = new System.Drawing.Point(114, 237);
            this.dev8_ovp_v_tb.Name = "dev8_ovp_v_tb";
            this.dev8_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev8_ovp_v_tb.TabIndex = 97;
            this.dev8_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev7_ovp_v_tb
            // 
            this.dev7_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev7_ovp_v_tb.Location = new System.Drawing.Point(114, 209);
            this.dev7_ovp_v_tb.Name = "dev7_ovp_v_tb";
            this.dev7_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev7_ovp_v_tb.TabIndex = 96;
            this.dev7_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev6_ovp_v_tb
            // 
            this.dev6_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev6_ovp_v_tb.Location = new System.Drawing.Point(114, 182);
            this.dev6_ovp_v_tb.Name = "dev6_ovp_v_tb";
            this.dev6_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev6_ovp_v_tb.TabIndex = 95;
            this.dev6_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev5_ovp_v_tb
            // 
            this.dev5_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev5_ovp_v_tb.Location = new System.Drawing.Point(114, 155);
            this.dev5_ovp_v_tb.Name = "dev5_ovp_v_tb";
            this.dev5_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev5_ovp_v_tb.TabIndex = 94;
            this.dev5_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev4_ovp_v_tb
            // 
            this.dev4_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev4_ovp_v_tb.Location = new System.Drawing.Point(114, 128);
            this.dev4_ovp_v_tb.Name = "dev4_ovp_v_tb";
            this.dev4_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev4_ovp_v_tb.TabIndex = 93;
            this.dev4_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev3_ovp_v_tb
            // 
            this.dev3_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev3_ovp_v_tb.Location = new System.Drawing.Point(114, 99);
            this.dev3_ovp_v_tb.Name = "dev3_ovp_v_tb";
            this.dev3_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev3_ovp_v_tb.TabIndex = 92;
            this.dev3_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev2_ovp_v_tb
            // 
            this.dev2_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev2_ovp_v_tb.Location = new System.Drawing.Point(114, 71);
            this.dev2_ovp_v_tb.Name = "dev2_ovp_v_tb";
            this.dev2_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev2_ovp_v_tb.TabIndex = 91;
            this.dev2_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev1_ovp_v_tb
            // 
            this.dev1_ovp_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev1_ovp_v_tb.Location = new System.Drawing.Point(114, 44);
            this.dev1_ovp_v_tb.Name = "dev1_ovp_v_tb";
            this.dev1_ovp_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev1_ovp_v_tb.TabIndex = 90;
            this.dev1_ovp_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev12_2nd_v_tb
            // 
            this.dev12_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev12_2nd_v_tb.Location = new System.Drawing.Point(238, 345);
            this.dev12_2nd_v_tb.Name = "dev12_2nd_v_tb";
            this.dev12_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev12_2nd_v_tb.TabIndex = 125;
            this.dev12_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev11_2nd_v_tb
            // 
            this.dev11_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev11_2nd_v_tb.Location = new System.Drawing.Point(238, 318);
            this.dev11_2nd_v_tb.Name = "dev11_2nd_v_tb";
            this.dev11_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev11_2nd_v_tb.TabIndex = 124;
            this.dev11_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev10_2nd_v_tb
            // 
            this.dev10_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev10_2nd_v_tb.Location = new System.Drawing.Point(238, 291);
            this.dev10_2nd_v_tb.Name = "dev10_2nd_v_tb";
            this.dev10_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev10_2nd_v_tb.TabIndex = 123;
            this.dev10_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev9_2nd_v_tb
            // 
            this.dev9_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev9_2nd_v_tb.Location = new System.Drawing.Point(238, 264);
            this.dev9_2nd_v_tb.Name = "dev9_2nd_v_tb";
            this.dev9_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev9_2nd_v_tb.TabIndex = 122;
            this.dev9_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev8_2nd_v_tb
            // 
            this.dev8_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev8_2nd_v_tb.Location = new System.Drawing.Point(238, 237);
            this.dev8_2nd_v_tb.Name = "dev8_2nd_v_tb";
            this.dev8_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev8_2nd_v_tb.TabIndex = 121;
            this.dev8_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev7_2nd_v_tb
            // 
            this.dev7_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev7_2nd_v_tb.Location = new System.Drawing.Point(238, 209);
            this.dev7_2nd_v_tb.Name = "dev7_2nd_v_tb";
            this.dev7_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev7_2nd_v_tb.TabIndex = 120;
            this.dev7_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev6_2nd_v_tb
            // 
            this.dev6_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev6_2nd_v_tb.Location = new System.Drawing.Point(238, 182);
            this.dev6_2nd_v_tb.Name = "dev6_2nd_v_tb";
            this.dev6_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev6_2nd_v_tb.TabIndex = 119;
            this.dev6_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev5_2nd_v_tb
            // 
            this.dev5_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev5_2nd_v_tb.Location = new System.Drawing.Point(238, 155);
            this.dev5_2nd_v_tb.Name = "dev5_2nd_v_tb";
            this.dev5_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev5_2nd_v_tb.TabIndex = 118;
            this.dev5_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev4_2nd_v_tb
            // 
            this.dev4_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev4_2nd_v_tb.Location = new System.Drawing.Point(238, 128);
            this.dev4_2nd_v_tb.Name = "dev4_2nd_v_tb";
            this.dev4_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev4_2nd_v_tb.TabIndex = 117;
            this.dev4_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev3_2nd_v_tb
            // 
            this.dev3_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev3_2nd_v_tb.Location = new System.Drawing.Point(238, 99);
            this.dev3_2nd_v_tb.Name = "dev3_2nd_v_tb";
            this.dev3_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev3_2nd_v_tb.TabIndex = 116;
            this.dev3_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev2_2nd_v_tb
            // 
            this.dev2_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev2_2nd_v_tb.Location = new System.Drawing.Point(238, 71);
            this.dev2_2nd_v_tb.Name = "dev2_2nd_v_tb";
            this.dev2_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev2_2nd_v_tb.TabIndex = 115;
            this.dev2_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev1_2nd_v_tb
            // 
            this.dev1_2nd_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev1_2nd_v_tb.Location = new System.Drawing.Point(238, 44);
            this.dev1_2nd_v_tb.Name = "dev1_2nd_v_tb";
            this.dev1_2nd_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev1_2nd_v_tb.TabIndex = 114;
            this.dev1_2nd_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev12_1st_v_tb
            // 
            this.dev12_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev12_1st_v_tb.Location = new System.Drawing.Point(176, 345);
            this.dev12_1st_v_tb.Name = "dev12_1st_v_tb";
            this.dev12_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev12_1st_v_tb.TabIndex = 113;
            this.dev12_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev11_1st_v_tb
            // 
            this.dev11_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev11_1st_v_tb.Location = new System.Drawing.Point(176, 318);
            this.dev11_1st_v_tb.Name = "dev11_1st_v_tb";
            this.dev11_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev11_1st_v_tb.TabIndex = 112;
            this.dev11_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev10_1st_v_tb
            // 
            this.dev10_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev10_1st_v_tb.Location = new System.Drawing.Point(176, 291);
            this.dev10_1st_v_tb.Name = "dev10_1st_v_tb";
            this.dev10_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev10_1st_v_tb.TabIndex = 111;
            this.dev10_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev9_1st_v_tb
            // 
            this.dev9_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev9_1st_v_tb.Location = new System.Drawing.Point(176, 264);
            this.dev9_1st_v_tb.Name = "dev9_1st_v_tb";
            this.dev9_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev9_1st_v_tb.TabIndex = 110;
            this.dev9_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev8_1st_v_tb
            // 
            this.dev8_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev8_1st_v_tb.Location = new System.Drawing.Point(176, 237);
            this.dev8_1st_v_tb.Name = "dev8_1st_v_tb";
            this.dev8_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev8_1st_v_tb.TabIndex = 109;
            this.dev8_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev7_1st_v_tb
            // 
            this.dev7_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev7_1st_v_tb.Location = new System.Drawing.Point(176, 209);
            this.dev7_1st_v_tb.Name = "dev7_1st_v_tb";
            this.dev7_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev7_1st_v_tb.TabIndex = 108;
            this.dev7_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev6_1st_v_tb
            // 
            this.dev6_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev6_1st_v_tb.Location = new System.Drawing.Point(176, 182);
            this.dev6_1st_v_tb.Name = "dev6_1st_v_tb";
            this.dev6_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev6_1st_v_tb.TabIndex = 107;
            this.dev6_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev5_1st_v_tb
            // 
            this.dev5_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev5_1st_v_tb.Location = new System.Drawing.Point(176, 155);
            this.dev5_1st_v_tb.Name = "dev5_1st_v_tb";
            this.dev5_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev5_1st_v_tb.TabIndex = 106;
            this.dev5_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev4_1st_v_tb
            // 
            this.dev4_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev4_1st_v_tb.Location = new System.Drawing.Point(176, 128);
            this.dev4_1st_v_tb.Name = "dev4_1st_v_tb";
            this.dev4_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev4_1st_v_tb.TabIndex = 105;
            this.dev4_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev3_1st_v_tb
            // 
            this.dev3_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev3_1st_v_tb.Location = new System.Drawing.Point(176, 99);
            this.dev3_1st_v_tb.Name = "dev3_1st_v_tb";
            this.dev3_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev3_1st_v_tb.TabIndex = 104;
            this.dev3_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev2_1st_v_tb
            // 
            this.dev2_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev2_1st_v_tb.Location = new System.Drawing.Point(176, 71);
            this.dev2_1st_v_tb.Name = "dev2_1st_v_tb";
            this.dev2_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev2_1st_v_tb.TabIndex = 103;
            this.dev2_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev1_1st_v_tb
            // 
            this.dev1_1st_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev1_1st_v_tb.Location = new System.Drawing.Point(176, 44);
            this.dev1_1st_v_tb.Name = "dev1_1st_v_tb";
            this.dev1_1st_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev1_1st_v_tb.TabIndex = 102;
            this.dev1_1st_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev12_adc_v_tb
            // 
            this.dev12_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev12_adc_v_tb.Location = new System.Drawing.Point(300, 345);
            this.dev12_adc_v_tb.Name = "dev12_adc_v_tb";
            this.dev12_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev12_adc_v_tb.TabIndex = 137;
            this.dev12_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev11_adc_v_tb
            // 
            this.dev11_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev11_adc_v_tb.Location = new System.Drawing.Point(300, 318);
            this.dev11_adc_v_tb.Name = "dev11_adc_v_tb";
            this.dev11_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev11_adc_v_tb.TabIndex = 136;
            this.dev11_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev10_adc_v_tb
            // 
            this.dev10_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev10_adc_v_tb.Location = new System.Drawing.Point(300, 291);
            this.dev10_adc_v_tb.Name = "dev10_adc_v_tb";
            this.dev10_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev10_adc_v_tb.TabIndex = 135;
            this.dev10_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev9_adc_v_tb
            // 
            this.dev9_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev9_adc_v_tb.Location = new System.Drawing.Point(300, 264);
            this.dev9_adc_v_tb.Name = "dev9_adc_v_tb";
            this.dev9_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev9_adc_v_tb.TabIndex = 134;
            this.dev9_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev8_adc_v_tb
            // 
            this.dev8_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev8_adc_v_tb.Location = new System.Drawing.Point(300, 237);
            this.dev8_adc_v_tb.Name = "dev8_adc_v_tb";
            this.dev8_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev8_adc_v_tb.TabIndex = 133;
            this.dev8_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev7_adc_v_tb
            // 
            this.dev7_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev7_adc_v_tb.Location = new System.Drawing.Point(300, 209);
            this.dev7_adc_v_tb.Name = "dev7_adc_v_tb";
            this.dev7_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev7_adc_v_tb.TabIndex = 132;
            this.dev7_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev6_adc_v_tb
            // 
            this.dev6_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev6_adc_v_tb.Location = new System.Drawing.Point(300, 182);
            this.dev6_adc_v_tb.Name = "dev6_adc_v_tb";
            this.dev6_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev6_adc_v_tb.TabIndex = 131;
            this.dev6_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev5_adc_v_tb
            // 
            this.dev5_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev5_adc_v_tb.Location = new System.Drawing.Point(300, 155);
            this.dev5_adc_v_tb.Name = "dev5_adc_v_tb";
            this.dev5_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev5_adc_v_tb.TabIndex = 130;
            this.dev5_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev4_adc_v_tb
            // 
            this.dev4_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev4_adc_v_tb.Location = new System.Drawing.Point(300, 128);
            this.dev4_adc_v_tb.Name = "dev4_adc_v_tb";
            this.dev4_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev4_adc_v_tb.TabIndex = 129;
            this.dev4_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev3_adc_v_tb
            // 
            this.dev3_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev3_adc_v_tb.Location = new System.Drawing.Point(300, 99);
            this.dev3_adc_v_tb.Name = "dev3_adc_v_tb";
            this.dev3_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev3_adc_v_tb.TabIndex = 128;
            this.dev3_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev2_adc_v_tb
            // 
            this.dev2_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev2_adc_v_tb.Location = new System.Drawing.Point(300, 71);
            this.dev2_adc_v_tb.Name = "dev2_adc_v_tb";
            this.dev2_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev2_adc_v_tb.TabIndex = 127;
            this.dev2_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev1_adc_v_tb
            // 
            this.dev1_adc_v_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev1_adc_v_tb.Location = new System.Drawing.Point(300, 44);
            this.dev1_adc_v_tb.Name = "dev1_adc_v_tb";
            this.dev1_adc_v_tb.Size = new System.Drawing.Size(56, 21);
            this.dev1_adc_v_tb.TabIndex = 126;
            this.dev1_adc_v_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev_set_i_lb
            // 
            this.dev_set_i_lb.AutoSize = true;
            this.dev_set_i_lb.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev_set_i_lb.Location = new System.Drawing.Point(52, 24);
            this.dev_set_i_lb.Name = "dev_set_i_lb";
            this.dev_set_i_lb.Size = new System.Drawing.Size(61, 13);
            this.dev_set_i_lb.TabIndex = 140;
            this.dev_set_i_lb.Text = "DEV mA";
            // 
            // dev_ovp_v_lb
            // 
            this.dev_ovp_v_lb.AutoSize = true;
            this.dev_ovp_v_lb.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev_ovp_v_lb.Location = new System.Drawing.Point(116, 24);
            this.dev_ovp_v_lb.Name = "dev_ovp_v_lb";
            this.dev_ovp_v_lb.Size = new System.Drawing.Size(51, 13);
            this.dev_ovp_v_lb.TabIndex = 141;
            this.dev_ovp_v_lb.Text = "OVP V";
            // 
            // dev_1st_v_lb
            // 
            this.dev_1st_v_lb.AutoSize = true;
            this.dev_1st_v_lb.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev_1st_v_lb.Location = new System.Drawing.Point(176, 24);
            this.dev_1st_v_lb.Name = "dev_1st_v_lb";
            this.dev_1st_v_lb.Size = new System.Drawing.Size(42, 13);
            this.dev_1st_v_lb.TabIndex = 142;
            this.dev_1st_v_lb.Text = "1st V";
            // 
            // dev_2nd_v_lb
            // 
            this.dev_2nd_v_lb.AutoSize = true;
            this.dev_2nd_v_lb.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev_2nd_v_lb.Location = new System.Drawing.Point(238, 24);
            this.dev_2nd_v_lb.Name = "dev_2nd_v_lb";
            this.dev_2nd_v_lb.Size = new System.Drawing.Size(47, 13);
            this.dev_2nd_v_lb.TabIndex = 143;
            this.dev_2nd_v_lb.Text = "2nd V";
            // 
            // dev_adc_v_lb
            // 
            this.dev_adc_v_lb.AutoSize = true;
            this.dev_adc_v_lb.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev_adc_v_lb.Location = new System.Drawing.Point(300, 24);
            this.dev_adc_v_lb.Name = "dev_adc_v_lb";
            this.dev_adc_v_lb.Size = new System.Drawing.Size(50, 13);
            this.dev_adc_v_lb.TabIndex = 144;
            this.dev_adc_v_lb.Text = "ADC V";
            // 
            // dev1_ieee64_tb
            // 
            this.dev1_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev1_ieee64_tb.Location = new System.Drawing.Point(102, 165);
            this.dev1_ieee64_tb.Name = "dev1_ieee64_tb";
            this.dev1_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev1_ieee64_tb.TabIndex = 145;
            this.dev1_ieee64_tb.Text = "주소값 대기";
            this.dev1_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev2_ieee64_tb
            // 
            this.dev2_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev2_ieee64_tb.Location = new System.Drawing.Point(102, 217);
            this.dev2_ieee64_tb.Name = "dev2_ieee64_tb";
            this.dev2_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev2_ieee64_tb.TabIndex = 146;
            this.dev2_ieee64_tb.Text = "주소값 대기";
            this.dev2_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev3_ieee64_tb
            // 
            this.dev3_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev3_ieee64_tb.Location = new System.Drawing.Point(102, 270);
            this.dev3_ieee64_tb.Name = "dev3_ieee64_tb";
            this.dev3_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev3_ieee64_tb.TabIndex = 147;
            this.dev3_ieee64_tb.Text = "주소값 대기";
            this.dev3_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev4_ieee64_tb
            // 
            this.dev4_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev4_ieee64_tb.Location = new System.Drawing.Point(102, 327);
            this.dev4_ieee64_tb.Name = "dev4_ieee64_tb";
            this.dev4_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev4_ieee64_tb.TabIndex = 148;
            this.dev4_ieee64_tb.Text = "주소값 대기";
            this.dev4_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev5_ieee64_tb
            // 
            this.dev5_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev5_ieee64_tb.Location = new System.Drawing.Point(102, 383);
            this.dev5_ieee64_tb.Name = "dev5_ieee64_tb";
            this.dev5_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev5_ieee64_tb.TabIndex = 149;
            this.dev5_ieee64_tb.Text = "주소값 대기";
            this.dev5_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev6_ieee64_tb
            // 
            this.dev6_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev6_ieee64_tb.Location = new System.Drawing.Point(102, 439);
            this.dev6_ieee64_tb.Name = "dev6_ieee64_tb";
            this.dev6_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev6_ieee64_tb.TabIndex = 150;
            this.dev6_ieee64_tb.Text = "주소값 대기";
            this.dev6_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev7_ieee64_tb
            // 
            this.dev7_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev7_ieee64_tb.Location = new System.Drawing.Point(102, 495);
            this.dev7_ieee64_tb.Name = "dev7_ieee64_tb";
            this.dev7_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev7_ieee64_tb.TabIndex = 151;
            this.dev7_ieee64_tb.Text = "주소값 대기";
            this.dev7_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev8_ieee64_tb
            // 
            this.dev8_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev8_ieee64_tb.Location = new System.Drawing.Point(104, 549);
            this.dev8_ieee64_tb.Name = "dev8_ieee64_tb";
            this.dev8_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev8_ieee64_tb.TabIndex = 152;
            this.dev8_ieee64_tb.Text = "주소값 대기";
            this.dev8_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev9_ieee64_tb
            // 
            this.dev9_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev9_ieee64_tb.Location = new System.Drawing.Point(102, 606);
            this.dev9_ieee64_tb.Name = "dev9_ieee64_tb";
            this.dev9_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev9_ieee64_tb.TabIndex = 153;
            this.dev9_ieee64_tb.Text = "주소값 대기";
            this.dev9_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev10_ieee64_tb
            // 
            this.dev10_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev10_ieee64_tb.Location = new System.Drawing.Point(102, 661);
            this.dev10_ieee64_tb.Name = "dev10_ieee64_tb";
            this.dev10_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev10_ieee64_tb.TabIndex = 154;
            this.dev10_ieee64_tb.Text = "주소값 대기";
            this.dev10_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev11_ieee64_tb
            // 
            this.dev11_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev11_ieee64_tb.Location = new System.Drawing.Point(102, 718);
            this.dev11_ieee64_tb.Name = "dev11_ieee64_tb";
            this.dev11_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev11_ieee64_tb.TabIndex = 155;
            this.dev11_ieee64_tb.Text = "주소값 대기";
            this.dev11_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev12_ieee64_tb
            // 
            this.dev12_ieee64_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev12_ieee64_tb.Location = new System.Drawing.Point(107, 773);
            this.dev12_ieee64_tb.Name = "dev12_ieee64_tb";
            this.dev12_ieee64_tb.Size = new System.Drawing.Size(175, 25);
            this.dev12_ieee64_tb.TabIndex = 156;
            this.dev12_ieee64_tb.Text = "주소값 대기";
            this.dev12_ieee64_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // psw3036_port_cbb
            // 
            this.psw3036_port_cbb.FormattingEnabled = true;
            this.psw3036_port_cbb.Location = new System.Drawing.Point(20, 64);
            this.psw3036_port_cbb.Name = "psw3036_port_cbb";
            this.psw3036_port_cbb.Size = new System.Drawing.Size(71, 23);
            this.psw3036_port_cbb.TabIndex = 157;
            // 
            // dmm_port_cbb
            // 
            this.dmm_port_cbb.FormattingEnabled = true;
            this.dmm_port_cbb.Location = new System.Drawing.Point(20, 311);
            this.dmm_port_cbb.Name = "dmm_port_cbb";
            this.dmm_port_cbb.Size = new System.Drawing.Size(71, 23);
            this.dmm_port_cbb.TabIndex = 158;
            // 
            // dev1_ieee64_chk_rdbtn
            // 
            this.dev1_ieee64_chk_rdbtn.AutoSize = true;
            this.dev1_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev1_ieee64_chk_rdbtn.Location = new System.Drawing.Point(287, 171);
            this.dev1_ieee64_chk_rdbtn.Name = "dev1_ieee64_chk_rdbtn";
            this.dev1_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev1_ieee64_chk_rdbtn.TabIndex = 159;
            this.dev1_ieee64_chk_rdbtn.TabStop = true;
            this.dev1_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // fw_down_gb
            // 
            this.fw_down_gb.Controls.Add(this.dev_ieee64_set_btn);
            this.fw_down_gb.Controls.Add(this.dev_ieee64_set_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev_ieee64_set_tb);
            this.fw_down_gb.Controls.Add(this.dev12_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev11_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev10_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev9_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev8_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev7_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev6_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev5_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev4_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev3_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.dev2_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.fw_file_label);
            this.fw_down_gb.Controls.Add(this.pb1);
            this.fw_down_gb.Controls.Add(this.dev1_ieee64_chk_rdbtn);
            this.fw_down_gb.Controls.Add(this.cbb1);
            this.fw_down_gb.Controls.Add(this.dev12_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.cbb2);
            this.fw_down_gb.Controls.Add(this.dev11_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.cbb4);
            this.fw_down_gb.Controls.Add(this.dev10_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.cb4);
            this.fw_down_gb.Controls.Add(this.dev9_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.cbb3);
            this.fw_down_gb.Controls.Add(this.dev8_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.lb1);
            this.fw_down_gb.Controls.Add(this.dev7_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.cb5);
            this.fw_down_gb.Controls.Add(this.dev6_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.cbb5);
            this.fw_down_gb.Controls.Add(this.lb2);
            this.fw_down_gb.Controls.Add(this.cb3);
            this.fw_down_gb.Controls.Add(this.dev5_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.lb3);
            this.fw_down_gb.Controls.Add(this.dev4_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.cb2);
            this.fw_down_gb.Controls.Add(this.dev3_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.lb4);
            this.fw_down_gb.Controls.Add(this.dev2_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.cb1);
            this.fw_down_gb.Controls.Add(this.dev1_ieee64_tb);
            this.fw_down_gb.Controls.Add(this.lb5);
            this.fw_down_gb.Controls.Add(this.pb5);
            this.fw_down_gb.Controls.Add(this.pb4);
            this.fw_down_gb.Controls.Add(this.pb3);
            this.fw_down_gb.Controls.Add(this.pb2);
            this.fw_down_gb.Controls.Add(this.dev1_label);
            this.fw_down_gb.Controls.Add(this.dev2_label);
            this.fw_down_gb.Controls.Add(this.dev3_label);
            this.fw_down_gb.Controls.Add(this.dev4_label);
            this.fw_down_gb.Controls.Add(this.dev5_label);
            this.fw_down_gb.Controls.Add(this.dev6_label);
            this.fw_down_gb.Controls.Add(this.cb12);
            this.fw_down_gb.Controls.Add(this.cbb12);
            this.fw_down_gb.Controls.Add(this.pb11);
            this.fw_down_gb.Controls.Add(this.cb6);
            this.fw_down_gb.Controls.Add(this.pb12);
            this.fw_down_gb.Controls.Add(this.cbb11);
            this.fw_down_gb.Controls.Add(this.cb11);
            this.fw_down_gb.Controls.Add(this.pb10);
            this.fw_down_gb.Controls.Add(this.cbb6);
            this.fw_down_gb.Controls.Add(this.cbb10);
            this.fw_down_gb.Controls.Add(this.cb7);
            this.fw_down_gb.Controls.Add(this.cb10);
            this.fw_down_gb.Controls.Add(this.cbb7);
            this.fw_down_gb.Controls.Add(this.pb9);
            this.fw_down_gb.Controls.Add(this.pb6);
            this.fw_down_gb.Controls.Add(this.pb7);
            this.fw_down_gb.Controls.Add(this.lb6);
            this.fw_down_gb.Controls.Add(this.cbb9);
            this.fw_down_gb.Controls.Add(this.cb8);
            this.fw_down_gb.Controls.Add(this.lb7);
            this.fw_down_gb.Controls.Add(this.cb9);
            this.fw_down_gb.Controls.Add(this.cbb8);
            this.fw_down_gb.Controls.Add(this.lb8);
            this.fw_down_gb.Controls.Add(this.pb8);
            this.fw_down_gb.Controls.Add(this.lb9);
            this.fw_down_gb.Controls.Add(this.lb10);
            this.fw_down_gb.Controls.Add(this.lb11);
            this.fw_down_gb.Controls.Add(this.lb12);
            this.fw_down_gb.Controls.Add(this.dev7_label);
            this.fw_down_gb.Controls.Add(this.dev8_label);
            this.fw_down_gb.Controls.Add(this.dev9_label);
            this.fw_down_gb.Controls.Add(this.dev10_label);
            this.fw_down_gb.Controls.Add(this.dev11_label);
            this.fw_down_gb.Controls.Add(this.dev12_label);
            this.fw_down_gb.Controls.Add(this.fw_download_btn);
            this.fw_down_gb.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fw_down_gb.Location = new System.Drawing.Point(227, 34);
            this.fw_down_gb.Name = "fw_down_gb";
            this.fw_down_gb.Size = new System.Drawing.Size(352, 806);
            this.fw_down_gb.TabIndex = 160;
            this.fw_down_gb.TabStop = false;
            this.fw_down_gb.Text = "펌웨어 다운로드 및 IEEE64 주소 입력";
            // 
            // dev_ieee64_set_btn
            // 
            this.dev_ieee64_set_btn.Location = new System.Drawing.Point(18, 104);
            this.dev_ieee64_set_btn.Name = "dev_ieee64_set_btn";
            this.dev_ieee64_set_btn.Size = new System.Drawing.Size(78, 25);
            this.dev_ieee64_set_btn.TabIndex = 173;
            this.dev_ieee64_set_btn.Text = "Set";
            this.dev_ieee64_set_btn.UseVisualStyleBackColor = true;
            this.dev_ieee64_set_btn.Click += new System.EventHandler(this.dev_ieee64_set_btn_Click);
            // 
            // dev_ieee64_set_rdbtn
            // 
            this.dev_ieee64_set_rdbtn.AutoSize = true;
            this.dev_ieee64_set_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev_ieee64_set_rdbtn.Location = new System.Drawing.Point(288, 110);
            this.dev_ieee64_set_rdbtn.Name = "dev_ieee64_set_rdbtn";
            this.dev_ieee64_set_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev_ieee64_set_rdbtn.TabIndex = 172;
            this.dev_ieee64_set_rdbtn.TabStop = true;
            this.dev_ieee64_set_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev_ieee64_set_tb
            // 
            this.dev_ieee64_set_tb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev_ieee64_set_tb.Location = new System.Drawing.Point(102, 104);
            this.dev_ieee64_set_tb.Name = "dev_ieee64_set_tb";
            this.dev_ieee64_set_tb.Size = new System.Drawing.Size(175, 25);
            this.dev_ieee64_set_tb.TabIndex = 171;
            this.dev_ieee64_set_tb.Text = "00 15 51 00 00 00 00 01";
            this.dev_ieee64_set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev12_ieee64_chk_rdbtn
            // 
            this.dev12_ieee64_chk_rdbtn.AutoSize = true;
            this.dev12_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev12_ieee64_chk_rdbtn.Location = new System.Drawing.Point(288, 781);
            this.dev12_ieee64_chk_rdbtn.Name = "dev12_ieee64_chk_rdbtn";
            this.dev12_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev12_ieee64_chk_rdbtn.TabIndex = 170;
            this.dev12_ieee64_chk_rdbtn.TabStop = true;
            this.dev12_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev11_ieee64_chk_rdbtn
            // 
            this.dev11_ieee64_chk_rdbtn.AutoSize = true;
            this.dev11_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev11_ieee64_chk_rdbtn.Location = new System.Drawing.Point(288, 725);
            this.dev11_ieee64_chk_rdbtn.Name = "dev11_ieee64_chk_rdbtn";
            this.dev11_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev11_ieee64_chk_rdbtn.TabIndex = 169;
            this.dev11_ieee64_chk_rdbtn.TabStop = true;
            this.dev11_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev10_ieee64_chk_rdbtn
            // 
            this.dev10_ieee64_chk_rdbtn.AutoSize = true;
            this.dev10_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev10_ieee64_chk_rdbtn.Location = new System.Drawing.Point(288, 666);
            this.dev10_ieee64_chk_rdbtn.Name = "dev10_ieee64_chk_rdbtn";
            this.dev10_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev10_ieee64_chk_rdbtn.TabIndex = 168;
            this.dev10_ieee64_chk_rdbtn.TabStop = true;
            this.dev10_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev9_ieee64_chk_rdbtn
            // 
            this.dev9_ieee64_chk_rdbtn.AutoSize = true;
            this.dev9_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev9_ieee64_chk_rdbtn.Location = new System.Drawing.Point(288, 610);
            this.dev9_ieee64_chk_rdbtn.Name = "dev9_ieee64_chk_rdbtn";
            this.dev9_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev9_ieee64_chk_rdbtn.TabIndex = 167;
            this.dev9_ieee64_chk_rdbtn.TabStop = true;
            this.dev9_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev8_ieee64_chk_rdbtn
            // 
            this.dev8_ieee64_chk_rdbtn.AutoSize = true;
            this.dev8_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev8_ieee64_chk_rdbtn.Location = new System.Drawing.Point(288, 553);
            this.dev8_ieee64_chk_rdbtn.Name = "dev8_ieee64_chk_rdbtn";
            this.dev8_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev8_ieee64_chk_rdbtn.TabIndex = 166;
            this.dev8_ieee64_chk_rdbtn.TabStop = true;
            this.dev8_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev7_ieee64_chk_rdbtn
            // 
            this.dev7_ieee64_chk_rdbtn.AutoSize = true;
            this.dev7_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev7_ieee64_chk_rdbtn.Location = new System.Drawing.Point(287, 503);
            this.dev7_ieee64_chk_rdbtn.Name = "dev7_ieee64_chk_rdbtn";
            this.dev7_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev7_ieee64_chk_rdbtn.TabIndex = 165;
            this.dev7_ieee64_chk_rdbtn.TabStop = true;
            this.dev7_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev6_ieee64_chk_rdbtn
            // 
            this.dev6_ieee64_chk_rdbtn.AutoSize = true;
            this.dev6_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev6_ieee64_chk_rdbtn.Location = new System.Drawing.Point(287, 442);
            this.dev6_ieee64_chk_rdbtn.Name = "dev6_ieee64_chk_rdbtn";
            this.dev6_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev6_ieee64_chk_rdbtn.TabIndex = 164;
            this.dev6_ieee64_chk_rdbtn.TabStop = true;
            this.dev6_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev5_ieee64_chk_rdbtn
            // 
            this.dev5_ieee64_chk_rdbtn.AutoSize = true;
            this.dev5_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev5_ieee64_chk_rdbtn.Location = new System.Drawing.Point(287, 386);
            this.dev5_ieee64_chk_rdbtn.Name = "dev5_ieee64_chk_rdbtn";
            this.dev5_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev5_ieee64_chk_rdbtn.TabIndex = 163;
            this.dev5_ieee64_chk_rdbtn.TabStop = true;
            this.dev5_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev4_ieee64_chk_rdbtn
            // 
            this.dev4_ieee64_chk_rdbtn.AutoSize = true;
            this.dev4_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev4_ieee64_chk_rdbtn.Location = new System.Drawing.Point(287, 330);
            this.dev4_ieee64_chk_rdbtn.Name = "dev4_ieee64_chk_rdbtn";
            this.dev4_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev4_ieee64_chk_rdbtn.TabIndex = 162;
            this.dev4_ieee64_chk_rdbtn.TabStop = true;
            this.dev4_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev3_ieee64_chk_rdbtn
            // 
            this.dev3_ieee64_chk_rdbtn.AutoSize = true;
            this.dev3_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev3_ieee64_chk_rdbtn.Location = new System.Drawing.Point(287, 277);
            this.dev3_ieee64_chk_rdbtn.Name = "dev3_ieee64_chk_rdbtn";
            this.dev3_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev3_ieee64_chk_rdbtn.TabIndex = 161;
            this.dev3_ieee64_chk_rdbtn.TabStop = true;
            this.dev3_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // dev2_ieee64_chk_rdbtn
            // 
            this.dev2_ieee64_chk_rdbtn.AutoSize = true;
            this.dev2_ieee64_chk_rdbtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev2_ieee64_chk_rdbtn.Location = new System.Drawing.Point(287, 224);
            this.dev2_ieee64_chk_rdbtn.Name = "dev2_ieee64_chk_rdbtn";
            this.dev2_ieee64_chk_rdbtn.Size = new System.Drawing.Size(14, 13);
            this.dev2_ieee64_chk_rdbtn.TabIndex = 160;
            this.dev2_ieee64_chk_rdbtn.TabStop = true;
            this.dev2_ieee64_chk_rdbtn.UseVisualStyleBackColor = true;
            // 
            // fw_file_label
            // 
            this.fw_file_label.AutoSize = true;
            this.fw_file_label.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fw_file_label.Location = new System.Drawing.Point(24, 75);
            this.fw_file_label.Name = "fw_file_label";
            this.fw_file_label.Size = new System.Drawing.Size(122, 17);
            this.fw_file_label.TabIndex = 54;
            this.fw_file_label.Text = "펌웨어 파일 이름 : ";
            // 
            // dev_2V_mode_btn
            // 
            this.dev_2V_mode_btn.BackColor = System.Drawing.SystemColors.Control;
            this.dev_2V_mode_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.dev_2V_mode_btn.Location = new System.Drawing.Point(6, 99);
            this.dev_2V_mode_btn.Name = "dev_2V_mode_btn";
            this.dev_2V_mode_btn.Size = new System.Drawing.Size(63, 44);
            this.dev_2V_mode_btn.TabIndex = 161;
            this.dev_2V_mode_btn.Text = "2V";
            this.dev_2V_mode_btn.UseVisualStyleBackColor = false;
            this.dev_2V_mode_btn.Click += new System.EventHandler(this.dev_2V_mode_btn_Click);
            // 
            // dev_6V_mode_btn
            // 
            this.dev_6V_mode_btn.BackColor = System.Drawing.SystemColors.Control;
            this.dev_6V_mode_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.dev_6V_mode_btn.Location = new System.Drawing.Point(75, 99);
            this.dev_6V_mode_btn.Name = "dev_6V_mode_btn";
            this.dev_6V_mode_btn.Size = new System.Drawing.Size(63, 44);
            this.dev_6V_mode_btn.TabIndex = 162;
            this.dev_6V_mode_btn.Text = "6V";
            this.dev_6V_mode_btn.UseVisualStyleBackColor = false;
            this.dev_6V_mode_btn.Click += new System.EventHandler(this.dev_6V_mode_btn_Click);
            // 
            // dev_12V_mode_btn
            // 
            this.dev_12V_mode_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.dev_12V_mode_btn.Location = new System.Drawing.Point(144, 99);
            this.dev_12V_mode_btn.Name = "dev_12V_mode_btn";
            this.dev_12V_mode_btn.Size = new System.Drawing.Size(63, 44);
            this.dev_12V_mode_btn.TabIndex = 163;
            this.dev_12V_mode_btn.Text = "12V";
            this.dev_12V_mode_btn.UseVisualStyleBackColor = true;
            this.dev_12V_mode_btn.Click += new System.EventHandler(this.dev_12V_mode_btn_Click);
            // 
            // config_file_label
            // 
            this.config_file_label.AutoSize = true;
            this.config_file_label.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.config_file_label.Location = new System.Drawing.Point(11, 554);
            this.config_file_label.Name = "config_file_label";
            this.config_file_label.Size = new System.Drawing.Size(142, 13);
            this.config_file_label.TabIndex = 164;
            this.config_file_label.Text = "Config File Name : ";
            // 
            // config_save_btn
            // 
            this.config_save_btn.Location = new System.Drawing.Point(96, 511);
            this.config_save_btn.Name = "config_save_btn";
            this.config_save_btn.Size = new System.Drawing.Size(85, 36);
            this.config_save_btn.TabIndex = 166;
            this.config_save_btn.Text = "Config Save";
            this.config_save_btn.UseVisualStyleBackColor = true;
            this.config_save_btn.Click += new System.EventHandler(this.config_save_btn_Click);
            // 
            // config_load_btn
            // 
            this.config_load_btn.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.config_load_btn.Location = new System.Drawing.Point(8, 511);
            this.config_load_btn.Name = "config_load_btn";
            this.config_load_btn.Size = new System.Drawing.Size(83, 36);
            this.config_load_btn.TabIndex = 165;
            this.config_load_btn.Text = "Config Load";
            this.config_load_btn.UseVisualStyleBackColor = true;
            this.config_load_btn.Click += new System.EventHandler(this.config_load_btn_Click);
            // 
            // psu_connect_btn
            // 
            this.psu_connect_btn.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.psu_connect_btn.Location = new System.Drawing.Point(97, 64);
            this.psu_connect_btn.Name = "psu_connect_btn";
            this.psu_connect_btn.Size = new System.Drawing.Size(84, 37);
            this.psu_connect_btn.TabIndex = 167;
            this.psu_connect_btn.Text = "PSU Connect";
            this.psu_connect_btn.UseVisualStyleBackColor = true;
            this.psu_connect_btn.Click += new System.EventHandler(this.psu_connect_button_Click);
            // 
            // dmm_connect_btn
            // 
            this.dmm_connect_btn.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dmm_connect_btn.Location = new System.Drawing.Point(99, 310);
            this.dmm_connect_btn.Name = "dmm_connect_btn";
            this.dmm_connect_btn.Size = new System.Drawing.Size(84, 37);
            this.dmm_connect_btn.TabIndex = 168;
            this.dmm_connect_btn.Text = "DMM Connect";
            this.dmm_connect_btn.UseVisualStyleBackColor = true;
            this.dmm_connect_btn.Click += new System.EventHandler(this.DMM_connect_button_Click);
            // 
            // dmm_serialPort
            // 
            this.dmm_serialPort.BaudRate = 115200;
            this.dmm_serialPort.PortName = "COM7";
            // 
            // devchk_cbb
            // 
            this.devchk_cbb.FormattingEnabled = true;
            this.devchk_cbb.Location = new System.Drawing.Point(20, 384);
            this.devchk_cbb.Name = "devchk_cbb";
            this.devchk_cbb.Size = new System.Drawing.Size(71, 23);
            this.devchk_cbb.TabIndex = 169;
            // 
            // devchk_connect_btn
            // 
            this.devchk_connect_btn.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.devchk_connect_btn.Location = new System.Drawing.Point(99, 382);
            this.devchk_connect_btn.Name = "devchk_connect_btn";
            this.devchk_connect_btn.Size = new System.Drawing.Size(84, 36);
            this.devchk_connect_btn.TabIndex = 170;
            this.devchk_connect_btn.Text = "DevChecker Connect";
            this.devchk_connect_btn.UseVisualStyleBackColor = true;
            this.devchk_connect_btn.Click += new System.EventHandler(this.devchk_connect_button_Click);
            // 
            // psu_target_v_label
            // 
            this.psu_target_v_label.AutoSize = true;
            this.psu_target_v_label.Location = new System.Drawing.Point(12, 115);
            this.psu_target_v_label.Name = "psu_target_v_label";
            this.psu_target_v_label.Size = new System.Drawing.Size(96, 15);
            this.psu_target_v_label.TabIndex = 172;
            this.psu_target_v_label.Text = "PSU Target V : ";
            // 
            // psu_target_v_textBox
            // 
            this.psu_target_v_textBox.Location = new System.Drawing.Point(105, 107);
            this.psu_target_v_textBox.Name = "psu_target_v_textBox";
            this.psu_target_v_textBox.Size = new System.Drawing.Size(74, 23);
            this.psu_target_v_textBox.TabIndex = 171;
            this.psu_target_v_textBox.Text = "2.0";
            // 
            // devchk_serialPort
            // 
            this.devchk_serialPort.BaudRate = 115200;
            this.devchk_serialPort.PortName = "9";
            this.devchk_serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.devchk_serialPort_DataReceived);
            // 
            // daq_adc_gb
            // 
            this.daq_adc_gb.Controls.Add(this.label15);
            this.daq_adc_gb.Controls.Add(this.label14);
            this.daq_adc_gb.Controls.Add(this.label13);
            this.daq_adc_gb.Controls.Add(this.label12);
            this.daq_adc_gb.Controls.Add(this.label11);
            this.daq_adc_gb.Controls.Add(this.label10);
            this.daq_adc_gb.Controls.Add(this.label9);
            this.daq_adc_gb.Controls.Add(this.label8);
            this.daq_adc_gb.Controls.Add(this.label7);
            this.daq_adc_gb.Controls.Add(this.label6);
            this.daq_adc_gb.Controls.Add(this.label5);
            this.daq_adc_gb.Controls.Add(this.label3);
            this.daq_adc_gb.Controls.Add(this.dev1_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev2_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev3_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev4_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev5_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev6_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev7_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev8_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev9_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev10_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev11_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev12_set_i_tb);
            this.daq_adc_gb.Controls.Add(this.dev1_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev2_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev3_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev4_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev5_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.label1);
            this.daq_adc_gb.Controls.Add(this.dev_adc_v_lb);
            this.daq_adc_gb.Controls.Add(this.dev6_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev_2nd_v_lb);
            this.daq_adc_gb.Controls.Add(this.dev7_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev_1st_v_lb);
            this.daq_adc_gb.Controls.Add(this.dev8_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev_ovp_v_lb);
            this.daq_adc_gb.Controls.Add(this.dev9_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev_set_i_lb);
            this.daq_adc_gb.Controls.Add(this.dev10_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev11_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev12_ovp_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev12_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev12_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev1_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev11_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev11_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev2_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev10_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev10_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev3_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev9_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev9_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev4_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev8_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev8_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev5_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev7_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev7_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev6_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev6_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev6_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev7_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev5_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev5_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev8_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev4_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev4_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev9_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev3_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev3_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev10_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev2_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev2_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev11_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev1_err_tb);
            this.daq_adc_gb.Controls.Add(this.dev1_adc_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev12_1st_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev12_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev1_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev11_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev2_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev10_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev3_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev9_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev4_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev8_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev5_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev7_2nd_v_tb);
            this.daq_adc_gb.Controls.Add(this.dev6_2nd_v_tb);
            this.daq_adc_gb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.daq_adc_gb.Location = new System.Drawing.Point(792, 458);
            this.daq_adc_gb.Name = "daq_adc_gb";
            this.daq_adc_gb.Size = new System.Drawing.Size(429, 382);
            this.daq_adc_gb.TabIndex = 174;
            this.daq_adc_gb.TabStop = false;
            this.daq_adc_gb.Text = "아날로그 보드 정보";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(6, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 21);
            this.label15.TabIndex = 182;
            this.label15.Text = "#12";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(6, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 21);
            this.label14.TabIndex = 181;
            this.label14.Text = "#11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(6, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 21);
            this.label13.TabIndex = 180;
            this.label13.Text = "#10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(6, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 21);
            this.label12.TabIndex = 179;
            this.label12.Text = "#9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(6, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 21);
            this.label11.TabIndex = 178;
            this.label11.Text = "#8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(6, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 21);
            this.label10.TabIndex = 177;
            this.label10.Text = "#7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(6, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 176;
            this.label9.Text = "#6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 21);
            this.label8.TabIndex = 175;
            this.label8.Text = "#5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 21);
            this.label7.TabIndex = 174;
            this.label7.Text = "#4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 21);
            this.label6.TabIndex = 173;
            this.label6.Text = "#3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 21);
            this.label5.TabIndex = 172;
            this.label5.Text = "#2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 171;
            this.label3.Text = "#1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(364, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 144;
            this.label1.Text = "Error";
            // 
            // dev12_err_tb
            // 
            this.dev12_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev12_err_tb.Location = new System.Drawing.Point(362, 345);
            this.dev12_err_tb.Name = "dev12_err_tb";
            this.dev12_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev12_err_tb.TabIndex = 137;
            this.dev12_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev11_err_tb
            // 
            this.dev11_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev11_err_tb.Location = new System.Drawing.Point(362, 318);
            this.dev11_err_tb.Name = "dev11_err_tb";
            this.dev11_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev11_err_tb.TabIndex = 136;
            this.dev11_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev10_err_tb
            // 
            this.dev10_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev10_err_tb.Location = new System.Drawing.Point(362, 291);
            this.dev10_err_tb.Name = "dev10_err_tb";
            this.dev10_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev10_err_tb.TabIndex = 135;
            this.dev10_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev9_err_tb
            // 
            this.dev9_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev9_err_tb.Location = new System.Drawing.Point(362, 264);
            this.dev9_err_tb.Name = "dev9_err_tb";
            this.dev9_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev9_err_tb.TabIndex = 134;
            this.dev9_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev8_err_tb
            // 
            this.dev8_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev8_err_tb.Location = new System.Drawing.Point(362, 237);
            this.dev8_err_tb.Name = "dev8_err_tb";
            this.dev8_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev8_err_tb.TabIndex = 133;
            this.dev8_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev7_err_tb
            // 
            this.dev7_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev7_err_tb.Location = new System.Drawing.Point(362, 209);
            this.dev7_err_tb.Name = "dev7_err_tb";
            this.dev7_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev7_err_tb.TabIndex = 132;
            this.dev7_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev6_err_tb
            // 
            this.dev6_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev6_err_tb.Location = new System.Drawing.Point(362, 182);
            this.dev6_err_tb.Name = "dev6_err_tb";
            this.dev6_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev6_err_tb.TabIndex = 131;
            this.dev6_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev5_err_tb
            // 
            this.dev5_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev5_err_tb.Location = new System.Drawing.Point(362, 155);
            this.dev5_err_tb.Name = "dev5_err_tb";
            this.dev5_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev5_err_tb.TabIndex = 130;
            this.dev5_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev4_err_tb
            // 
            this.dev4_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev4_err_tb.Location = new System.Drawing.Point(362, 128);
            this.dev4_err_tb.Name = "dev4_err_tb";
            this.dev4_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev4_err_tb.TabIndex = 129;
            this.dev4_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev3_err_tb
            // 
            this.dev3_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev3_err_tb.Location = new System.Drawing.Point(362, 99);
            this.dev3_err_tb.Name = "dev3_err_tb";
            this.dev3_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev3_err_tb.TabIndex = 128;
            this.dev3_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev2_err_tb
            // 
            this.dev2_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev2_err_tb.Location = new System.Drawing.Point(362, 71);
            this.dev2_err_tb.Name = "dev2_err_tb";
            this.dev2_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev2_err_tb.TabIndex = 127;
            this.dev2_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dev1_err_tb
            // 
            this.dev1_err_tb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dev1_err_tb.Location = new System.Drawing.Point(362, 44);
            this.dev1_err_tb.Name = "dev1_err_tb";
            this.dev1_err_tb.Size = new System.Drawing.Size(56, 21);
            this.dev1_err_tb.TabIndex = 126;
            this.dev1_err_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setting_gb
            // 
            this.setting_gb.Controls.Add(this.fw_down_mode_btn);
            this.setting_gb.Controls.Add(this.dev_auto_mode_btn);
            this.setting_gb.Controls.Add(this.op_stop_btn);
            this.setting_gb.Controls.Add(this.label4);
            this.setting_gb.Controls.Add(this.op_start_btn);
            this.setting_gb.Controls.Add(this.op_end_time_tb);
            this.setting_gb.Controls.Add(this.op_end_time_lb);
            this.setting_gb.Controls.Add(this.op_start_time_tb);
            this.setting_gb.Controls.Add(this.op_start_time_lb);
            this.setting_gb.Controls.Add(this.fw_version_tb);
            this.setting_gb.Controls.Add(this.fw_version_lb);
            this.setting_gb.Controls.Add(this.mode_lb);
            this.setting_gb.Controls.Add(this.worker_tb);
            this.setting_gb.Controls.Add(this.worker_lb);
            this.setting_gb.Controls.Add(this.dev_2V_mode_btn);
            this.setting_gb.Controls.Add(this.dev_6V_mode_btn);
            this.setting_gb.Controls.Add(this.dev_12V_mode_btn);
            this.setting_gb.Controls.Add(this.db_btn);
            this.setting_gb.Controls.Add(this.board_check_btn);
            this.setting_gb.Controls.Add(this.fw_load_btn);
            this.setting_gb.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.setting_gb.Location = new System.Drawing.Point(12, 34);
            this.setting_gb.Name = "setting_gb";
            this.setting_gb.Size = new System.Drawing.Size(209, 808);
            this.setting_gb.TabIndex = 199;
            this.setting_gb.TabStop = false;
            this.setting_gb.Text = "작업 설정";
            // 
            // op_stop_btn
            // 
            this.op_stop_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.op_stop_btn.Location = new System.Drawing.Point(11, 724);
            this.op_stop_btn.Name = "op_stop_btn";
            this.op_stop_btn.Size = new System.Drawing.Size(192, 73);
            this.op_stop_btn.TabIndex = 269;
            this.op_stop_btn.Text = "작업 중지";
            this.op_stop_btn.UseVisualStyleBackColor = true;
            this.op_stop_btn.Click += new System.EventHandler(this.op_stop_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 267;
            this.label4.Text = "작업선택";
            // 
            // op_start_btn
            // 
            this.op_start_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.op_start_btn.Location = new System.Drawing.Point(11, 650);
            this.op_start_btn.Name = "op_start_btn";
            this.op_start_btn.Size = new System.Drawing.Size(192, 73);
            this.op_start_btn.TabIndex = 266;
            this.op_start_btn.Text = "작업 시작";
            this.op_start_btn.UseVisualStyleBackColor = true;
            this.op_start_btn.Click += new System.EventHandler(this.op_start_btn_Click);
            // 
            // op_end_time_tb
            // 
            this.op_end_time_tb.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.op_end_time_tb.Location = new System.Drawing.Point(11, 619);
            this.op_end_time_tb.Name = "op_end_time_tb";
            this.op_end_time_tb.Size = new System.Drawing.Size(192, 30);
            this.op_end_time_tb.TabIndex = 265;
            this.op_end_time_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // op_end_time_lb
            // 
            this.op_end_time_lb.AutoSize = true;
            this.op_end_time_lb.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_end_time_lb.Location = new System.Drawing.Point(6, 585);
            this.op_end_time_lb.Name = "op_end_time_lb";
            this.op_end_time_lb.Size = new System.Drawing.Size(97, 30);
            this.op_end_time_lb.TabIndex = 264;
            this.op_end_time_lb.Text = "완료시간";
            // 
            // op_start_time_tb
            // 
            this.op_start_time_tb.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.op_start_time_tb.Location = new System.Drawing.Point(11, 555);
            this.op_start_time_tb.Name = "op_start_time_tb";
            this.op_start_time_tb.Size = new System.Drawing.Size(192, 30);
            this.op_start_time_tb.TabIndex = 263;
            this.op_start_time_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // op_start_time_lb
            // 
            this.op_start_time_lb.AutoSize = true;
            this.op_start_time_lb.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_start_time_lb.Location = new System.Drawing.Point(6, 522);
            this.op_start_time_lb.Name = "op_start_time_lb";
            this.op_start_time_lb.Size = new System.Drawing.Size(97, 30);
            this.op_start_time_lb.TabIndex = 262;
            this.op_start_time_lb.Text = "시작시간";
            // 
            // fw_version_tb
            // 
            this.fw_version_tb.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.fw_version_tb.Location = new System.Drawing.Point(11, 485);
            this.fw_version_tb.Name = "fw_version_tb";
            this.fw_version_tb.Size = new System.Drawing.Size(192, 35);
            this.fw_version_tb.TabIndex = 261;
            this.fw_version_tb.Text = "값을 넣으세요.";
            this.fw_version_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fw_version_lb
            // 
            this.fw_version_lb.AutoSize = true;
            this.fw_version_lb.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fw_version_lb.Location = new System.Drawing.Point(6, 448);
            this.fw_version_lb.Name = "fw_version_lb";
            this.fw_version_lb.Size = new System.Drawing.Size(152, 30);
            this.fw_version_lb.TabIndex = 260;
            this.fw_version_lb.Text = "펌웨어 버전 :  ";
            // 
            // mode_lb
            // 
            this.mode_lb.AutoSize = true;
            this.mode_lb.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_lb.Location = new System.Drawing.Point(6, 60);
            this.mode_lb.Name = "mode_lb";
            this.mode_lb.Size = new System.Drawing.Size(97, 30);
            this.mode_lb.TabIndex = 258;
            this.mode_lb.Text = "보드선택";
            // 
            // worker_tb
            // 
            this.worker_tb.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.worker_tb.Location = new System.Drawing.Point(112, 22);
            this.worker_tb.Name = "worker_tb";
            this.worker_tb.Size = new System.Drawing.Size(91, 35);
            this.worker_tb.TabIndex = 256;
            this.worker_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // worker_lb
            // 
            this.worker_lb.AutoSize = true;
            this.worker_lb.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worker_lb.Location = new System.Drawing.Point(6, 20);
            this.worker_lb.Name = "worker_lb";
            this.worker_lb.Size = new System.Drawing.Size(96, 30);
            this.worker_lb.TabIndex = 257;
            this.worker_lb.Text = "작업자 : ";
            // 
            // db_btn
            // 
            this.db_btn.Enabled = false;
            this.db_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.db_btn.Location = new System.Drawing.Point(11, 406);
            this.db_btn.Name = "db_btn";
            this.db_btn.Size = new System.Drawing.Size(192, 38);
            this.db_btn.TabIndex = 15;
            this.db_btn.Text = "DB 저장";
            this.db_btn.UseVisualStyleBackColor = true;
            this.db_btn.Click += new System.EventHandler(this.db_btn_Click);
            // 
            // board_check_btn
            // 
            this.board_check_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.board_check_btn.Location = new System.Drawing.Point(11, 350);
            this.board_check_btn.Name = "board_check_btn";
            this.board_check_btn.Size = new System.Drawing.Size(192, 38);
            this.board_check_btn.TabIndex = 15;
            this.board_check_btn.Text = "보드 체크";
            this.board_check_btn.UseVisualStyleBackColor = true;
            this.board_check_btn.Click += new System.EventHandler(this.board_check_btn_Click);
            // 
            // machine_setting_gb
            // 
            this.machine_setting_gb.Controls.Add(this.zig_up_btn);
            this.machine_setting_gb.Controls.Add(this.zig_down_btn);
            this.machine_setting_gb.Controls.Add(this.psw3036_port_cbb);
            this.machine_setting_gb.Controls.Add(this.psu_connect_btn);
            this.machine_setting_gb.Controls.Add(this.psu_target_v_label);
            this.machine_setting_gb.Controls.Add(this.psu_set_v_textBox);
            this.machine_setting_gb.Controls.Add(this.psu_target_i_textBox);
            this.machine_setting_gb.Controls.Add(this.psu_set_btn);
            this.machine_setting_gb.Controls.Add(this.config_file_label);
            this.machine_setting_gb.Controls.Add(this.config_save_btn);
            this.machine_setting_gb.Controls.Add(this.psu_set_v_label);
            this.machine_setting_gb.Controls.Add(this.config_load_btn);
            this.machine_setting_gb.Controls.Add(this.psu_target_i_label);
            this.machine_setting_gb.Controls.Add(this.psu_target_v_textBox);
            this.machine_setting_gb.Controls.Add(this.psu_on_btn);
            this.machine_setting_gb.Controls.Add(this.psu_off_btn);
            this.machine_setting_gb.Controls.Add(this.dmm_port_cbb);
            this.machine_setting_gb.Controls.Add(this.dmm_connect_btn);
            this.machine_setting_gb.Controls.Add(this.dmm_v_label);
            this.machine_setting_gb.Controls.Add(this.dmm_v_textBox);
            this.machine_setting_gb.Controls.Add(this.dev_pwr_all_on_btn);
            this.machine_setting_gb.Controls.Add(this.dev_pwr_all_off_btn);
            this.machine_setting_gb.Controls.Add(this.device_reset_btn);
            this.machine_setting_gb.Controls.Add(this.isp_on_btn);
            this.machine_setting_gb.Controls.Add(this.isp_off_btn);
            this.machine_setting_gb.Controls.Add(this.devchk_cbb);
            this.machine_setting_gb.Controls.Add(this.devchk_connect_btn);
            this.machine_setting_gb.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.machine_setting_gb.Location = new System.Drawing.Point(585, 242);
            this.machine_setting_gb.Name = "machine_setting_gb";
            this.machine_setting_gb.Size = new System.Drawing.Size(201, 598);
            this.machine_setting_gb.TabIndex = 253;
            this.machine_setting_gb.TabStop = false;
            this.machine_setting_gb.Text = "장비 제어";
            // 
            // op_status_lb
            // 
            this.op_status_lb.AutoSize = true;
            this.op_status_lb.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.op_status_lb.Location = new System.Drawing.Point(589, 77);
            this.op_status_lb.Name = "op_status_lb";
            this.op_status_lb.Size = new System.Drawing.Size(137, 54);
            this.op_status_lb.TabIndex = 258;
            this.op_status_lb.Text = "label1";
            this.op_status_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.psu_seg_ctl_lb);
            this.groupBox1.Controls.Add(this.dmm_seg_ctl_lb);
            this.groupBox1.Controls.Add(this.psu_seg_ctl);
            this.groupBox1.Controls.Add(this.dmm_seg_ctl);
            this.groupBox1.Location = new System.Drawing.Point(856, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 210);
            this.groupBox1.TabIndex = 259;
            this.groupBox1.TabStop = false;
            // 
            // psu_seg_ctl_lb
            // 
            this.psu_seg_ctl_lb.AutoSize = true;
            this.psu_seg_ctl_lb.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psu_seg_ctl_lb.Location = new System.Drawing.Point(2, 107);
            this.psu_seg_ctl_lb.Name = "psu_seg_ctl_lb";
            this.psu_seg_ctl_lb.Size = new System.Drawing.Size(75, 82);
            this.psu_seg_ctl_lb.TabIndex = 174;
            this.psu_seg_ctl_lb.Text = "PSU\r\nV :";
            // 
            // dmm_seg_ctl_lb
            // 
            this.dmm_seg_ctl_lb.AutoSize = true;
            this.dmm_seg_ctl_lb.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmm_seg_ctl_lb.Location = new System.Drawing.Point(0, 25);
            this.dmm_seg_ctl_lb.Name = "dmm_seg_ctl_lb";
            this.dmm_seg_ctl_lb.Size = new System.Drawing.Size(75, 82);
            this.dmm_seg_ctl_lb.TabIndex = 173;
            this.dmm_seg_ctl_lb.Text = "DMM\r\nV :";
            // 
            // psu_seg_ctl
            // 
            this.psu_seg_ctl.BackColor = System.Drawing.Color.Black;
            this.psu_seg_ctl.DigitColor = System.Drawing.Color.GreenYellow;
            this.psu_seg_ctl.DigitText = "88.888";
            this.psu_seg_ctl.Location = new System.Drawing.Point(99, 114);
            this.psu_seg_ctl.Name = "psu_seg_ctl";
            this.psu_seg_ctl.Size = new System.Drawing.Size(266, 75);
            this.psu_seg_ctl.TabIndex = 1;
            // 
            // dmm_seg_ctl
            // 
            this.dmm_seg_ctl.BackColor = System.Drawing.Color.Black;
            this.dmm_seg_ctl.DigitColor = System.Drawing.Color.GreenYellow;
            this.dmm_seg_ctl.DigitText = "88.888";
            this.dmm_seg_ctl.Location = new System.Drawing.Point(99, 32);
            this.dmm_seg_ctl.Name = "dmm_seg_ctl";
            this.dmm_seg_ctl.Size = new System.Drawing.Size(266, 75);
            this.dmm_seg_ctl.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.bd_chk_avr_ovp);
            this.groupBox2.Controls.Add(this.bd_chk_err_value_ovp);
            this.groupBox2.Controls.Add(this.bd_chk_dvdt_ovp);
            this.groupBox2.Controls.Add(this.bd_chk_avr_1st);
            this.groupBox2.Controls.Add(this.bd_chk_err_value_1st);
            this.groupBox2.Controls.Add(this.bd_chk_dvdt_1st);
            this.groupBox2.Controls.Add(this.bd_chk_avr_2nd);
            this.groupBox2.Controls.Add(this.bd_chk_err_value_2nd);
            this.groupBox2.Controls.Add(this.bd_chk_dvdt_2nd);
            this.groupBox2.Controls.Add(this.bd_chk_avr_adc);
            this.groupBox2.Controls.Add(this.bd_chk_err_value_adc);
            this.groupBox2.Controls.Add(this.bd_chk_dvdt_adc);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(792, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 150);
            this.groupBox2.TabIndex = 183;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "보드 체크 기준";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(7, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 19);
            this.label22.TabIndex = 174;
            this.label22.Text = "dv/dt";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(7, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 19);
            this.label24.TabIndex = 172;
            this.label24.Text = "errValue";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(7, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 19);
            this.label25.TabIndex = 171;
            this.label25.Text = "AVR";
            // 
            // bd_chk_avr_ovp
            // 
            this.bd_chk_avr_ovp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_avr_ovp.Location = new System.Drawing.Point(76, 45);
            this.bd_chk_avr_ovp.Name = "bd_chk_avr_ovp";
            this.bd_chk_avr_ovp.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_avr_ovp.TabIndex = 90;
            this.bd_chk_avr_ovp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_err_value_ovp
            // 
            this.bd_chk_err_value_ovp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_err_value_ovp.Location = new System.Drawing.Point(76, 72);
            this.bd_chk_err_value_ovp.Name = "bd_chk_err_value_ovp";
            this.bd_chk_err_value_ovp.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_err_value_ovp.TabIndex = 91;
            this.bd_chk_err_value_ovp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_dvdt_ovp
            // 
            this.bd_chk_dvdt_ovp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_dvdt_ovp.Location = new System.Drawing.Point(76, 100);
            this.bd_chk_dvdt_ovp.Name = "bd_chk_dvdt_ovp";
            this.bd_chk_dvdt_ovp.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_dvdt_ovp.TabIndex = 93;
            this.bd_chk_dvdt_ovp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_avr_1st
            // 
            this.bd_chk_avr_1st.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_avr_1st.Location = new System.Drawing.Point(138, 45);
            this.bd_chk_avr_1st.Name = "bd_chk_avr_1st";
            this.bd_chk_avr_1st.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_avr_1st.TabIndex = 102;
            this.bd_chk_avr_1st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_err_value_1st
            // 
            this.bd_chk_err_value_1st.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_err_value_1st.Location = new System.Drawing.Point(138, 72);
            this.bd_chk_err_value_1st.Name = "bd_chk_err_value_1st";
            this.bd_chk_err_value_1st.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_err_value_1st.TabIndex = 103;
            this.bd_chk_err_value_1st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_dvdt_1st
            // 
            this.bd_chk_dvdt_1st.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_dvdt_1st.Location = new System.Drawing.Point(138, 100);
            this.bd_chk_dvdt_1st.Name = "bd_chk_dvdt_1st";
            this.bd_chk_dvdt_1st.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_dvdt_1st.TabIndex = 105;
            this.bd_chk_dvdt_1st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_avr_2nd
            // 
            this.bd_chk_avr_2nd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_avr_2nd.Location = new System.Drawing.Point(200, 45);
            this.bd_chk_avr_2nd.Name = "bd_chk_avr_2nd";
            this.bd_chk_avr_2nd.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_avr_2nd.TabIndex = 114;
            this.bd_chk_avr_2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_err_value_2nd
            // 
            this.bd_chk_err_value_2nd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_err_value_2nd.Location = new System.Drawing.Point(200, 72);
            this.bd_chk_err_value_2nd.Name = "bd_chk_err_value_2nd";
            this.bd_chk_err_value_2nd.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_err_value_2nd.TabIndex = 115;
            this.bd_chk_err_value_2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_dvdt_2nd
            // 
            this.bd_chk_dvdt_2nd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_dvdt_2nd.Location = new System.Drawing.Point(200, 100);
            this.bd_chk_dvdt_2nd.Name = "bd_chk_dvdt_2nd";
            this.bd_chk_dvdt_2nd.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_dvdt_2nd.TabIndex = 117;
            this.bd_chk_dvdt_2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_avr_adc
            // 
            this.bd_chk_avr_adc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_avr_adc.Location = new System.Drawing.Point(262, 45);
            this.bd_chk_avr_adc.Name = "bd_chk_avr_adc";
            this.bd_chk_avr_adc.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_avr_adc.TabIndex = 126;
            this.bd_chk_avr_adc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_err_value_adc
            // 
            this.bd_chk_err_value_adc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_err_value_adc.Location = new System.Drawing.Point(262, 72);
            this.bd_chk_err_value_adc.Name = "bd_chk_err_value_adc";
            this.bd_chk_err_value_adc.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_err_value_adc.TabIndex = 127;
            this.bd_chk_err_value_adc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bd_chk_dvdt_adc
            // 
            this.bd_chk_dvdt_adc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bd_chk_dvdt_adc.Location = new System.Drawing.Point(262, 100);
            this.bd_chk_dvdt_adc.Name = "bd_chk_dvdt_adc";
            this.bd_chk_dvdt_adc.Size = new System.Drawing.Size(56, 21);
            this.bd_chk_dvdt_adc.TabIndex = 129;
            this.bd_chk_dvdt_adc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(134, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 142;
            this.label16.Text = "1st V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(74, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 141;
            this.label2.Text = "OVP V";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(196, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 143;
            this.label17.Text = "2nd V";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(258, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 144;
            this.label18.Text = "ADC V";
            // 
            // dev_auto_mode_btn
            // 
            this.dev_auto_mode_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.dev_auto_mode_btn.Location = new System.Drawing.Point(11, 243);
            this.dev_auto_mode_btn.Name = "dev_auto_mode_btn";
            this.dev_auto_mode_btn.Size = new System.Drawing.Size(192, 38);
            this.dev_auto_mode_btn.TabIndex = 270;
            this.dev_auto_mode_btn.Text = "자동 모드";
            this.dev_auto_mode_btn.UseVisualStyleBackColor = true;
            this.dev_auto_mode_btn.Click += new System.EventHandler(this.dev_auto_mode_btn_Click);
            // 
            // fw_down_mode_btn
            // 
            this.fw_down_mode_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.fw_down_mode_btn.Location = new System.Drawing.Point(11, 297);
            this.fw_down_mode_btn.Name = "fw_down_mode_btn";
            this.fw_down_mode_btn.Size = new System.Drawing.Size(192, 38);
            this.fw_down_mode_btn.TabIndex = 271;
            this.fw_down_mode_btn.Text = "펌웨어 다운";
            this.fw_down_mode_btn.UseVisualStyleBackColor = true;
            this.fw_down_mode_btn.Click += new System.EventHandler(this.fw_down_mode_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 870);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.op_status_lb);
            this.Controls.Add(this.machine_setting_gb);
            this.Controls.Add(this.setting_gb);
            this.Controls.Add(this.daq_adc_gb);
            this.Controls.Add(this.fw_down_gb);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BMS 자동화 시험 V1.0.0";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.fw_down_gb.ResumeLayout(false);
            this.fw_down_gb.PerformLayout();
            this.daq_adc_gb.ResumeLayout(false);
            this.daq_adc_gb.PerformLayout();
            this.setting_gb.ResumeLayout(false);
            this.setting_gb.PerformLayout();
            this.machine_setting_gb.ResumeLayout(false);
            this.machine_setting_gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button fw_download_btn;
		private System.Windows.Forms.ProgressBar pb1;
		private System.Windows.Forms.ProgressBar pb2;
		private System.Windows.Forms.ProgressBar pb3;
		private System.Windows.Forms.ProgressBar pb6;
		private System.Windows.Forms.ProgressBar pb5;
		private System.Windows.Forms.ProgressBar pb4;
		private System.Windows.Forms.CheckBox cb1;
		private System.Windows.Forms.CheckBox cb2;
		private System.Windows.Forms.CheckBox cb3;
		private System.Windows.Forms.CheckBox cb4;
		private System.Windows.Forms.CheckBox cb5;
		private System.Windows.Forms.CheckBox cb6;
		private System.Windows.Forms.ComboBox cbb1;
		private System.Windows.Forms.ComboBox cbb2;
		private System.Windows.Forms.ComboBox cbb3;
		private System.Windows.Forms.ComboBox cbb4;
		private System.Windows.Forms.ComboBox cbb5;
		private System.Windows.Forms.ComboBox cbb6;
		private System.Windows.Forms.Button fw_load_btn;
		private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.ComboBox cbb7;
        private System.Windows.Forms.ProgressBar pb7;
        private System.Windows.Forms.ProgressBar pb8;
        private System.Windows.Forms.ComboBox cbb8;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.ProgressBar pb10;
        private System.Windows.Forms.ComboBox cbb10;
        private System.Windows.Forms.CheckBox cb10;
        private System.Windows.Forms.ProgressBar pb9;
        private System.Windows.Forms.ComboBox cbb9;
        private System.Windows.Forms.CheckBox cb9;
        private System.Windows.Forms.ProgressBar pb12;
        private System.Windows.Forms.ComboBox cbb12;
        private System.Windows.Forms.CheckBox cb12;
        private System.Windows.Forms.ProgressBar pb11;
        private System.Windows.Forms.ComboBox cbb11;
        private System.Windows.Forms.CheckBox cb11;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Button zig_up_btn;
        private System.Windows.Forms.Button zig_down_btn;
        private System.Windows.Forms.Button isp_on_btn;
        private System.Windows.Forms.Button device_reset_btn;
        private System.Windows.Forms.Button isp_off_btn;
        private Automation.BDaq.InstantAiCtrl instantAiCtrl1;
        private Automation.BDaq.InstantAiCtrl instantAiCtrl2;
        private Automation.BDaq.InstantDiCtrl instantDiCtrl1;
        private Automation.BDaq.InstantDoCtrl instantDoCtrl1;
        private System.IO.Ports.SerialPort psw3036_serialPort;
        private System.Windows.Forms.Button psu_on_btn;
        private System.Windows.Forms.Button psu_off_btn;
        private System.Windows.Forms.TextBox psu_set_v_textBox;
        private System.Windows.Forms.TextBox psu_target_i_textBox;
        private System.Windows.Forms.Button psu_set_btn;
        private System.Windows.Forms.Label psu_set_v_label;
        private System.Windows.Forms.Label psu_target_i_label;
        private System.Windows.Forms.Label dmm_v_label;
        private System.Windows.Forms.TextBox dmm_v_textBox;
        private System.Windows.Forms.Label dev1_label;
        private System.Windows.Forms.Label dev2_label;
        private System.Windows.Forms.Label dev4_label;
        private System.Windows.Forms.Label dev3_label;
        private System.Windows.Forms.Label dev8_label;
        private System.Windows.Forms.Label dev7_label;
        private System.Windows.Forms.Label dev6_label;
        private System.Windows.Forms.Label dev5_label;
        private System.Windows.Forms.Label dev12_label;
        private System.Windows.Forms.Label dev11_label;
        private System.Windows.Forms.Label dev10_label;
        private System.Windows.Forms.Label dev9_label;
        private System.Windows.Forms.Button dev_pwr_all_on_btn;
        private System.Windows.Forms.Button dev_pwr_all_off_btn;
        private System.Windows.Forms.TextBox dev1_set_i_tb;
        private System.Windows.Forms.TextBox dev2_set_i_tb;
        private System.Windows.Forms.TextBox dev4_set_i_tb;
        private System.Windows.Forms.TextBox dev3_set_i_tb;
        private System.Windows.Forms.TextBox dev8_set_i_tb;
        private System.Windows.Forms.TextBox dev7_set_i_tb;
        private System.Windows.Forms.TextBox dev6_set_i_tb;
        private System.Windows.Forms.TextBox dev5_set_i_tb;
        private System.Windows.Forms.TextBox dev12_set_i_tb;
        private System.Windows.Forms.TextBox dev11_set_i_tb;
        private System.Windows.Forms.TextBox dev10_set_i_tb;
        private System.Windows.Forms.TextBox dev9_set_i_tb;
        private System.Windows.Forms.TextBox dev12_ovp_v_tb;
        private System.Windows.Forms.TextBox dev11_ovp_v_tb;
        private System.Windows.Forms.TextBox dev10_ovp_v_tb;
        private System.Windows.Forms.TextBox dev9_ovp_v_tb;
        private System.Windows.Forms.TextBox dev8_ovp_v_tb;
        private System.Windows.Forms.TextBox dev7_ovp_v_tb;
        private System.Windows.Forms.TextBox dev6_ovp_v_tb;
        private System.Windows.Forms.TextBox dev5_ovp_v_tb;
        private System.Windows.Forms.TextBox dev4_ovp_v_tb;
        private System.Windows.Forms.TextBox dev3_ovp_v_tb;
        private System.Windows.Forms.TextBox dev2_ovp_v_tb;
        private System.Windows.Forms.TextBox dev1_ovp_v_tb;
        private System.Windows.Forms.TextBox dev12_2nd_v_tb;
        private System.Windows.Forms.TextBox dev11_2nd_v_tb;
        private System.Windows.Forms.TextBox dev10_2nd_v_tb;
        private System.Windows.Forms.TextBox dev9_2nd_v_tb;
        private System.Windows.Forms.TextBox dev8_2nd_v_tb;
        private System.Windows.Forms.TextBox dev7_2nd_v_tb;
        private System.Windows.Forms.TextBox dev6_2nd_v_tb;
        private System.Windows.Forms.TextBox dev5_2nd_v_tb;
        private System.Windows.Forms.TextBox dev4_2nd_v_tb;
        private System.Windows.Forms.TextBox dev3_2nd_v_tb;
        private System.Windows.Forms.TextBox dev2_2nd_v_tb;
        private System.Windows.Forms.TextBox dev1_2nd_v_tb;
        private System.Windows.Forms.TextBox dev12_1st_v_tb;
        private System.Windows.Forms.TextBox dev11_1st_v_tb;
        private System.Windows.Forms.TextBox dev10_1st_v_tb;
        private System.Windows.Forms.TextBox dev9_1st_v_tb;
        private System.Windows.Forms.TextBox dev8_1st_v_tb;
        private System.Windows.Forms.TextBox dev7_1st_v_tb;
        private System.Windows.Forms.TextBox dev6_1st_v_tb;
        private System.Windows.Forms.TextBox dev5_1st_v_tb;
        private System.Windows.Forms.TextBox dev4_1st_v_tb;
        private System.Windows.Forms.TextBox dev3_1st_v_tb;
        private System.Windows.Forms.TextBox dev2_1st_v_tb;
        private System.Windows.Forms.TextBox dev1_1st_v_tb;
        private System.Windows.Forms.TextBox dev12_adc_v_tb;
        private System.Windows.Forms.TextBox dev11_adc_v_tb;
        private System.Windows.Forms.TextBox dev10_adc_v_tb;
        private System.Windows.Forms.TextBox dev9_adc_v_tb;
        private System.Windows.Forms.TextBox dev8_adc_v_tb;
        private System.Windows.Forms.TextBox dev7_adc_v_tb;
        private System.Windows.Forms.TextBox dev6_adc_v_tb;
        private System.Windows.Forms.TextBox dev5_adc_v_tb;
        private System.Windows.Forms.TextBox dev4_adc_v_tb;
        private System.Windows.Forms.TextBox dev3_adc_v_tb;
        private System.Windows.Forms.TextBox dev2_adc_v_tb;
        private System.Windows.Forms.TextBox dev1_adc_v_tb;
        private System.Windows.Forms.Label dev_set_i_lb;
        private System.Windows.Forms.Label dev_ovp_v_lb;
        private System.Windows.Forms.Label dev_1st_v_lb;
        private System.Windows.Forms.Label dev_2nd_v_lb;
        private System.Windows.Forms.Label dev_adc_v_lb;
        private System.Windows.Forms.TextBox dev1_ieee64_tb;
        private System.Windows.Forms.TextBox dev2_ieee64_tb;
        private System.Windows.Forms.TextBox dev3_ieee64_tb;
        private System.Windows.Forms.TextBox dev4_ieee64_tb;
        private System.Windows.Forms.TextBox dev5_ieee64_tb;
        private System.Windows.Forms.TextBox dev6_ieee64_tb;
        private System.Windows.Forms.TextBox dev7_ieee64_tb;
        private System.Windows.Forms.TextBox dev8_ieee64_tb;
        private System.Windows.Forms.TextBox dev9_ieee64_tb;
        private System.Windows.Forms.TextBox dev10_ieee64_tb;
        private System.Windows.Forms.TextBox dev11_ieee64_tb;
        private System.Windows.Forms.TextBox dev12_ieee64_tb;
        private System.Windows.Forms.ComboBox psw3036_port_cbb;
        private System.Windows.Forms.ComboBox dmm_port_cbb;
        private System.Windows.Forms.RadioButton dev1_ieee64_chk_rdbtn;
        private System.Windows.Forms.GroupBox fw_down_gb;
        private System.Windows.Forms.RadioButton dev12_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev11_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev10_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev9_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev8_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev7_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev6_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev5_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev4_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev3_ieee64_chk_rdbtn;
        private System.Windows.Forms.RadioButton dev2_ieee64_chk_rdbtn;
        private System.Windows.Forms.Button dev_2V_mode_btn;
        private System.Windows.Forms.Button dev_6V_mode_btn;
        private System.Windows.Forms.Button dev_12V_mode_btn;
        private System.Windows.Forms.Label config_file_label;
        private System.Windows.Forms.Button config_save_btn;
        private System.Windows.Forms.Button config_load_btn;
        private System.Windows.Forms.Button psu_connect_btn;
        private System.Windows.Forms.Button dmm_connect_btn;
        private System.IO.Ports.SerialPort dmm_serialPort;
        private System.Windows.Forms.ComboBox devchk_cbb;
        private System.Windows.Forms.Button devchk_connect_btn;
        private System.Windows.Forms.Label psu_target_v_label;
        private System.Windows.Forms.TextBox psu_target_v_textBox;
        private System.IO.Ports.SerialPort devchk_serialPort;
        private System.Windows.Forms.GroupBox daq_adc_gb;
        private System.Windows.Forms.GroupBox setting_gb;
        private System.Windows.Forms.GroupBox machine_setting_gb;
        private System.Windows.Forms.TextBox worker_tb;
        private System.Windows.Forms.Label worker_lb;
        private System.Windows.Forms.Label mode_lb;
        private System.Windows.Forms.TextBox fw_version_tb;
        private System.Windows.Forms.Label fw_version_lb;
        private System.Windows.Forms.Label fw_file_label;
        private System.Windows.Forms.TextBox op_end_time_tb;
        private System.Windows.Forms.Label op_end_time_lb;
        private System.Windows.Forms.TextBox op_start_time_tb;
        private System.Windows.Forms.Label op_start_time_lb;
        private System.Windows.Forms.Button op_start_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button op_stop_btn;
        private System.Windows.Forms.Label op_status_lb;
        private System.Windows.Forms.GroupBox groupBox1;
        private Owf.Controls.DigitalDisplayControl psu_seg_ctl;
        private Owf.Controls.DigitalDisplayControl dmm_seg_ctl;
        private System.Windows.Forms.Label psu_seg_ctl_lb;
        private System.Windows.Forms.Label dmm_seg_ctl_lb;
        private System.Windows.Forms.Button dev_ieee64_set_btn;
        private System.Windows.Forms.RadioButton dev_ieee64_set_rdbtn;
        private System.Windows.Forms.TextBox dev_ieee64_set_tb;
        private System.Windows.Forms.Button board_check_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox bd_chk_avr_ovp;
        private System.Windows.Forms.TextBox bd_chk_avr_1st;
        private System.Windows.Forms.TextBox bd_chk_avr_2nd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox bd_chk_err_value_ovp;
        private System.Windows.Forms.TextBox bd_chk_dvdt_ovp;
        private System.Windows.Forms.TextBox bd_chk_err_value_1st;
        private System.Windows.Forms.TextBox bd_chk_dvdt_1st;
        private System.Windows.Forms.TextBox bd_chk_err_value_2nd;
        private System.Windows.Forms.TextBox bd_chk_dvdt_2nd;
        private System.Windows.Forms.TextBox bd_chk_avr_adc;
        private System.Windows.Forms.TextBox bd_chk_err_value_adc;
        private System.Windows.Forms.TextBox bd_chk_dvdt_adc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dev12_err_tb;
        private System.Windows.Forms.TextBox dev11_err_tb;
        private System.Windows.Forms.TextBox dev10_err_tb;
        private System.Windows.Forms.TextBox dev9_err_tb;
        private System.Windows.Forms.TextBox dev8_err_tb;
        private System.Windows.Forms.TextBox dev7_err_tb;
        private System.Windows.Forms.TextBox dev6_err_tb;
        private System.Windows.Forms.TextBox dev5_err_tb;
        private System.Windows.Forms.TextBox dev4_err_tb;
        private System.Windows.Forms.TextBox dev3_err_tb;
        private System.Windows.Forms.TextBox dev2_err_tb;
        private System.Windows.Forms.TextBox dev1_err_tb;
        private System.Windows.Forms.Button db_btn;
        private System.Windows.Forms.Button fw_down_mode_btn;
        private System.Windows.Forms.Button dev_auto_mode_btn;
    }
}

