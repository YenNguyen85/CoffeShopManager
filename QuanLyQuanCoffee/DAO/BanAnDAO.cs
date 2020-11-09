using QuanLyQuanCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class BanAnDAO
    {
        public static DataTable GetBanAnList()
        {
            string sql = "select * from BANAN";
            return KetNoiCSDL.Query(sql);
        }
    }
}

