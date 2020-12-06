using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class TimeKeepingDAO
    {   
        // Chỉ lấy thông tin trong bảng CHAMCONG
        public static DataTable FindTimeKeeping(string date)
        {
            string sql = "select * from CHAMCONG where Ngay='"+date+"'";
            return KetNoiCSDL.Query(sql);
        }

        // Lấy thông tin từ nhiều bảng
        public static DataTable FindTimeKeepingByDate(string date)
        {
            string sql = "select nv.TenNhanVien, ccnv.GioBatDau, ccnv.GioKetThuc from CHAMCONG cc, CHAMCONGNHANVIEN ccnv, NHANVIEN nv where cc.id = ccnv.idChamCong and ccnv.idNhanVien = nv.id and cc.Ngay = '" + date + "'";
            return KetNoiCSDL.Query(sql);
        }

        public static DataTable FindNhanVien(string idNhanVien, string idChamCong)
        {
            string sql = "select * from CHAMCONGNHANVIEN where idNhanVien = '"+idNhanVien+"' and idChamCong ='"+idChamCong+"'";
            return KetNoiCSDL.Query(sql);
        }

        public static void Save(string date)
        {
            string sql = "insert into CHAMCONG (Ngay) values ('" + date + "')";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void Save(string idChamCong, string idNhanVien, string GioBatDau, string GioKetThuc)
        {
            string sql = "insert into CHAMCONGNHANVIEN (idChamCong, idNhanVien, GioBatDau, GioKetThuc) values ('"+idChamCong+"', '"+idNhanVien+"', '"+GioBatDau+"', '"+GioKetThuc+"')";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void Update(string idChamCong, string idNhanVien, string GioKetThuc)
        {
            string sql = "update CHAMCONGNHANVIEN set GioKetThuc='"+GioKetThuc+"' where idChamCong = '"+idChamCong+"' and idNhanVien= '"+idNhanVien+"'";
            KetNoiCSDL.NonQuery(sql);
        }
    }
}
