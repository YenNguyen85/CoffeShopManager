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

        public static DataTable GetTTSanPham(string idMon)
        {
            string sql = "select TenLoai, TenMon, GiaTien from LoaiMon l, MonAn m where m.idLoaiMon = l.id and m.id = '"+idMon+"' ";
            return KetNoiCSDL.Query(sql);
        }

        public static void InsertSanPham(DTO.Food food)
        {
            string sql = "Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'" + food.TenMon + "', " + food.IdLoaiMon + ", " + food.GiaTien + ")";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void UpdateSanPham(DTO.Food food)
        {
            string sql = "update MONAN set TenMon = N'"+food.TenMon+"', idLoaiMon = '"+food.IdLoaiMon+"', GiaTien = '"+food.GiaTien+"' where id = '"+food.Id+"'";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void DeleteSanPham(int id)
        {
            string sql = "delete from MONAN where id = '"+id+"'";
            KetNoiCSDL.NonQuery(sql);
        }
    }
}
