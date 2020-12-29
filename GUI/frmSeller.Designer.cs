namespace GUI
{
    partial class frmSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeller));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvLichChieu = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.gpbChiTiet = new System.Windows.Forms.GroupBox();
            this.cboDinhDang = new System.Windows.Forms.ComboBox();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.dtmThoiGian = new System.Windows.Forms.DateTimePicker();
            this.lblDinhDang = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpbChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 72);
            this.panel2.TabIndex = 9;
            // 
            // labelX
            // 
            this.labelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Blue;
            this.labelX.Location = new System.Drawing.Point(0, 0);
            this.labelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(1346, 72);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Lịch Chiếu Phim";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(534, 72);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(812, 564);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lvLichChieu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(812, 564);
            this.panel5.TabIndex = 15;
            // 
            // lvLichChieu
            // 
            this.lvLichChieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader2});
            this.lvLichChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLichChieu.FullRowSelect = true;
            this.lvLichChieu.HideSelection = false;
            this.lvLichChieu.LargeImageList = this.imageList1;
            this.lvLichChieu.Location = new System.Drawing.Point(0, 0);
            this.lvLichChieu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvLichChieu.Name = "lvLichChieu";
            this.lvLichChieu.Size = new System.Drawing.Size(812, 564);
            this.lvLichChieu.SmallImageList = this.imageList1;
            this.lvLichChieu.TabIndex = 0;
            this.lvLichChieu.UseCompatibleStateImageBehavior = false;
            this.lvLichChieu.View = System.Windows.Forms.View.Details;
            this.lvLichChieu.Click += new System.EventHandler(this.lvLichChieu_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 38;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Phòng Chiếu";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Phim";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giờ Chiếu";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tình Trạng";
            this.columnHeader2.Width = 150;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "green-icon.png");
            this.imageList1.Images.SetKeyName(1, "yellow_icon.png");
            this.imageList1.Images.SetKeyName(2, "red-icon.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gpbChiTiet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 564);
            this.panel3.TabIndex = 15;
            // 
            // gpbChiTiet
            // 
            this.gpbChiTiet.Controls.Add(this.cboDinhDang);
            this.gpbChiTiet.Controls.Add(this.cboPhim);
            this.gpbChiTiet.Controls.Add(this.dtmThoiGian);
            this.gpbChiTiet.Controls.Add(this.lblDinhDang);
            this.gpbChiTiet.Controls.Add(this.lblThoiGian);
            this.gpbChiTiet.Controls.Add(this.lblTenPhim);
            this.gpbChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbChiTiet.Location = new System.Drawing.Point(8, 3);
            this.gpbChiTiet.Name = "gpbChiTiet";
            this.gpbChiTiet.Size = new System.Drawing.Size(521, 257);
            this.gpbChiTiet.TabIndex = 1;
            this.gpbChiTiet.TabStop = false;
            this.gpbChiTiet.Text = "Chi tiết";
            // 
            // cboDinhDang
            // 
            this.cboDinhDang.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cboDinhDang.FormattingEnabled = true;
            this.cboDinhDang.Location = new System.Drawing.Point(197, 183);
            this.cboDinhDang.Name = "cboDinhDang";
            this.cboDinhDang.Size = new System.Drawing.Size(303, 28);
            this.cboDinhDang.TabIndex = 5;
            this.cboDinhDang.SelectedIndexChanged += new System.EventHandler(this.cboDinhDang_SelectedIndexChanged);
            // 
            // cboPhim
            // 
            this.cboPhim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(75, 43);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(425, 28);
            this.cboPhim.TabIndex = 4;
            this.cboPhim.SelectedIndexChanged += new System.EventHandler(this.cboPhim_SelectedIndexChanged);
            // 
            // dtmThoiGian
            // 
            this.dtmThoiGian.CustomFormat = "dd/MM/yyyy";
            this.dtmThoiGian.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dtmThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmThoiGian.Location = new System.Drawing.Point(197, 112);
            this.dtmThoiGian.Name = "dtmThoiGian";
            this.dtmThoiGian.Size = new System.Drawing.Size(303, 29);
            this.dtmThoiGian.TabIndex = 3;
            this.dtmThoiGian.ValueChanged += new System.EventHandler(this.dtmThoiGian_ValueChanged);
            // 
            // lblDinhDang
            // 
            this.lblDinhDang.AutoSize = true;
            this.lblDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblDinhDang.Location = new System.Drawing.Point(5, 183);
            this.lblDinhDang.Name = "lblDinhDang";
            this.lblDinhDang.Size = new System.Drawing.Size(164, 24);
            this.lblDinhDang.TabIndex = 2;
            this.lblDinhDang.Text = "Định dạng phim:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblThoiGian.Location = new System.Drawing.Point(6, 112);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(104, 24);
            this.lblThoiGian.TabIndex = 1;
            this.lblThoiGian.Text = "Thời gian:";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenPhim.Location = new System.Drawing.Point(6, 45);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(63, 24);
            this.lblTenPhim.TabIndex = 0;
            this.lblTenPhim.Text = "Phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Định dạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời Gian:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phim:";
            // 
            // frmSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1346, 636);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Chiếu Phim";
            this.Load += new System.EventHandler(this.frmSeller_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gpbChiTiet.ResumeLayout(false);
            this.gpbChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lvLichChieu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbChiTiet;
        private System.Windows.Forms.ComboBox cboDinhDang;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.DateTimePicker dtmThoiGian;
        private System.Windows.Forms.Label lblDinhDang;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblTenPhim;
    }
}