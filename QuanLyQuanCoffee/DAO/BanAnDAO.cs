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
        public static List<DTO.Table> GetBanAnList()
        {
            List<DTO.Table> tableList = new List<DTO.Table>();
            string sql = "select * from BANAN";

            DataTable data = KetNoiCSDL.Query(sql);
            
            foreach(DataRow row in data.Rows)
            {
                DTO.Table table = new DTO.Table(row);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}

