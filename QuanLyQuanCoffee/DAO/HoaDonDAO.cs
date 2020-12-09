using QuanLyQuanCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.DAO
{
    class HoaDonDAO
    {
        // Lấy id hóa đơn hiện tại của bàn ăn (@param idTable)
        // Thành công : bill ID
        // Thất bại : -1
        public static int GetUnCheckBillIDByTableID(int idTable)
        {
            string sql = "select * from HOADON where idTable = "+idTable+" and TrangThaiHoaDon=0";
            DataTable data = KetNoiCSDL.Query(sql);

            if(data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["id"].ToString());
            }
            return -1;
        }

        public static void InsertBill(int idTable, int idNhanVien)
        {
            string sql = "insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idNhanVien, TrangThaiHoaDon)values('"+String.Format("{0:MM/dd/yyyy}",DateTime.Now)+ "', '" + String.Format("{0:MM/dd/yyyy}", DateTime.Now) + "', " + idTable + ", " + idNhanVien + ", 0)";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void UpdateStatusHoaDon(string idHoaDon, string bit)
        {
            string sql = "update HOADON set TrangThaiHoaDon = " + bit + " where id = " + idHoaDon;
            KetNoiCSDL.NonQuery(sql);
        }

        public static void UpdateTableOfHoaDon(string idTable, string idHoaDon)
        {
            string sql = "update HOADON set idTable = " + idTable + " where id = " + idHoaDon;
            KetNoiCSDL.NonQuery(sql);
        }

        public static DataTable GetAllHoaDon(string tgbatdau, string tgketthuc)
        {
            string sql = "select hd.id as HoaDon, sum(cthd.SoLuong* mon.GiaTien) as TongTien, hd.ThoiGianVao, hd.ThoiGianRa from CHITIETHOADON cthd, HOADON hd, MONAN mon where cthd.idHoaDon = hd.id and cthd.idMonAn = mon.id and hd.TrangThaiHoaDon = 1 and hd.ThoiGianRa >= '"+tgbatdau+"' and hd.ThoiGianRa <= '"+tgketthuc+"' Group by hd.id, hd.ThoiGianVao, hd.ThoiGianRa";
            return KetNoiCSDL.Query(sql);
        }
    }
}
