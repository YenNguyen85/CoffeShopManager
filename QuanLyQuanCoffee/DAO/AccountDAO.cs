using QuanLyQuanCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.DAO
{
    class AccountDAO
    {

        public static DataTable GetTTAccount()
        {
            string sql = "select tk.TenNguoiDung, tk.TenHienThi, loai.TenLoaiTK from TAIKHOAN tk, LOAITK loai where tk.LoaiTK=loai.idLoaiTK";
            return KetNoiCSDL.Query(sql);
        }
        
        //public static bool Login(string username, string password) // chức năng đăng nhập
        //{
        //    string sql = "Select * from TAIKHOAN where TenNguoiDung= '"+username+"' and MatKhau = '"+password+"'";
        //    return KetNoiCSDL.Query(sql).Rows.Count == 1? true : false ;
        //}

        public static bool CheckExistsTenNguoiDung(string username)
        {
            string sql = "select * from TAIKHOAN where TenNguoiDung = '" + username + "'";
            DataTable data = KetNoiCSDL.Query(sql);
            if (data.Rows.Count < 1)
            {
                return false;
            }
            return true;
        }

        public static string GetTenNguoiDung(string username, string password)
        {
            string id = "";
            string sql = "Select * from TAIKHOAN where TenNguoiDung= '" + username + "' and MatKhau = '" + password + "'";
            try
            {
                DataTable data = KetNoiCSDL.Query(sql);
                if (data != null)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        id = row["TenNguoiDung"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !" + ex);
            }
            return id;
        }

        //nếu trả về true thì người dùng có quyền sử dụng
        public static bool GetAuthority(string username)
        {
            bool result = false;
            string sql = "Select loai.TenLoaiTK from TAIKHOAN tk, LOAITK loai where tk.LoaiTK=loai.idLoaiTK and TenNguoiDung = '"+username+"'";
            try
            {
                DataTable data = KetNoiCSDL.Query(sql);
                foreach (DataRow row in data.Rows)
                {
                    if ("Admin" == row["TenLoaiTK"].ToString())
                        result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            return result;
        }


        //Thêm-xóa-sửa
        public static void ThemTK(Account acc)
        {
            string sql = "INSERT INTO TAIKHOAN (TenNguoiDung, TenHienThi, LoaiTK) VALUES ('"+acc.TenNguoiDung+"', N'"+acc.TenHienThi+"', N'"+acc.LoaiTK+"' ) ";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void SuaTK(Account acc)
        {
            string sql = "Update TAIKHOAN set TenHienThi=N'" + acc.TenHienThi + "', LoaiTK= N'" + acc.LoaiTK + "' where TenNguoiDung='" + acc.TenNguoiDung + "' ";
            KetNoiCSDL.NonQuery(sql);
        }
        public static void XoaTK(Account acc)
        {
            string sql = "Delete from TAIKHOAN where TenNguoiDung='" + acc.TenNguoiDung + "' ";
            KetNoiCSDL.NonQuery(sql);
        }
    }
}
