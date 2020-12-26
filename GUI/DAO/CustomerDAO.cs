using System;
using System.Data;
using System.Linq;

namespace GUI.DAO
{
    public class CustomerDAO
    {
        public static DataTable GetCustomerMember(string customerID, string name)
        {
            string query = "Select * from KhachHang where id = '" + customerID + "' and HoTen = N'" + name + "'";
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable GetListCustomer()
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetCustomer");
        }

        public static bool InsertCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string email)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertCustomer @idCus , @hoTen , @ngaySinh , @diaChi , @sdt , @email ", new object[] { id, hoTen, ngaySinh, diaChi, sdt, email });
            return result > 0;
        }

        public static bool UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string email, int point)
        {
            string command = string.Format("UPDATE dbo.KhachHang SET HoTen = N'{0}', NgaySinh = '{1}', DiaChi = N'{2}', SDT = '{3}', email = '{4}', DiemTichLuy = '{5}' WHERE id = '{6}'", hoTen, ngaySinh, diaChi, sdt, email, point, id);
            int result = DataProvider.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool UpdatePointCustomer(string id, int point)
        {
            string command = string.Format("UPDATE dbo.KhachHang SET  DiemTichLuy = {0} WHERE id = '{1}'", point, id);
            int result = DataProvider.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteCustomer(string id)
        {
            int result = DataProvider.ExecuteNonQuery("DELETE dbo.KhachHang WHERE id = '" + id + "'");
            return result > 0;
        }

        public static DataTable SearchCustomerByName(string name)
        {
            return DataProvider.ExecuteQuery("EXEC USP_SearchCustomer @hoTen", new object[] { name });
        }
    }
}
