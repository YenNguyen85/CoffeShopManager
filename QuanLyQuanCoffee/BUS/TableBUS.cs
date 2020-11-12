using QuanLyQuanCoffee.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
