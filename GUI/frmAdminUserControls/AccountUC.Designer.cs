﻿namespace GUI.frmAdminUserControls
{
    partial class AccountUC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnInsertAccount = new System.Windows.Forms.Button();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.nudAccountType = new System.Windows.Forms.NumericUpDown();
            this.cboStaffID_Account = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtStaffName_Account = new System.Windows.Forms.TextBox();
            this.lblStaffName_Account = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblStaffID_Account = new System.Windows.Forms.Label();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.toolTipAccountType = new System.Windows.Forms.ToolTip(this.components);
            this.lblDSTaiKhoan = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchAccount);
            this.groupBox1.Controls.Add(this.btnSearchAccount);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1166, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(350, 70);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo tên";
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccount.Location = new System.Drawing.Point(11, 25);
            this.txtSearchAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(302, 30);
            this.txtSearchAccount.TabIndex = 18;
            this.txtSearchAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchAccount_KeyDown);
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.BackgroundImage = global::GUI.Properties.Resources.search_icon;
            this.btnSearchAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAccount.Location = new System.Drawing.Point(317, 27);
            this.btnSearchAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(27, 26);
            this.btnSearchAccount.TabIndex = 19;
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.Location = new System.Drawing.Point(1023, 111);
            this.btnResetPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(136, 49);
            this.btnResetPass.TabIndex = 24;
            this.btnResetPass.Text = "Reset mật khẩu";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteAccount.Location = new System.Drawing.Point(924, 175);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(90, 40);
            this.btnDeleteAccount.TabIndex = 25;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdateAccount.Location = new System.Drawing.Point(808, 175);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(90, 40);
            this.btnUpdateAccount.TabIndex = 26;
            this.btnUpdateAccount.Text = "Sửa";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnInsertAccount
            // 
            this.btnInsertAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInsertAccount.Location = new System.Drawing.Point(680, 175);
            this.btnInsertAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertAccount.Name = "btnInsertAccount";
            this.btnInsertAccount.Size = new System.Drawing.Size(90, 40);
            this.btnInsertAccount.TabIndex = 27;
            this.btnInsertAccount.Text = "Thêm";
            this.btnInsertAccount.UseVisualStyleBackColor = true;
            this.btnInsertAccount.Click += new System.EventHandler(this.btnInsertAccount_Click);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShowAccount.Location = new System.Drawing.Point(305, 175);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(90, 40);
            this.btnShowAccount.TabIndex = 23;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.Controls.Add(this.nudAccountType);
            this.grpAccount.Controls.Add(this.cboStaffID_Account);
            this.grpAccount.Controls.Add(this.lblUsername);
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.txtStaffName_Account);
            this.grpAccount.Controls.Add(this.lblStaffName_Account);
            this.grpAccount.Controls.Add(this.lblAccountType);
            this.grpAccount.Controls.Add(this.lblStaffID_Account);
            this.grpAccount.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpAccount.Location = new System.Drawing.Point(305, 27);
            this.grpAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccount.Size = new System.Drawing.Size(682, 133);
            this.grpAccount.TabIndex = 22;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Thông tin tài khoản";
            // 
            // nudAccountType
            // 
            this.nudAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAccountType.Location = new System.Drawing.Point(425, 36);
            this.nudAccountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAccountType.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAccountType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.Name = "nudAccountType";
            this.nudAccountType.Size = new System.Drawing.Size(239, 30);
            this.nudAccountType.TabIndex = 6;
            this.toolTipAccountType.SetToolTip(this.nudAccountType, "1 : Quản trị hệ thống\r\n2 : Nhân viên bán vé");
            this.nudAccountType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboStaffID_Account
            // 
            this.cboStaffID_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaffID_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffID_Account.FormattingEnabled = true;
            this.cboStaffID_Account.Location = new System.Drawing.Point(136, 81);
            this.cboStaffID_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStaffID_Account.Name = "cboStaffID_Account";
            this.cboStaffID_Account.Size = new System.Drawing.Size(162, 30);
            this.cboStaffID_Account.TabIndex = 5;
            this.cboStaffID_Account.SelectedIndexChanged += new System.EventHandler(this.cboStaffID_Account_SelectedIndexChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(24, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(137, 36);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(161, 30);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtStaffName_Account
            // 
            this.txtStaffName_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName_Account.Location = new System.Drawing.Point(425, 82);
            this.txtStaffName_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffName_Account.Name = "txtStaffName_Account";
            this.txtStaffName_Account.ReadOnly = true;
            this.txtStaffName_Account.Size = new System.Drawing.Size(239, 30);
            this.txtStaffName_Account.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            this.lblStaffName_Account.AutoSize = true;
            this.lblStaffName_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName_Account.Location = new System.Drawing.Point(323, 85);
            this.lblStaffName_Account.Name = "lblStaffName_Account";
            this.lblStaffName_Account.Size = new System.Drawing.Size(80, 23);
            this.lblStaffName_Account.TabIndex = 4;
            this.lblStaffName_Account.Text = "Tên NV:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(321, 39);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(87, 23);
            this.lblAccountType.TabIndex = 4;
            this.lblAccountType.Text = "Loại TK:";
            // 
            // lblStaffID_Account
            // 
            this.lblStaffID_Account.AutoSize = true;
            this.lblStaffID_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID_Account.Location = new System.Drawing.Point(24, 85);
            this.lblStaffID_Account.Name = "lblStaffID_Account";
            this.lblStaffID_Account.Size = new System.Drawing.Size(76, 23);
            this.lblStaffID_Account.TabIndex = 4;
            this.lblStaffID_Account.Text = "Mã NV:";
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.AllowUserToDeleteRows = false;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(305, 279);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.Size = new System.Drawing.Size(1211, 343);
            this.dtgvAccount.TabIndex = 21;
            // 
            // lblDSTaiKhoan
            // 
            this.lblDSTaiKhoan.AutoSize = true;
            this.lblDSTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblDSTaiKhoan.Location = new System.Drawing.Point(791, 251);
            this.lblDSTaiKhoan.Name = "lblDSTaiKhoan";
            this.lblDSTaiKhoan.Size = new System.Drawing.Size(220, 26);
            this.lblDSTaiKhoan.TabIndex = 29;
            this.lblDSTaiKhoan.Text = "Danh sách tài khoản";
            // 
            // AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDSTaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.btnInsertAccount);
            this.Controls.Add(this.btnShowAccount);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.dtgvAccount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountUC";
            this.Size = new System.Drawing.Size(1850, 650);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnInsertAccount;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.NumericUpDown nudAccountType;
        private System.Windows.Forms.ComboBox cboStaffID_Account;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtStaffName_Account;
        private System.Windows.Forms.Label lblStaffName_Account;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblStaffID_Account;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.ToolTip toolTipAccountType;
		private System.Windows.Forms.Label lblDSTaiKhoan;
	}
}
