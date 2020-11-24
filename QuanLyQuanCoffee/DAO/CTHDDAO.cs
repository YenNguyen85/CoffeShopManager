using System;
using System.Collections.Generic;
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
    }
}
