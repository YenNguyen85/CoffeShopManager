using QuanLyQuanCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DAO
{
    class HoaDonDAO
    {
        // Lấy id hóa đơn hiện tại của bàn ăn (@param idTable)
        // Thành công : bill ID
        // Thất bại : -1
        public static int GetUnCheckBillIDByTableID(int idTable)
        {
            DataTable data = KetNoiCSDL.Query("select * from HOADON where idTable="+idTable+" and TrangThaiHoaDon=0;");

            // nếu bàn đó đang có bill
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]); 
                return bill.Id;
            }
            return -1;
        }

        public static void InsertBill(int idTable, int idNhanVien)
        {
            string sql = "insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idNhanVien, TrangThaiHoaDon)values('', '', " + idTable + ", " + idNhanVien + ", 0)";
            KetNoiCSDL.NonQuery(sql);
        }
    }
}
