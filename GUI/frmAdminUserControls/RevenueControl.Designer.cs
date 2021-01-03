namespace GUI.frmAdminUserControls
{
    partial class RevenueControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTheoThoiGian = new System.Windows.Forms.Button();
            this.btnTheoPhim = new System.Windows.Forms.Button();
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnTheoThoiGian);
            this.panel1.Controls.Add(this.btnTheoPhim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 640);
            this.panel1.TabIndex = 0;
            // 
            // btnTheoThoiGian
            // 
            this.btnTheoThoiGian.FlatAppearance.BorderSize = 0;
            this.btnTheoThoiGian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheoThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnTheoThoiGian.ForeColor = System.Drawing.Color.White;
            this.btnTheoThoiGian.Location = new System.Drawing.Point(14, 140);
            this.btnTheoThoiGian.Name = "btnTheoThoiGian";
            this.btnTheoThoiGian.Size = new System.Drawing.Size(270, 66);
            this.btnTheoThoiGian.TabIndex = 1;
            this.btnTheoThoiGian.Text = "     Tổng doanh thu bán vé";
            this.btnTheoThoiGian.UseVisualStyleBackColor = true;
            this.btnTheoThoiGian.Click += new System.EventHandler(this.btnTheoThoiGian_Click);
            // 
            // btnTheoPhim
            // 
            this.btnTheoPhim.FlatAppearance.BorderSize = 0;
            this.btnTheoPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheoPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnTheoPhim.ForeColor = System.Drawing.Color.White;
            this.btnTheoPhim.Location = new System.Drawing.Point(14, 68);
            this.btnTheoPhim.Name = "btnTheoPhim";
            this.btnTheoPhim.Size = new System.Drawing.Size(270, 66);
            this.btnTheoPhim.TabIndex = 1;
            this.btnTheoPhim.Text = "Doanh thu theo phim";
            this.btnTheoPhim.UseVisualStyleBackColor = true;
            this.btnTheoPhim.Click += new System.EventHandler(this.btnTheoPhim_Click);
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SlidePanel.Location = new System.Drawing.Point(3, 63);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(13, 66);
            this.SlidePanel.TabIndex = 1;
            // 
            // panelData
            // 
            this.panelData.Location = new System.Drawing.Point(289, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1261, 637);
            this.panelData.TabIndex = 2;
            // 
            // RevenueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.SlidePanel);
            this.Controls.Add(this.panel1);
            this.Name = "RevenueControl";
            this.Size = new System.Drawing.Size(1369, 640);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTheoThoiGian;
        private System.Windows.Forms.Button btnTheoPhim;
        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.Panel panelData;
    }
}
