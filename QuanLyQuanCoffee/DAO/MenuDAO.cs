using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class MenuDAO
    {
        public static List<DTO.Menu> GetMenuListByTable(int id)
        {
            List<DTO.Menu> menus = new List<DTO.Menu>();

            string sql = "select mon.TenMon, cthd.SoLuong, mon.GiaTien, cthd.SoLuong*GiaTien as TongTien from CHITIETHOADON cthd, HOADON hd, MONAN mon where cthd.idHoaDon = hd.id and cthd.idMonAn = mon.id and hd.TrangThaiHoaDon=0 and hd.idTable= " + id;
            DataTable data = KetNoiCSDL.Query(sql);
            foreach(DataRow row in data.Rows)
            {
                DTO.Menu menu = new DTO.Menu(row);
                menus.Add(menu);
            }
            return menus;
        }
    }
}
