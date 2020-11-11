using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DTO
{
    class Table
    {
        private int id;
        private string trangthaiban;

        public Table(DataRow row)
        {
            this.id = (int)row["id"];
            this.trangthaiban = row["TrangThaiBan"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Trangthaiban { get => trangthaiban; set => trangthaiban = value; }
    }
}
