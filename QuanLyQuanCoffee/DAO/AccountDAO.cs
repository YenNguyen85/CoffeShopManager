using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class AccountDAO
    {
        public static bool Login(string username, string password) // chức năng đăng nhập
        {
            string sql = "Select * from TAIKHOAN where TenNguoiDung= '"+username+"' and MatKhau = '"+password+"'";
            return KetNoiCSDL.Query(sql).Rows.Count == 1? true : false ;
        }
    }
}
