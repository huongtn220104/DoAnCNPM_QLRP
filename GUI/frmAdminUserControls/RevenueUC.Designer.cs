namespace GUI.frmAdminUserControls
{
    partial class RevenueUC
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
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvRevenue = new System.Windows.Forms.DataGridView();
            this.btnReportRevenue = new System.Windows.Forms.Button();
            this.btnShowRevenue = new System.Windows.Forms.Button();
            this.cboSelectMovie = new System.Windows.Forms.ComboBox();
            this.dtmToDate = new System.Windows.Forms.DateTimePicker();
            this.dtmFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChiTietDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblSelectMovie.Location = new System.Drawing.Point(310, 46);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(124, 25);
            this.lblSelectMovie.TabIndex = 39;
            this.lblSelectMovie.Text = "Chọn phim:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.Location = new System.Drawing.Point(1110, 537);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(169, 25);
            this.lblTongDoanhThu.TabIndex = 38;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(1285, 527);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(235, 35);
            this.txtDoanhThu.TabIndex = 37;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.Location = new System.Drawing.Point(686, 93);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(107, 25);
            this.lblDenNgay.TabIndex = 36;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(306, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Từ ngày:";
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.AllowUserToAddRows = false;
            this.dtgvRevenue.AllowUserToDeleteRows = false;
            this.dtgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRevenue.Location = new System.Drawing.Point(309, 166);
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.ReadOnly = true;
            this.dtgvRevenue.RowHeadersWidth = 51;
            this.dtgvRevenue.Size = new System.Drawing.Size(1211, 343);
            this.dtgvRevenue.TabIndex = 34;
            // 
            // btnReportRevenue
            // 
            this.btnReportRevenue.AutoSize = true;
            this.btnReportRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportRevenue.Location = new System.Drawing.Point(1428, 75);
            this.btnReportRevenue.Name = "btnReportRevenue";
            this.btnReportRevenue.Size = new System.Drawing.Size(92, 41);
            this.btnReportRevenue.TabIndex = 32;
            this.btnReportRevenue.Text = "Báo cáo";
            this.btnReportRevenue.UseVisualStyleBackColor = true;
            this.btnReportRevenue.Click += new System.EventHandler(this.btnReportRevenue_Click);
            // 
            // btnShowRevenue
            // 
            this.btnShowRevenue.AutoSize = true;
            this.btnShowRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowRevenue.Location = new System.Drawing.Point(1281, 75);
            this.btnShowRevenue.Name = "btnShowRevenue";
            this.btnShowRevenue.Size = new System.Drawing.Size(97, 41);
            this.btnShowRevenue.TabIndex = 33;
            this.btnShowRevenue.Text = "Thống kê";
            this.btnShowRevenue.UseVisualStyleBackColor = true;
            this.btnShowRevenue.Click += new System.EventHandler(this.btnShowRevenue_Click);
            // 
            // cboSelectMovie
            // 
            this.cboSelectMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectMovie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectMovie.FormattingEnabled = true;
            this.cboSelectMovie.Location = new System.Drawing.Point(436, 41);
            this.cboSelectMovie.Name = "cboSelectMovie";
            this.cboSelectMovie.Size = new System.Drawing.Size(548, 30);
            this.cboSelectMovie.TabIndex = 31;
            // 
            // dtmToDate
            // 
            this.dtmToDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmToDate.CustomFormat = "dd/MM/yyyy";
            this.dtmToDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtmToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmToDate.Location = new System.Drawing.Point(819, 90);
            this.dtmToDate.Name = "dtmToDate";
            this.dtmToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtmToDate.Size = new System.Drawing.Size(165, 30);
            this.dtmToDate.TabIndex = 29;
            // 
            // dtmFromDate
            // 
            this.dtmFromDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtmFromDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtmFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmFromDate.Location = new System.Drawing.Point(436, 90);
            this.dtmFromDate.Name = "dtmFromDate";
            this.dtmFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtmFromDate.Size = new System.Drawing.Size(165, 30);
            this.dtmFromDate.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // lblChiTietDoanhThu
            // 
            this.lblChiTietDoanhThu.AutoSize = true;
            this.lblChiTietDoanhThu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietDoanhThu.Location = new System.Drawing.Point(808, 137);
            this.lblChiTietDoanhThu.Name = "lblChiTietDoanhThu";
            this.lblChiTietDoanhThu.Size = new System.Drawing.Size(296, 26);
            this.lblChiTietDoanhThu.TabIndex = 40;
            this.lblChiTietDoanhThu.Text = "Doanh thu chi tiết của phim";
            // 
            // RevenueUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChiTietDoanhThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelectMovie);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvRevenue);
            this.Controls.Add(this.btnReportRevenue);
            this.Controls.Add(this.btnShowRevenue);
            this.Controls.Add(this.cboSelectMovie);
            this.Controls.Add(this.dtmToDate);
            this.Controls.Add(this.dtmFromDate);
            this.Name = "RevenueUC";
            this.Size = new System.Drawing.Size(1850, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvRevenue;
        private System.Windows.Forms.Button btnReportRevenue;
        private System.Windows.Forms.Button btnShowRevenue;
        private System.Windows.Forms.ComboBox cboSelectMovie;
        private System.Windows.Forms.DateTimePicker dtmToDate;
        private System.Windows.Forms.DateTimePicker dtmFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChiTietDoanhThu;
    }
}
