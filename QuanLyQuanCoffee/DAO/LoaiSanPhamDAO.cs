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

        public static void InsertLoaiSP(string tenLoai)
        {
            string sql = "Insert into LOAIMON(TenLoai) Values (N'"+tenLoai+"')";
            KetNoiCSDL.NonQuery(sql);
        }
       
        public static void UpdateLoaiSP(DTO.Category loai)
        {
            string sql = "update LOAIMON set TenLoai = N'" + loai.TenLoai + "' where id = '" + loai.Id + "'";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void DeleteLoaiSP(string id)
        {
            string sql = "delete from LOAIMON where id = '" + id + "'";
            KetNoiCSDL.NonQuery(sql);
        }
    }
}
