using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class LoaiTKDAO
    {
        public static DataTable GetData()
        {
            string sql = "select * from LOAITK";
            return KetNoiCSDL.Query(sql);
        }
    }
}
