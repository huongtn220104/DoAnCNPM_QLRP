namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class GenreUC
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
            this.panel40 = new System.Windows.Forms.Panel();
            this.btnShowGenre = new System.Windows.Forms.Button();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnInsertGenre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvGenre = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGenreDesc = new System.Windows.Forms.TextBox();
            this.lblGenreDesc = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.txtGenreID = new System.Windows.Forms.TextBox();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel40.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.btnShowGenre);
            this.panel40.Controls.Add(this.btnUpdateGenre);
            this.panel40.Controls.Add(this.btnDeleteGenre);
            this.panel40.Controls.Add(this.btnInsertGenre);
            this.panel40.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel40.Location = new System.Drawing.Point(0, 0);
            this.panel40.Margin = new System.Windows.Forms.Padding(4);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(1548, 64);
            this.panel40.TabIndex = 10;
            // 
            // btnShowGenre
            // 
            this.btnShowGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowGenre.Location = new System.Drawing.Point(328, 4);
            this.btnShowGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowGenre.Name = "btnShowGenre";
            this.btnShowGenre.Size = new System.Drawing.Size(100, 57);
            this.btnShowGenre.TabIndex = 3;
            this.btnShowGenre.Text = "Xem";
            this.btnShowGenre.UseVisualStyleBackColor = true;
            this.btnShowGenre.Click += new System.EventHandler(this.btnShowGenre_Click);
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGenre.Location = new System.Drawing.Point(220, 4);
            this.btnUpdateGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(100, 57);
            this.btnUpdateGenre.TabIndex = 2;
            this.btnUpdateGenre.Text = "Sửa";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGenre.Location = new System.Drawing.Point(112, 4);
            this.btnDeleteGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(100, 57);
            this.btnDeleteGenre.TabIndex = 1;
            this.btnDeleteGenre.Text = "Xóa";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnInsertGenre
            // 
            this.btnInsertGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertGenre.Location = new System.Drawing.Point(4, 4);
            this.btnInsertGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertGenre.Name = "btnInsertGenre";
            this.btnInsertGenre.Size = new System.Drawing.Size(100, 57);
            this.btnInsertGenre.TabIndex = 0;
            this.btnInsertGenre.Text = "Thêm";
            this.btnInsertGenre.UseVisualStyleBackColor = true;
            this.btnInsertGenre.Click += new System.EventHandler(this.btnInsertGenre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvGenre);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 574);
            this.panel1.TabIndex = 11;
            // 
            // dtgvGenre
            // 
            this.dtgvGenre.AllowUserToAddRows = false;
            this.dtgvGenre.AllowUserToDeleteRows = false;
            this.dtgvGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvGenre.Location = new System.Drawing.Point(0, 0);
            this.dtgvGenre.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvGenre.Name = "dtgvGenre";
            this.dtgvGenre.ReadOnly = true;
            this.dtgvGenre.RowHeadersWidth = 51;
            this.dtgvGenre.Size = new System.Drawing.Size(1014, 574);
            this.dtgvGenre.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblGenreID);
            this.panel2.Controls.Add(this.txtGenreID);
            this.panel2.Controls.Add(this.lblGenreName);
            this.panel2.Controls.Add(this.txtGenreName);
            this.panel2.Controls.Add(this.lblGenreDesc);
            this.panel2.Controls.Add(this.txtGenreDesc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1014, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 574);
            this.panel2.TabIndex = 0;
            // 
            // txtGenreDesc
            // 
            this.txtGenreDesc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtGenreDesc.Location = new System.Drawing.Point(92, 125);
            this.txtGenreDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenreDesc.Multiline = true;
            this.txtGenreDesc.Name = "txtGenreDesc";
            this.txtGenreDesc.Size = new System.Drawing.Size(413, 156);
            this.txtGenreDesc.TabIndex = 1;
            // 
            // lblGenreDesc
            // 
            this.lblGenreDesc.AutoSize = true;
            this.lblGenreDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreDesc.Location = new System.Drawing.Point(16, 125);
            this.lblGenreDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreDesc.Name = "lblGenreDesc";
            this.lblGenreDesc.Size = new System.Drawing.Size(76, 24);
            this.lblGenreDesc.TabIndex = 0;
            this.lblGenreDesc.Text = "Mô tả :";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtGenreName.Location = new System.Drawing.Point(171, 73);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(334, 30);
            this.txtGenreName.TabIndex = 1;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreName.Location = new System.Drawing.Point(16, 79);
            this.lblGenreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(134, 24);
            this.lblGenreName.TabIndex = 0;
            this.lblGenreName.Text = "Tên thể loại :";
            // 
            // txtGenreID
            // 
            this.txtGenreID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtGenreID.Location = new System.Drawing.Point(171, 24);
            this.txtGenreID.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.Size = new System.Drawing.Size(334, 30);
            this.txtGenreID.TabIndex = 1;
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreID.Location = new System.Drawing.Point(16, 30);
            this.lblGenreID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(126, 24);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Mã thể loại :";
            // 
            // GenreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel40);
            this.Name = "GenreUC";
            this.Size = new System.Drawing.Size(1548, 638);
            this.panel40.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Button btnShowGenre;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnInsertGenre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGenreDesc;
        private System.Windows.Forms.Label lblGenreDesc;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.TextBox txtGenreID;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.DataGridView dtgvGenre;
    }
}
