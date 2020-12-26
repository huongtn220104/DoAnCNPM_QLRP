using GUI.DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class CustomerUC : UserControl
    {
        BindingSource customerList = new BindingSource();
        public CustomerUC()
        {
            InitializeComponent();
            LoadCustomer();
        }

        void LoadCustomer()
        {
            dtgvCustomer.DataSource = customerList;
            LoadCustomerList();
            AddCustomerBinding();
        }

        void LoadCustomerList()
        {
            customerList.DataSource = CustomerDAO.GetListCustomer();
        }
        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        void AddCustomerBinding()
        {
            txtCusID.DataBindings.Add("Text", dtgvCustomer.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never);
            txtCusName.DataBindings.Add("Text", dtgvCustomer.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            dtmBirthDay.DataBindings.Add("Value", dtgvCustomer.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtCusAddress.DataBindings.Add("Text", dtgvCustomer.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtCusPhone.DataBindings.Add("Text", dtgvCustomer.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtCusEmail.DataBindings.Add("Text", dtgvCustomer.DataSource, "Email", true, DataSourceUpdateMode.Never);
            nudPoint.DataBindings.Add("Value", dtgvCustomer.DataSource, "Điểm tích lũy", true, DataSourceUpdateMode.Never);
        }

        void InsertCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            if (CustomerDAO.InsertCustomer(id, hoTen, ngaySinh, diaChi, sdt, email))
            {
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text;
            string cusName = txtCusName.Text;
            DateTime cusBirth = dtmBirthDay.Value;
            string cusAddress = txtCusAddress.Text;
            string cusPhone = txtCusPhone.Text;
            string cusEmail = txtCusEmail.Text;
            InsertCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusEmail);
            LoadCustomerList();
        }

        void UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string email, int point)
        {
            if (CustomerDAO.UpdateCustomer(id, hoTen, ngaySinh, diaChi, sdt, email, point))
            {
                MessageBox.Show("Sửa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại");
            }
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text;
            string cusName = txtCusName.Text;
            DateTime cusBirth = dtmBirthDay.Value;
            string cusAddress = txtCusAddress.Text;
            string cusPhone = txtCusPhone.Text;
            string cusEmail = txtCusEmail.Text;
            int cusPoint = (int)nudPoint.Value;
            UpdateCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusEmail, cusPoint);
            LoadCustomerList();
        }

        void DeleteCustomer(string id)
        {
            if (CustomerDAO.DeleteCustomer(id))
            {
                MessageBox.Show("Xóa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text;
            DeleteCustomer(cusID);
            LoadCustomerList();
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            string cusName = txtSearchCus.Text;
            customerList.DataSource = CustomerDAO.SearchCustomerByName(cusName);
        }

		private void txtSearchCus_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearchCus.PerformClick();
				e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
			}
		}
    }
}
