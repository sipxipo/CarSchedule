namespace CarSchedule
{
    partial class ScheduleMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tab_Analysis = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_Year = new System.Windows.Forms.CheckBox();
            this.chk_Month = new System.Windows.Forms.CheckBox();
            this.chk_Date = new System.Windows.Forms.CheckBox();
            this.dPick_Year = new System.Windows.Forms.DateTimePicker();
            this.dPick_Month = new System.Windows.Forms.DateTimePicker();
            this.dPick_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Analysis = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.GroupBox();
            this.cbb_WashingType = new System.Windows.Forms.ComboBox();
            this.cbb_WashMan_Analysis = new System.Windows.Forms.ComboBox();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_Schedule = new System.Windows.Forms.DataGridView();
            this.tab_Schedule = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_WashMan = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_WashManName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lst_carwashing = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lst_carwaiting = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Analysis.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Schedule)).BeginInit();
            this.tab_Schedule.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tab_Analysis
            // 
            this.tab_Analysis.Controls.Add(this.tableLayoutPanel8);
            this.tab_Analysis.Location = new System.Drawing.Point(4, 22);
            this.tab_Analysis.Name = "tab_Analysis";
            this.tab_Analysis.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Analysis.Size = new System.Drawing.Size(1100, 683);
            this.tab_Analysis.TabIndex = 1;
            this.tab_Analysis.Text = "Thống Kê";
            this.tab_Analysis.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel8.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.dgrid_Schedule, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1094, 677);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_Excel);
            this.panel1.Controls.Add(this.btn_Analysis);
            this.panel1.Controls.Add(this.group);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 671);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chk_Year);
            this.groupBox1.Controls.Add(this.chk_Month);
            this.groupBox1.Controls.Add(this.chk_Date);
            this.groupBox1.Controls.Add(this.dPick_Year);
            this.groupBox1.Controls.Add(this.dPick_Month);
            this.groupBox1.Controls.Add(this.dPick_Date);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu theo";
            // 
            // chk_Year
            // 
            this.chk_Year.AutoSize = true;
            this.chk_Year.Location = new System.Drawing.Point(9, 81);
            this.chk_Year.Name = "chk_Year";
            this.chk_Year.Size = new System.Drawing.Size(48, 17);
            this.chk_Year.TabIndex = 1;
            this.chk_Year.Tag = "Year";
            this.chk_Year.Text = "Năm";
            this.chk_Year.UseVisualStyleBackColor = true;
            this.chk_Year.Click += new System.EventHandler(this.chk_Date_Click);
            // 
            // chk_Month
            // 
            this.chk_Month.AutoSize = true;
            this.chk_Month.Location = new System.Drawing.Point(9, 52);
            this.chk_Month.Name = "chk_Month";
            this.chk_Month.Size = new System.Drawing.Size(57, 17);
            this.chk_Month.TabIndex = 1;
            this.chk_Month.Tag = "Month";
            this.chk_Month.Text = "Tháng";
            this.chk_Month.UseVisualStyleBackColor = true;
            this.chk_Month.Click += new System.EventHandler(this.chk_Date_Click);
            // 
            // chk_Date
            // 
            this.chk_Date.AutoSize = true;
            this.chk_Date.Checked = true;
            this.chk_Date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Date.Location = new System.Drawing.Point(9, 22);
            this.chk_Date.Name = "chk_Date";
            this.chk_Date.Size = new System.Drawing.Size(51, 17);
            this.chk_Date.TabIndex = 1;
            this.chk_Date.Tag = "Date";
            this.chk_Date.Text = "Ngày";
            this.chk_Date.UseVisualStyleBackColor = true;
            this.chk_Date.Click += new System.EventHandler(this.chk_Date_Click);
            // 
            // dPick_Year
            // 
            this.dPick_Year.CustomFormat = "yyyy";
            this.dPick_Year.Enabled = false;
            this.dPick_Year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPick_Year.Location = new System.Drawing.Point(95, 80);
            this.dPick_Year.Name = "dPick_Year";
            this.dPick_Year.ShowUpDown = true;
            this.dPick_Year.Size = new System.Drawing.Size(104, 20);
            this.dPick_Year.TabIndex = 0;
            this.dPick_Year.Tag = "Year";
            // 
            // dPick_Month
            // 
            this.dPick_Month.CustomFormat = "MM";
            this.dPick_Month.Enabled = false;
            this.dPick_Month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPick_Month.Location = new System.Drawing.Point(95, 51);
            this.dPick_Month.Name = "dPick_Month";
            this.dPick_Month.ShowUpDown = true;
            this.dPick_Month.Size = new System.Drawing.Size(46, 20);
            this.dPick_Month.TabIndex = 0;
            this.dPick_Month.Tag = "Month";
            // 
            // dPick_Date
            // 
            this.dPick_Date.CustomFormat = "dd/MM/yyyy";
            this.dPick_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPick_Date.Location = new System.Drawing.Point(95, 21);
            this.dPick_Date.Name = "dPick_Date";
            this.dPick_Date.Size = new System.Drawing.Size(119, 20);
            this.dPick_Date.TabIndex = 0;
            this.dPick_Date.Tag = "Date";
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(117, 291);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(75, 23);
            this.btn_Excel.TabIndex = 2;
            this.btn_Excel.Text = "Xuất Excel ";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Analysis
            // 
            this.btn_Analysis.Location = new System.Drawing.Point(36, 291);
            this.btn_Analysis.Name = "btn_Analysis";
            this.btn_Analysis.Size = new System.Drawing.Size(75, 23);
            this.btn_Analysis.TabIndex = 2;
            this.btn_Analysis.Text = "Thống Kê";
            this.btn_Analysis.UseVisualStyleBackColor = true;
            this.btn_Analysis.Click += new System.EventHandler(this.btn_Analysis_Click);
            // 
            // group
            // 
            this.group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group.Controls.Add(this.cbb_WashingType);
            this.group.Controls.Add(this.cbb_WashMan_Analysis);
            this.group.Controls.Add(this.txtCarNumber);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.label1);
            this.group.Location = new System.Drawing.Point(3, 133);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(316, 129);
            this.group.TabIndex = 1;
            this.group.TabStop = false;
            this.group.Text = "KHÁC";
            // 
            // cbb_WashingType
            // 
            this.cbb_WashingType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_WashingType.FormattingEnabled = true;
            this.cbb_WashingType.Location = new System.Drawing.Point(74, 81);
            this.cbb_WashingType.Name = "cbb_WashingType";
            this.cbb_WashingType.Size = new System.Drawing.Size(235, 21);
            this.cbb_WashingType.TabIndex = 2;
            // 
            // cbb_WashMan_Analysis
            // 
            this.cbb_WashMan_Analysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_WashMan_Analysis.FormattingEnabled = true;
            this.cbb_WashMan_Analysis.Location = new System.Drawing.Point(74, 17);
            this.cbb_WashMan_Analysis.Name = "cbb_WashMan_Analysis";
            this.cbb_WashMan_Analysis.Size = new System.Drawing.Size(235, 21);
            this.cbb_WashMan_Analysis.TabIndex = 2;
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarNumber.Location = new System.Drawing.Point(74, 50);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(125, 20);
            this.txtCarNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Biển Số Xe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người Đặt :";
            // 
            // dgrid_Schedule
            // 
            this.dgrid_Schedule.AllowUserToAddRows = false;
            this.dgrid_Schedule.AllowUserToDeleteRows = false;
            this.dgrid_Schedule.AllowUserToResizeColumns = false;
            this.dgrid_Schedule.AllowUserToResizeRows = false;
            this.dgrid_Schedule.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgrid_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Schedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Schedule.Location = new System.Drawing.Point(331, 3);
            this.dgrid_Schedule.Name = "dgrid_Schedule";
            this.dgrid_Schedule.RowHeadersVisible = false;
            this.dgrid_Schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Schedule.Size = new System.Drawing.Size(760, 671);
            this.dgrid_Schedule.TabIndex = 1;
            this.dgrid_Schedule.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // tab_Schedule
            // 
            this.tab_Schedule.Controls.Add(this.tableLayoutPanel3);
            this.tab_Schedule.Location = new System.Drawing.Point(4, 22);
            this.tab_Schedule.Name = "tab_Schedule";
            this.tab_Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Schedule.Size = new System.Drawing.Size(1100, 683);
            this.tab_Schedule.TabIndex = 0;
            this.tab_Schedule.Text = "Tiến độ";
            this.tab_Schedule.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1094, 677);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1088, 95);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Refesh, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Delete, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(646, 89);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Refesh.Location = new System.Drawing.Point(584, 3);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(59, 38);
            this.btn_Refesh.TabIndex = 19;
            this.btn_Refesh.Text = "CẬP NHẬT TIẾN ĐỘ";
            this.btn_Refesh.UseVisualStyleBackColor = true;
            this.btn_Refesh.Click += new System.EventHandler(this.btnRefesh_Click_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete.Location = new System.Drawing.Point(584, 47);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(59, 39);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "XÓA";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.36659F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.63341F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.cbb_WashMan, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.checkBox1, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(575, 39);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // cbb_WashMan
            // 
            this.cbb_WashMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_WashMan.Enabled = false;
            this.cbb_WashMan.FormattingEnabled = true;
            this.cbb_WashMan.IntegralHeight = false;
            this.cbb_WashMan.Location = new System.Drawing.Point(3, 3);
            this.cbb_WashMan.Name = "cbb_WashMan";
            this.cbb_WashMan.Size = new System.Drawing.Size(404, 21);
            this.cbb_WashMan.TabIndex = 7;
            this.cbb_WashMan.SelectedIndexChanged += new System.EventHandler(this.cbb_WashMan_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(413, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Xem tất cả";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.1282F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.37363F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24909F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24909F));
            this.tableLayoutPanel7.Controls.Add(this.lbl_Date, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_Time, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_WashManName, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(575, 38);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(344, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(110, 38);
            this.lbl_Date.TabIndex = 23;
            this.lbl_Date.Text = "10/10/2016";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Time.Location = new System.Drawing.Point(460, 0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(112, 38);
            this.lbl_Time.TabIndex = 22;
            this.lbl_Time.Text = "12:00";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_WashManName
            // 
            this.lbl_WashManName.AutoSize = true;
            this.lbl_WashManName.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_WashManName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_WashManName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WashManName.Location = new System.Drawing.Point(3, 0);
            this.lbl_WashManName.Name = "lbl_WashManName";
            this.lbl_WashManName.Size = new System.Drawing.Size(161, 38);
            this.lbl_WashManName.TabIndex = 21;
            this.lbl_WashManName.Text = "Tên Cố Vấn";
            this.lbl_WashManName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl.Location = new System.Drawing.Point(170, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(168, 38);
            this.lbl.TabIndex = 20;
            this.lbl.Text = "TIẾN ĐỘ RỬA XE";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lst_carwashing, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label17, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lst_carwaiting, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(655, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(430, 89);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lst_carwashing
            // 
            this.lst_carwashing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_carwashing.FormattingEnabled = true;
            this.lst_carwashing.Location = new System.Drawing.Point(218, 29);
            this.lst_carwashing.Name = "lst_carwashing";
            this.lst_carwashing.Size = new System.Drawing.Size(209, 57);
            this.lst_carwashing.TabIndex = 3;
            this.lst_carwashing.SelectedIndexChanged += new System.EventHandler(this.lst_carwaiting_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Green;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(218, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(209, 26);
            this.label17.TabIndex = 1;
            this.label17.Text = "XE ĐÃ RỬA";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Navy;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 26);
            this.label16.TabIndex = 0;
            this.label16.Text = "XE TIẾP THEO";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lst_carwaiting
            // 
            this.lst_carwaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_carwaiting.FormattingEnabled = true;
            this.lst_carwaiting.Location = new System.Drawing.Point(3, 29);
            this.lst_carwaiting.Name = "lst_carwaiting";
            this.lst_carwaiting.Size = new System.Drawing.Size(209, 57);
            this.lst_carwaiting.TabIndex = 2;
            this.lst_carwaiting.SelectedIndexChanged += new System.EventHandler(this.lst_carwaiting_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Schedule);
            this.tabControl1.Controls.Add(this.tab_Analysis);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 709);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ScheduleMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1108, 733);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScheduleMainForm";
            this.Text = "Tiến Độ Rửa Xe";
            this.tab_Analysis.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Schedule)).EndInit();
            this.tab_Schedule.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tab_Analysis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_Year;
        private System.Windows.Forms.CheckBox chk_Month;
        private System.Windows.Forms.CheckBox chk_Date;
        private System.Windows.Forms.DateTimePicker dPick_Year;
        private System.Windows.Forms.DateTimePicker dPick_Month;
        private System.Windows.Forms.DateTimePicker dPick_Date;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Analysis;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.ComboBox cbb_WashingType;
        private System.Windows.Forms.ComboBox cbb_WashMan_Analysis;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_Schedule;
        private System.Windows.Forms.TabPage tab_Schedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox cbb_WashMan;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_WashManName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListBox lst_carwashing;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lst_carwaiting;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

