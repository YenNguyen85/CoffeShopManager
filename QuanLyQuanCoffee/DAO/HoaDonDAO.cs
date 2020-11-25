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
            string sql = "insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idNhanVien, TrangThaiHoaDon)values('', '', " + idTable + ", " + idNhanVien + ", 0)";
            KetNoiCSDL.NonQuery(sql);
        }

        public static void UpdateStatusHoaDon(string idTable, string bit)
        {
            string sql = "update HOADON set TrangThaiHoaDon = " + bit + " where id = " + idTable;
            KetNoiCSDL.NonQuery(sql);
        }
    }
}
