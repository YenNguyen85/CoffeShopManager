using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class SanPhamDAO
    {
        public static DataTable GetSanPham(string idLoai)
        {
            string sql = "select * from MONAN sp where sp.idLoaiMon = "+idLoai+"";
            return KetNoiCSDL.Query(sql);
        }

    }
}
