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


        //Thêm-Luu-Xoa

        public static DataTable GetMaxIDTable()
        {
            string sql = "select top 1 id from BANAN order by id desc";
            return KetNoiCSDL.Query(sql);
        }

        public static void LuuBanAN()
        {
            string sql = "insert into BANAN(TrangThaiBan) Values (0)";
            KetNoiCSDL.NonQuery(sql);
        }
        public static void XoaBanAn(Table tb)
        {
            string sql = "Delete from BANAN where id='"+tb.Id+ "' ";
            KetNoiCSDL.NonQuery(sql);
        }

    }
}

