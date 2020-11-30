using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class CTHDDAO
    {
        public static void Insert(DTO.CTHD item)
        {
            string sql = "insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('"+item.IdHoaDon+"', '"+item.IdMonAn+"', "+item.SoLuong+")";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void Update(DTO.CTHD item)
        {
            string sql = "update CHITIETHOADON set SoLuong = SoLuong + " + item.SoLuong + " where idHoaDon = '" + item.IdHoaDon + "' and idMonAn = '" + item.IdMonAn + "'";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void Delete(string idHoaDon, string idMonAn)
        {
            string sql = "delete from CHITIETHOADON where idHoaDon = '"+idHoaDon+"' and idMonAn = '"+idMonAn+"'";
            KetNoiCSDL.NonQuery(sql);
        }

        public static DataTable GetBillItem(DTO.CTHD item)
        {
            string sql = "select * from CHITIETHOADON where idHoaDon = '"+item.IdHoaDon+"' and idMonAn = '"+item.IdMonAn+"'";
            return KetNoiCSDL.Query(sql);
        }
    }
}
