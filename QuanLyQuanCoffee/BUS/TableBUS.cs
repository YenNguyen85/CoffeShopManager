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

        public static void XoaBanAn(string id)
        {
            if (MessageBox.Show("Bạn muốn xóa bàn ăn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BanAnDAO.XoaBanAn(id);
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Xóa bàn ăn không thành công!");
                }
            }
        }
        
        // Kiểm tra trạng thái hiện tại của bàn ăn
        // false: Có người
        // true: trống
        public static bool IsEmpty(string id)
        {
            DataTable data = BanAnDAO.CheckTableStatus(id);
            DataRow row = data.Rows[0];
            return row["TrangThaiBan"].ToString() == "False";
        }

        public static List<DTO.Table> GetBanAnList(DataTable data)
        {
            List<DTO.Table> tableList = new List<DTO.Table>();

            foreach (DataRow row in data.Rows)
            {
                DTO.Table table = new DTO.Table(row);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
