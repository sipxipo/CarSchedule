namespace CarSchedule
{
    partial class ScheduleBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleBookForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CarNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_gone = new System.Windows.Forms.RadioButton();
            this.rdo_waiting = new System.Windows.Forms.RadioButton();
            this.group_WashingType = new System.Windows.Forms.GroupBox();
            this.rdo_Normal = new System.Windows.Forms.RadioButton();
            this.rdo_Cleanup = new System.Windows.Forms.RadioButton();
            this.rdo_Paint = new System.Windows.Forms.RadioButton();
            this.rdo_General = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TimeSlotBooked = new System.Windows.Forms.Label();
            this.btn_Booked = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.group_WashingType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển số xe :";
            // 
            // txt_CarNumber
            // 
            this.txt_CarNumber.Location = new System.Drawing.Point(92, 24);
            this.txt_CarNumber.Name = "txt_CarNumber";
            this.txt_CarNumber.Size = new System.Drawing.Size(222, 20);
            this.txt_CarNumber.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_gone);
            this.groupBox1.Controls.Add(this.rdo_waiting);
            this.groupBox1.Location = new System.Drawing.Point(27, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng Thái";
            // 
            // rdo_gone
            // 
            this.rdo_gone.AutoSize = true;
            this.rdo_gone.Location = new System.Drawing.Point(163, 19);
            this.rdo_gone.Name = "rdo_gone";
            this.rdo_gone.Size = new System.Drawing.Size(72, 17);
            this.rdo_gone.TabIndex = 0;
            this.rdo_gone.TabStop = true;
            this.rdo_gone.Text = "Khách Về";
            this.rdo_gone.UseVisualStyleBackColor = true;
            // 
            // rdo_waiting
            // 
            this.rdo_waiting.AutoSize = true;
            this.rdo_waiting.Checked = true;
            this.rdo_waiting.Location = new System.Drawing.Point(6, 19);
            this.rdo_waiting.Name = "rdo_waiting";
            this.rdo_waiting.Size = new System.Drawing.Size(73, 17);
            this.rdo_waiting.TabIndex = 0;
            this.rdo_waiting.TabStop = true;
            this.rdo_waiting.Text = "Đang Chờ";
            this.rdo_waiting.UseVisualStyleBackColor = true;
            // 
            // group_WashingType
            // 
            this.group_WashingType.Controls.Add(this.rdo_Normal);
            this.group_WashingType.Controls.Add(this.rdo_Cleanup);
            this.group_WashingType.Controls.Add(this.rdo_Paint);
            this.group_WashingType.Controls.Add(this.rdo_General);
            this.group_WashingType.Location = new System.Drawing.Point(27, 144);
            this.group_WashingType.Name = "group_WashingType";
            this.group_WashingType.Size = new System.Drawing.Size(287, 100);
            this.group_WashingType.TabIndex = 3;
            this.group_WashingType.TabStop = false;
            this.group_WashingType.Text = "Loại sửa chữa";
            // 
            // rdo_Normal
            // 
            this.rdo_Normal.AutoSize = true;
            this.rdo_Normal.Location = new System.Drawing.Point(163, 42);
            this.rdo_Normal.Name = "rdo_Normal";
            this.rdo_Normal.Size = new System.Drawing.Size(86, 17);
            this.rdo_Normal.TabIndex = 0;
            this.rdo_Normal.TabStop = true;
            this.rdo_Normal.Text = "Bình Thường";
            this.rdo_Normal.UseVisualStyleBackColor = true;
            // 
            // rdo_Cleanup
            // 
            this.rdo_Cleanup.AutoSize = true;
            this.rdo_Cleanup.Location = new System.Drawing.Point(163, 19);
            this.rdo_Cleanup.Name = "rdo_Cleanup";
            this.rdo_Cleanup.Size = new System.Drawing.Size(78, 17);
            this.rdo_Cleanup.TabIndex = 0;
            this.rdo_Cleanup.TabStop = true;
            this.rdo_Cleanup.Text = "Diệt Khuẩn";
            this.rdo_Cleanup.UseVisualStyleBackColor = true;
            // 
            // rdo_Paint
            // 
            this.rdo_Paint.AutoSize = true;
            this.rdo_Paint.Location = new System.Drawing.Point(6, 42);
            this.rdo_Paint.Name = "rdo_Paint";
            this.rdo_Paint.Size = new System.Drawing.Size(73, 17);
            this.rdo_Paint.TabIndex = 0;
            this.rdo_Paint.TabStop = true;
            this.rdo_Paint.Text = "Đồng Sơn";
            this.rdo_Paint.UseVisualStyleBackColor = true;
            // 
            // rdo_General
            // 
            this.rdo_General.AutoSize = true;
            this.rdo_General.Checked = true;
            this.rdo_General.Location = new System.Drawing.Point(6, 19);
            this.rdo_General.Name = "rdo_General";
            this.rdo_General.Size = new System.Drawing.Size(106, 17);
            this.rdo_General.TabIndex = 0;
            this.rdo_General.TabStop = true;
            this.rdo_General.Text = "Sửa Chữa Chung";
            this.rdo_General.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giờ đặt :";
            // 
            // lbl_TimeSlotBooked
            // 
            this.lbl_TimeSlotBooked.AutoSize = true;
            this.lbl_TimeSlotBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeSlotBooked.Location = new System.Drawing.Point(76, 55);
            this.lbl_TimeSlotBooked.Name = "lbl_TimeSlotBooked";
            this.lbl_TimeSlotBooked.Size = new System.Drawing.Size(57, 13);
            this.lbl_TimeSlotBooked.TabIndex = 0;
            this.lbl_TimeSlotBooked.Text = "Giờ đặt :";
            // 
            // btn_Booked
            // 
            this.btn_Booked.Location = new System.Drawing.Point(79, 250);
            this.btn_Booked.Name = "btn_Booked";
            this.btn_Booked.Size = new System.Drawing.Size(75, 23);
            this.btn_Booked.TabIndex = 4;
            this.btn_Booked.Text = "Đặt Lịch";
            this.btn_Booked.UseVisualStyleBackColor = true;
            this.btn_Booked.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(190, 250);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(228, 55);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(57, 13);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Giờ đặt :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày đặt :";
            // 
            // ScheduleBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 310);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Booked);
            this.Controls.Add(this.group_WashingType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_CarNumber);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_TimeSlotBooked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScheduleBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookScheduleForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_WashingType.ResumeLayout(false);
            this.group_WashingType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CarNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_gone;
        private System.Windows.Forms.RadioButton rdo_waiting;
        private System.Windows.Forms.GroupBox group_WashingType;
        private System.Windows.Forms.RadioButton rdo_Normal;
        private System.Windows.Forms.RadioButton rdo_Cleanup;
        private System.Windows.Forms.RadioButton rdo_Paint;
        private System.Windows.Forms.RadioButton rdo_General;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TimeSlotBooked;
        private System.Windows.Forms.Button btn_Booked;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label4;
    }
}