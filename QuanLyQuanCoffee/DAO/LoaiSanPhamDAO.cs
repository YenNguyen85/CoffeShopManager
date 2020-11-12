using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class LoaiSanPhamDAO
    {
        public static DataTable GetLoaiSP()
        {
            string sql = "select * from LOAIMON";
            return KetNoiCSDL.Query(sql);
        }

       
    }
}
