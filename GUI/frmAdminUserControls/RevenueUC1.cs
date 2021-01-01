using GUI.DAO;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace GUI.frmAdminUserControls
{
    public partial class RevenueUC1 : UserControl
    {
       
        public RevenueUC1()
        {
            InitializeComponent();
            LoadRevenue();
        }
        void LoadRevenue()
        {
            LoadDateTimePickerRevenue();//Set "Từ ngày" & "Đến ngày ngày" về đầu tháng & cuối tháng
            LoadRevenue(dtmFromDate.Value, dtmToDate.Value);
        }
      
        void LoadDateTimePickerRevenue()
        {
            dtmFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtmToDate.Value = dtmFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadRevenue(DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dtgvRevenue.DataSource = RevenueDAO.GetRevenue1(fromDate, toDate);
            txtDoanhThu.Text = GetSumRevenue().ToString("c", culture);
        }
        decimal GetSumRevenue()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dtgvRevenue.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tiền vé"].Value);
            }
            return sum;
        }

        private void btnReportRevenue_Click(object sender, EventArgs e)
        {
            DataTable data = RevenueDAO.GetReportRevenue1(dtmFromDate.Value, dtmToDate.Value);
            ReportRevenueByDate report = new ReportRevenueByDate();
            report.SetDataSource(data);
            frmReportByDate f = new frmReportByDate();
            f.crystalReportViewer1.ReportSource = report;
            f.ShowDialog();
        }

        private void ShowRevenue_Click(object sender, EventArgs e)
        {
            LoadRevenue(dtmFromDate.Value, dtmToDate.Value);
        }
    }
}
