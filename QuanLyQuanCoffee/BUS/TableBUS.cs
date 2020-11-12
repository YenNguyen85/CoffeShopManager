using QuanLyQuanCoffee.DAO;
using QuanLyQuanCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.BUS
{
    class TableBUS
    {
        public static int GetNextIdTable()
        {
            DataTable data = new DataTable();
            data = BanAnDAO.GetMaxIDTable();
            return (int)data.Rows[0]["id"] + 1;
        }
        public static void XoaBanAn(Table tb)
        {
            if (MessageBox.Show("Bạn muốn xóa bàn ăn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BanAnDAO.XoaBanAn(tb);
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Xóa bàn ăn không thành công!");
                }
            }
        }
    }
}
