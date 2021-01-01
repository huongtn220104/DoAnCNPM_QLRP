using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class RevenueControl : UserControl
    {
        public RevenueControl()
        {
            InitializeComponent();
        }

        private void btnTheoPhim_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnTheoPhim.Height;
            SlidePanel.Top = btnTheoPhim.Top;
            panelData.Controls.Clear();
            RevenueUC revenueUc = new RevenueUC();
            revenueUc.Dock = DockStyle.Fill;
            panelData.Controls.Add(revenueUc);
        }

        private void btnTheoThoiGian_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btnTheoThoiGian.Height;
            SlidePanel.Top = btnTheoThoiGian.Top;
            panelData.Controls.Clear();
            RevenueUC1 revenueUc = new RevenueUC1();
            revenueUc.Dock = DockStyle.Fill;
            panelData.Controls.Add(revenueUc);
        }
    }
}
