namespace GUI.frmAdminUserControls
{
    partial class RevenueUC1
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
            this.dtgvRevenue = new System.Windows.Forms.DataGridView();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.dtmFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtmToDate = new System.Windows.Forms.DateTimePicker();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.ShowRevenue = new System.Windows.Forms.Button();
            this.btnReportRevenue = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.AllowUserToAddRows = false;
            this.dtgvRevenue.AllowUserToDeleteRows = false;
            this.dtgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRevenue.Location = new System.Drawing.Point(50, 102);
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.ReadOnly = true;
            this.dtgvRevenue.RowHeadersWidth = 51;
            this.dtgvRevenue.RowTemplate.Height = 24;
            this.dtgvRevenue.Size = new System.Drawing.Size(1211, 385);
            this.dtgvRevenue.TabIndex = 0;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.Location = new System.Drawing.Point(45, 25);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(97, 25);
            this.lblTuNgay.TabIndex = 1;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.Location = new System.Drawing.Point(426, 25);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(107, 25);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(839, 515);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(169, 25);
            this.lblTongDoanhThu.TabIndex = 3;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // dtmFromDate
            // 
            this.dtmFromDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtmFromDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtmFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmFromDate.Location = new System.Drawing.Point(173, 22);
            this.dtmFromDate.Name = "dtmFromDate";
            this.dtmFromDate.Size = new System.Drawing.Size(200, 30);
            this.dtmFromDate.TabIndex = 4;
            // 
            // dtmToDate
            // 
            this.dtmToDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmToDate.CustomFormat = "dd/MM/yyyy";
            this.dtmToDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtmToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmToDate.Location = new System.Drawing.Point(554, 22);
            this.dtmToDate.Name = "dtmToDate";
            this.dtmToDate.Size = new System.Drawing.Size(200, 30);
            this.dtmToDate.TabIndex = 5;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDoanhThu.Location = new System.Drawing.Point(1026, 505);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(235, 35);
            this.txtDoanhThu.TabIndex = 6;
            this.txtDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ShowRevenue
            // 
            this.ShowRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ShowRevenue.Location = new System.Drawing.Point(1040, 25);
            this.ShowRevenue.Name = "ShowRevenue";
            this.ShowRevenue.Size = new System.Drawing.Size(97, 41);
            this.ShowRevenue.TabIndex = 7;
            this.ShowRevenue.Text = "Thống kê";
            this.ShowRevenue.UseVisualStyleBackColor = true;
            this.ShowRevenue.Click += new System.EventHandler(this.ShowRevenue_Click);
            // 
            // btnReportRevenue
            // 
            this.btnReportRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnReportRevenue.Location = new System.Drawing.Point(1164, 25);
            this.btnReportRevenue.Name = "btnReportRevenue";
            this.btnReportRevenue.Size = new System.Drawing.Size(97, 41);
            this.btnReportRevenue.TabIndex = 8;
            this.btnReportRevenue.Text = "Báo cáo";
            this.btnReportRevenue.UseVisualStyleBackColor = true;
            this.btnReportRevenue.Click += new System.EventHandler(this.btnReportRevenue_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(585, 73);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(191, 26);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "Doanh thu bán vé";
            // 
            // RevenueUC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnReportRevenue);
            this.Controls.Add(this.ShowRevenue);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.dtmToDate);
            this.Controls.Add(this.dtmFromDate);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.dtgvRevenue);
            this.Name = "RevenueUC1";
            this.Size = new System.Drawing.Size(1328, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRevenue;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.DateTimePicker dtmFromDate;
        private System.Windows.Forms.DateTimePicker dtmToDate;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Button ShowRevenue;
        private System.Windows.Forms.Button btnReportRevenue;
        private System.Windows.Forms.Label lblX;
    }
}
