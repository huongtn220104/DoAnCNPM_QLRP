namespace GUI.frmAdminUserControls
{
    partial class CustomerUC
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
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.dtmBirthDay = new System.Windows.Forms.DateTimePicker();
            this.nudPoint = new System.Windows.Forms.NumericUpDown();
            this.lblCusID = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.lblCusEmail = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblCusBirth = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.lblCusPhone = new System.Windows.Forms.Label();
            this.lblCusPoint = new System.Windows.Forms.Label();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.lblCusName = new System.Windows.Forms.Label();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.lblDSKhachHang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSearchCus.Location = new System.Drawing.Point(10, 25);
            this.txtSearchCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(301, 30);
            this.txtSearchCus.TabIndex = 20;
            this.txtSearchCus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchCus_KeyDown);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(913, 192);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(90, 40);
            this.btnDeleteCustomer.TabIndex = 17;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(793, 191);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(90, 40);
            this.btnUpdateCustomer.TabIndex = 18;
            this.btnUpdateCustomer.Text = "Sửa";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(670, 190);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(90, 40);
            this.btnAddCustomer.TabIndex = 19;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.Controls.Add(this.dtmBirthDay);
            this.grpCustomer.Controls.Add(this.nudPoint);
            this.grpCustomer.Controls.Add(this.lblCusID);
            this.grpCustomer.Controls.Add(this.txtCusID);
            this.grpCustomer.Controls.Add(this.txtCusAddress);
            this.grpCustomer.Controls.Add(this.lblCusEmail);
            this.grpCustomer.Controls.Add(this.txtCusName);
            this.grpCustomer.Controls.Add(this.lblCusBirth);
            this.grpCustomer.Controls.Add(this.txtCusPhone);
            this.grpCustomer.Controls.Add(this.lblCusPhone);
            this.grpCustomer.Controls.Add(this.lblCusPoint);
            this.grpCustomer.Controls.Add(this.lblCusAddress);
            this.grpCustomer.Controls.Add(this.txtCusEmail);
            this.grpCustomer.Controls.Add(this.lblCusName);
            this.grpCustomer.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpCustomer.Location = new System.Drawing.Point(305, 27);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomer.Size = new System.Drawing.Size(971, 145);
            this.grpCustomer.TabIndex = 16;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Thông tin khách hàng";
            // 
            // dtmBirthDay
            // 
            this.dtmBirthDay.CustomFormat = "dd/MM/yyyy";
            this.dtmBirthDay.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmBirthDay.Location = new System.Drawing.Point(133, 106);
            this.dtmBirthDay.Name = "dtmBirthDay";
            this.dtmBirthDay.Size = new System.Drawing.Size(209, 33);
            this.dtmBirthDay.TabIndex = 6;
            // 
            // nudPoint
            // 
            this.nudPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPoint.Location = new System.Drawing.Point(877, 38);
            this.nudPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPoint.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPoint.Name = "nudPoint";
            this.nudPoint.Size = new System.Drawing.Size(75, 30);
            this.nudPoint.TabIndex = 5;
            this.nudPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.Location = new System.Drawing.Point(24, 39);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(79, 23);
            this.lblCusID.TabIndex = 4;
            this.lblCusID.Text = "Mã KH:";
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(133, 37);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(209, 30);
            this.txtCusID.TabIndex = 2;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusAddress.Location = new System.Drawing.Point(477, 36);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(256, 30);
            this.txtCusAddress.TabIndex = 2;
            // 
            // lblCusEmail
            // 
            this.lblCusEmail.AutoSize = true;
            this.lblCusEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusEmail.Location = new System.Drawing.Point(373, 108);
            this.lblCusEmail.Name = "lblCusEmail";
            this.lblCusEmail.Size = new System.Drawing.Size(65, 23);
            this.lblCusEmail.TabIndex = 4;
            this.lblCusEmail.Text = "Email:";
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(133, 71);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(209, 30);
            this.txtCusName.TabIndex = 2;
            // 
            // lblCusBirth
            // 
            this.lblCusBirth.AutoSize = true;
            this.lblCusBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusBirth.Location = new System.Drawing.Point(24, 111);
            this.lblCusBirth.Name = "lblCusBirth";
            this.lblCusBirth.Size = new System.Drawing.Size(99, 23);
            this.lblCusBirth.TabIndex = 4;
            this.lblCusBirth.Text = "Ngày sinh:";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusPhone.Location = new System.Drawing.Point(477, 71);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(256, 30);
            this.txtCusPhone.TabIndex = 2;
            // 
            // lblCusPhone
            // 
            this.lblCusPhone.AutoSize = true;
            this.lblCusPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPhone.Location = new System.Drawing.Point(373, 75);
            this.lblCusPhone.Name = "lblCusPhone";
            this.lblCusPhone.Size = new System.Drawing.Size(69, 23);
            this.lblCusPhone.TabIndex = 4;
            this.lblCusPhone.Text = "Số ĐT:";
            // 
            // lblCusPoint
            // 
            this.lblCusPoint.AutoSize = true;
            this.lblCusPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPoint.Location = new System.Drawing.Point(739, 40);
            this.lblCusPoint.Name = "lblCusPoint";
            this.lblCusPoint.Size = new System.Drawing.Size(128, 23);
            this.lblCusPoint.TabIndex = 4;
            this.lblCusPoint.Text = "Điểm tích lũy:";
            // 
            // lblCusAddress
            // 
            this.lblCusAddress.AutoSize = true;
            this.lblCusAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusAddress.Location = new System.Drawing.Point(373, 39);
            this.lblCusAddress.Name = "lblCusAddress";
            this.lblCusAddress.Size = new System.Drawing.Size(75, 23);
            this.lblCusAddress.TabIndex = 4;
            this.lblCusAddress.Text = "Địa chỉ:";
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusEmail.Location = new System.Drawing.Point(477, 108);
            this.txtCusEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(256, 30);
            this.txtCusEmail.TabIndex = 2;
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(24, 75);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(73, 23);
            this.lblCusName.TabIndex = 4;
            this.lblCusName.Text = "Họ tên:";
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustomer.Location = new System.Drawing.Point(305, 191);
            this.btnShowCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.Size = new System.Drawing.Size(90, 40);
            this.btnShowCustomer.TabIndex = 15;
            this.btnShowCustomer.Text = "Xem";
            this.btnShowCustomer.UseVisualStyleBackColor = true;
            this.btnShowCustomer.Click += new System.EventHandler(this.btnShowCustomer_Click);
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.AllowUserToAddRows = false;
            this.dtgvCustomer.AllowUserToDeleteRows = false;
            this.dtgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(305, 291);
            this.dtgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.ReadOnly = true;
            this.dtgvCustomer.RowHeadersWidth = 51;
            this.dtgvCustomer.RowTemplate.Height = 24;
            this.dtgvCustomer.Size = new System.Drawing.Size(1211, 343);
            this.dtgvCustomer.TabIndex = 14;
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.BackgroundImage = global::GUI.Properties.Resources.search_icon;
            this.btnSearchCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCus.Location = new System.Drawing.Point(317, 27);
            this.btnSearchCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(27, 26);
            this.btnSearchCus.TabIndex = 21;
            this.btnSearchCus.UseVisualStyleBackColor = true;
            this.btnSearchCus.Click += new System.EventHandler(this.btnSearchCus_Click);
            // 
            // lblDSKhachHang
            // 
            this.lblDSKhachHang.AutoSize = true;
            this.lblDSKhachHang.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblDSKhachHang.Location = new System.Drawing.Point(737, 262);
            this.lblDSKhachHang.Name = "lblDSKhachHang";
            this.lblDSKhachHang.Size = new System.Drawing.Size(340, 26);
            this.lblDSKhachHang.TabIndex = 22;
            this.lblDSKhachHang.Text = "Danh sách thông tin khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchCus);
            this.groupBox1.Controls.Add(this.txtSearchCus);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(1166, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo tên";
            // 
            // CustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDSKhachHang);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.btnShowCustomer);
            this.Controls.Add(this.dtgvCustomer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(1850, 650);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.TextBox txtSearchCus;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.NumericUpDown nudPoint;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label lblCusEmail;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblCusBirth;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label lblCusPhone;
        private System.Windows.Forms.Label lblCusPoint;
        private System.Windows.Forms.Label lblCusAddress;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Button btnShowCustomer;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Label lblDSKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmBirthDay;
    }
}
