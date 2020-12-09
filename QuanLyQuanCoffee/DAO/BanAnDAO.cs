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
        public static DataTable GetDataTable()
        {
            string sql = "select * from BANAN";
            return KetNoiCSDL.Query(sql);
        }

        public static DataTable CheckTableStatus(string id)
        {
            string sql = "select * from BANAN where id = '" + id + "'";
            return KetNoiCSDL.Query(sql);
        }

        // Thay đổi trạng thái bàn
        public static void ChangeTableStatus(string id, string bit)
        {
            string sql = "update BANAN set TrangThaiBan = '" + bit + "' where id = '" + id + "'";
            KetNoiCSDL.NonQuery(sql);
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
        public static void XoaBanAn(string id)
        {
            string sql = "Delete from BANAN where id='"+id+ "' ";
            KetNoiCSDL.NonQuery(sql);
        }

    }
}

