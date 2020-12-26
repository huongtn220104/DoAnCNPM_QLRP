using GUI.DAO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class StaffUC : UserControl
    {
        BindingSource staffList = new BindingSource();

        public StaffUC()
        {
            InitializeComponent();
            LoadStaff();
        }
        void LoadStaff()
        {
            dtgvStaff.DataSource = staffList;
            LoadStaffList();
            AddStaffBinding();
        }

        void LoadStaffList()
        {
            staffList.DataSource = StaffDAO.GetListStaff();
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }
        void AddStaffBinding()
        {
            txtStaffId.DataBindings.Add("Text", dtgvStaff.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never);
            txtStaffName.DataBindings.Add("Text", dtgvStaff.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            dtmBirthDay.DataBindings.Add("Value", dtgvStaff.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtStaffAddress.DataBindings.Add("Text", dtgvStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtStaffPhone.DataBindings.Add("Text", dtgvStaff.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtStaffINumber.DataBindings.Add("Text", dtgvStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            txtStaffPosition.DataBindings.Add("Text", dtgvStaff.DataSource, "Chức vụ", true, DataSourceUpdateMode.Never);
        }


        //Thêm Staff
        void AddStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd, string chucvu)
        {
            if (StaffDAO.InsertStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd, chucvu))
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string staffName = txtStaffName.Text;
            DateTime staffBirth = dtmBirthDay.Value;
            string staffAddress = txtStaffAddress.Text;
            string staffPhone = txtStaffPhone.Text;
            int staffINumber = Int32.Parse(txtStaffINumber.Text);
            string staffPosition = txtStaffPosition.Text;
            AddStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber, staffPosition);
            LoadStaffList();
        }

        //Sửa Staff
        void UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd, string chucVu)
        {
            if (StaffDAO.UpdateStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd, chucVu))
            {
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string staffName = txtStaffName.Text;
            DateTime staffBirth = dtmBirthDay.Value;
            string staffAddress = txtStaffAddress.Text;
            string staffPhone = txtStaffPhone.Text;
            int staffINumber = Int32.Parse(txtStaffINumber.Text);
            string staffPosition = txtStaffPosition.Text;
            UpdateStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber, staffPosition);
            LoadStaffList();
        }

        //Xóa Staff
        void DeleteStaff(string id)
        {
            if (StaffDAO.DeleteStaff(id))
            {
                MessageBox.Show("Xóa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            DeleteStaff(staffId);
            LoadStaffList();
        }

        //Tìm kiếm Staff
        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string staffName = txtSearchStaff.Text;
            DataTable staffSearchList = StaffDAO.SearchStaffByName(staffName);
            staffList.DataSource = staffSearchList;
        }

        private void txtSearchStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchStaff.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        }
    }
}
