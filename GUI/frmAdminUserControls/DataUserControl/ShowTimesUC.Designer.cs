﻿namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class ShowTimesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel54 = new System.Windows.Forms.Panel();
            this.gpbTimTheoTenPhim = new System.Windows.Forms.GroupBox();
            this.btnSearchShowtime = new System.Windows.Forms.Button();
            this.txtSearchShowtime = new System.Windows.Forms.TextBox();
            this.btnShowShowtime = new System.Windows.Forms.Button();
            this.btnUpdateShowtime = new System.Windows.Forms.Button();
            this.btnDeleteShowtime = new System.Windows.Forms.Button();
            this.btnInsertShowtime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvShowtime = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtmShowtimeTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmShowtimeDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFormatID_Showtime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCinemaID_Showtime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScreenTypeName_Showtime = new System.Windows.Forms.TextBox();
            this.txtMovieName_Showtime = new System.Windows.Forms.TextBox();
            this.txtTicketPrice_Showtime = new System.Windows.Forms.TextBox();
            this.txtShowtimeID = new System.Windows.Forms.TextBox();
            this.toolTipCinema = new System.Windows.Forms.ToolTip(this.components);
            this.panel54.SuspendLayout();
            this.gpbTimTheoTenPhim.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.gpbTimTheoTenPhim);
            this.panel54.Controls.Add(this.btnShowShowtime);
            this.panel54.Controls.Add(this.btnUpdateShowtime);
            this.panel54.Controls.Add(this.btnDeleteShowtime);
            this.panel54.Controls.Add(this.btnInsertShowtime);
            this.panel54.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel54.Location = new System.Drawing.Point(0, 0);
            this.panel54.Margin = new System.Windows.Forms.Padding(4);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(1548, 64);
            this.panel54.TabIndex = 10;
            // 
            // gpbTimTheoTenPhim
            // 
            this.gpbTimTheoTenPhim.Controls.Add(this.btnSearchShowtime);
            this.gpbTimTheoTenPhim.Controls.Add(this.txtSearchShowtime);
            this.gpbTimTheoTenPhim.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gpbTimTheoTenPhim.Location = new System.Drawing.Point(778, 1);
            this.gpbTimTheoTenPhim.Name = "gpbTimTheoTenPhim";
            this.gpbTimTheoTenPhim.Size = new System.Drawing.Size(351, 60);
            this.gpbTimTheoTenPhim.TabIndex = 8;
            this.gpbTimTheoTenPhim.TabStop = false;
            this.gpbTimTheoTenPhim.Text = "Tìm theo tên phim";
            // 
            // btnSearchShowtime
            // 
            this.btnSearchShowtime.Image = global::GUI.Properties.Resources.search_icon;
            this.btnSearchShowtime.Location = new System.Drawing.Point(318, 23);
            this.btnSearchShowtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchShowtime.Name = "btnSearchShowtime";
            this.btnSearchShowtime.Size = new System.Drawing.Size(27, 27);
            this.btnSearchShowtime.TabIndex = 7;
            this.btnSearchShowtime.UseVisualStyleBackColor = true;
            this.btnSearchShowtime.Click += new System.EventHandler(this.btnSearchShowtime_Click);
            // 
            // txtSearchShowtime
            // 
            this.txtSearchShowtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchShowtime.Location = new System.Drawing.Point(6, 23);
            this.txtSearchShowtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchShowtime.Multiline = true;
            this.txtSearchShowtime.Name = "txtSearchShowtime";
            this.txtSearchShowtime.Size = new System.Drawing.Size(300, 27);
            this.txtSearchShowtime.TabIndex = 6;
            this.txtSearchShowtime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchShowtime_KeyDown);
            // 
            // btnShowShowtime
            // 
            this.btnShowShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShowShowtime.Location = new System.Drawing.Point(328, 4);
            this.btnShowShowtime.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowShowtime.Name = "btnShowShowtime";
            this.btnShowShowtime.Size = new System.Drawing.Size(100, 57);
            this.btnShowShowtime.TabIndex = 3;
            this.btnShowShowtime.Text = "Xem";
            this.btnShowShowtime.UseVisualStyleBackColor = true;
            this.btnShowShowtime.Click += new System.EventHandler(this.btnShowShowtime_Click);
            // 
            // btnUpdateShowtime
            // 
            this.btnUpdateShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdateShowtime.Location = new System.Drawing.Point(220, 4);
            this.btnUpdateShowtime.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateShowtime.Name = "btnUpdateShowtime";
            this.btnUpdateShowtime.Size = new System.Drawing.Size(100, 57);
            this.btnUpdateShowtime.TabIndex = 2;
            this.btnUpdateShowtime.Text = "Sửa";
            this.btnUpdateShowtime.UseVisualStyleBackColor = true;
            this.btnUpdateShowtime.Click += new System.EventHandler(this.btnUpdateShowtime_Click);
            // 
            // btnDeleteShowtime
            // 
            this.btnDeleteShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteShowtime.Location = new System.Drawing.Point(112, 4);
            this.btnDeleteShowtime.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteShowtime.Name = "btnDeleteShowtime";
            this.btnDeleteShowtime.Size = new System.Drawing.Size(100, 57);
            this.btnDeleteShowtime.TabIndex = 1;
            this.btnDeleteShowtime.Text = "Xóa";
            this.btnDeleteShowtime.UseVisualStyleBackColor = true;
            this.btnDeleteShowtime.Click += new System.EventHandler(this.btnDeleteShowtime_Click);
            // 
            // btnInsertShowtime
            // 
            this.btnInsertShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInsertShowtime.Location = new System.Drawing.Point(4, 4);
            this.btnInsertShowtime.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertShowtime.Name = "btnInsertShowtime";
            this.btnInsertShowtime.Size = new System.Drawing.Size(100, 57);
            this.btnInsertShowtime.TabIndex = 0;
            this.btnInsertShowtime.Text = "Thêm";
            this.btnInsertShowtime.UseVisualStyleBackColor = true;
            this.btnInsertShowtime.Click += new System.EventHandler(this.btnInsertShowtime_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvShowtime);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 574);
            this.panel1.TabIndex = 11;
            // 
            // dtgvShowtime
            // 
            this.dtgvShowtime.AllowUserToAddRows = false;
            this.dtgvShowtime.AllowUserToDeleteRows = false;
            this.dtgvShowtime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvShowtime.Location = new System.Drawing.Point(0, 0);
            this.dtgvShowtime.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvShowtime.Name = "dtgvShowtime";
            this.dtgvShowtime.ReadOnly = true;
            this.dtgvShowtime.RowHeadersWidth = 51;
            this.dtgvShowtime.Size = new System.Drawing.Size(1127, 574);
            this.dtgvShowtime.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.cboFormatID_Showtime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboCinemaID_Showtime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtScreenTypeName_Showtime);
            this.panel2.Controls.Add(this.txtMovieName_Showtime);
            this.panel2.Controls.Add(this.txtTicketPrice_Showtime);
            this.panel2.Controls.Add(this.txtShowtimeID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1127, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 574);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtmShowtimeTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtmShowtimeDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(393, 98);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian chiếu";
            // 
            // dtmShowtimeTime
            // 
            this.dtmShowtimeTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.CustomFormat = "dd/MM/yyyy";
            this.dtmShowtimeTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmShowtimeTime.Location = new System.Drawing.Point(160, 55);
            this.dtmShowtimeTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmShowtimeTime.Name = "dtmShowtimeTime";
            this.dtmShowtimeTime.ShowUpDown = true;
            this.dtmShowtimeTime.Size = new System.Drawing.Size(216, 30);
            this.dtmShowtimeTime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giờ:";
            // 
            // dtmShowtimeDate
            // 
            this.dtmShowtimeDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.CustomFormat = "dd/MM/yyyy";
            this.dtmShowtimeDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmShowtimeDate.Location = new System.Drawing.Point(160, 20);
            this.dtmShowtimeDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmShowtimeDate.Name = "dtmShowtimeDate";
            this.dtmShowtimeDate.Size = new System.Drawing.Size(216, 30);
            this.dtmShowtimeDate.TabIndex = 14;
            this.dtmShowtimeDate.Value = new System.DateTime(2020, 12, 24, 14, 54, 56, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày:";
            // 
            // cboFormatID_Showtime
            // 
            this.cboFormatID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormatID_Showtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormatID_Showtime.FormattingEnabled = true;
            this.cboFormatID_Showtime.Location = new System.Drawing.Point(161, 68);
            this.cboFormatID_Showtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFormatID_Showtime.Name = "cboFormatID_Showtime";
            this.cboFormatID_Showtime.Size = new System.Drawing.Size(245, 30);
            this.cboFormatID_Showtime.TabIndex = 26;
            this.cboFormatID_Showtime.SelectedIndexChanged += new System.EventHandler(this.cboFormatID_Showtime_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã định dạng:";
            // 
            // cboCinemaID_Showtime
            // 
            this.cboCinemaID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinemaID_Showtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCinemaID_Showtime.FormattingEnabled = true;
            this.cboCinemaID_Showtime.Location = new System.Drawing.Point(161, 191);
            this.cboCinemaID_Showtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCinemaID_Showtime.Name = "cboCinemaID_Showtime";
            this.cboCinemaID_Showtime.Size = new System.Drawing.Size(245, 30);
            this.cboCinemaID_Showtime.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phòng chiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Giá vé:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Màn hình:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã lịch chiếu:";
            // 
            // txtScreenTypeName_Showtime
            // 
            this.txtScreenTypeName_Showtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreenTypeName_Showtime.Location = new System.Drawing.Point(161, 140);
            this.txtScreenTypeName_Showtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScreenTypeName_Showtime.Name = "txtScreenTypeName_Showtime";
            this.txtScreenTypeName_Showtime.ReadOnly = true;
            this.txtScreenTypeName_Showtime.Size = new System.Drawing.Size(245, 30);
            this.txtScreenTypeName_Showtime.TabIndex = 16;
            // 
            // txtMovieName_Showtime
            // 
            this.txtMovieName_Showtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName_Showtime.Location = new System.Drawing.Point(161, 105);
            this.txtMovieName_Showtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieName_Showtime.Name = "txtMovieName_Showtime";
            this.txtMovieName_Showtime.ReadOnly = true;
            this.txtMovieName_Showtime.Size = new System.Drawing.Size(245, 30);
            this.txtMovieName_Showtime.TabIndex = 17;
            // 
            // txtTicketPrice_Showtime
            // 
            this.txtTicketPrice_Showtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketPrice_Showtime.Location = new System.Drawing.Point(161, 367);
            this.txtTicketPrice_Showtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTicketPrice_Showtime.Name = "txtTicketPrice_Showtime";
            this.txtTicketPrice_Showtime.Size = new System.Drawing.Size(245, 30);
            this.txtTicketPrice_Showtime.TabIndex = 18;
            // 
            // txtShowtimeID
            // 
            this.txtShowtimeID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowtimeID.Location = new System.Drawing.Point(161, 12);
            this.txtShowtimeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShowtimeID.Name = "txtShowtimeID";
            this.txtShowtimeID.Size = new System.Drawing.Size(245, 30);
            this.txtShowtimeID.TabIndex = 19;
            this.txtShowtimeID.TextChanged += new System.EventHandler(this.txtShowtimeID_TextChanged);
            // 
            // toolTipCinema
            // 
            this.toolTipCinema.AutoPopDelay = 5000;
            this.toolTipCinema.InitialDelay = 100;
            this.toolTipCinema.ReshowDelay = 100;
            // 
            // ShowTimesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel54);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowTimesUC";
            this.Size = new System.Drawing.Size(1548, 638);
            this.panel54.ResumeLayout(false);
            this.gpbTimTheoTenPhim.ResumeLayout(false);
            this.gpbTimTheoTenPhim.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.Button btnSearchShowtime;
        private System.Windows.Forms.TextBox txtSearchShowtime;
        private System.Windows.Forms.Button btnShowShowtime;
        private System.Windows.Forms.Button btnUpdateShowtime;
        private System.Windows.Forms.Button btnDeleteShowtime;
        private System.Windows.Forms.Button btnInsertShowtime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtmShowtimeTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtmShowtimeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFormatID_Showtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCinemaID_Showtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScreenTypeName_Showtime;
        private System.Windows.Forms.TextBox txtMovieName_Showtime;
        private System.Windows.Forms.TextBox txtTicketPrice_Showtime;
        private System.Windows.Forms.TextBox txtShowtimeID;
        private System.Windows.Forms.DataGridView dtgvShowtime;
		private System.Windows.Forms.ToolTip toolTipCinema;
        private System.Windows.Forms.GroupBox gpbTimTheoTenPhim;
    }
}
