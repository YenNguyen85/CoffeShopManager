using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class SalaryDAO
    {
        public static DataTable FindAllSalaryFromDateToDate(string start, string end)
        {
            string sql = "select nv.id, nv.TenNhanVien, cv.TenChucVu, ccnv.GioBatDau, ccnv.GioKetThuc, cv.Luong, cc.Ngay, (DATEDIFF(HOUR, ccnv.GioBatDau , ccnv.GioKetThuc) * cv.Luong) as TongLuongTrongNgay from NHANVIEN nv, CHAMCONG cc, CHAMCONGNHANVIEN ccnv, CHUCVU cv where nv.id = ccnv.idNhanVien and cc.id = ccnv.idChamCong and nv.idChucVu = cv.id and cc.Ngay >= '" + start+"' and cc.Ngay <= '"+end+"'";
            return KetNoiCSDL.Query(sql);
        }
    }
}
