using GUI.DAO;
using GUI.DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSeller : Form
    {
        public frmSeller()
        {
            InitializeComponent();
            dtmThoiGian.Value = DateTime.Now;
            LoadMovie(dtmThoiGian.Value);
        }

        private void frmSeller_Load(object sender, EventArgs e)
        {
            LoadMovie(dtmThoiGian.Value);
            timer1.Start();
        }

        private void LoadMovie(DateTime date)
        {
            cboPhim.DataSource = MovieDAO.GetListMovieByDate(date);
            cboPhim.DisplayMember = "Name";
        }

        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhim.SelectedIndex != -1)
            {
                cboDinhDang.DataSource = null;
                lvLichChieu.Items.Clear();
                Movie movie = cboPhim.SelectedItem as Movie;
                cboDinhDang.DataSource = FormatMovieDAO.GetListFormatMovieByMovie(movie.ID);
                cboDinhDang.DisplayMember = "ScreenTypeName";
            }
        }

        private void cboDinhDang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDinhDang.SelectedIndex != -1)
            {
                lvLichChieu.Items.Clear();
                FormatMovie format = cboDinhDang.SelectedItem as FormatMovie;
                LoadListShowTimeByFilm(format.ID);
            }
        }

        private void LoadListShowTimeByFilm(string formatMovieID)
        {
            DataTable data = ShowTimesDAO.GetListShowTimeByFormatMovie(formatMovieID, dtmThoiGian.Value);
            //if (data == null) return;
            foreach (DataRow row in data.Rows)
            {
                ShowTimes showTimes = new ShowTimes(row);
                ListViewItem lvi = new ListViewItem("");
                lvi.SubItems.Add(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToShortTimeString());
                lvi.Tag = showTimes;

                string statusShowTimes = TicketDAO.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    + "/" + TicketDAO.CountToltalTicketByShowTime(showTimes.ID);

                lvi.SubItems.Add(statusShowTimes);

                float status = (float)TicketDAO.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    / TicketDAO.CountToltalTicketByShowTime(showTimes.ID);

                //thêm ảnh status
                if (status == 1)
                    lvi.ImageIndex = 2;
                else if (status > 0.5f)
                    lvi.ImageIndex = 1;
                else lvi.ImageIndex = 0;

                lvLichChieu.Items.Add(lvi);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Load lại form để cập nhật cơ sở dữ liệu
            this.OnLoad(null);
        }

        private void lvLichChieu_Click(object sender, EventArgs e)
        {
            if (lvLichChieu.SelectedItems.Count > 0)
            {
                timer1.Stop();
                ShowTimes showTimes = lvLichChieu.SelectedItems[0].Tag as ShowTimes;
                Movie movie = cboPhim.SelectedItem as Movie;
                frmTheatre frm = new frmTheatre(showTimes, movie);
                this.Hide();
                frm.ShowDialog();
                this.OnLoad(null);
                this.Show();
            }
        }

        private void dtmThoiGian_ValueChanged(object sender, EventArgs e)
        {
            LoadMovie(dtmThoiGian.Value);
        }

    }
}
