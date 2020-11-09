using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DTO
{
    class BanAnDTO
    {
        private int id;
        private string tenban;
        private string trangthaiban;

        public int Id { get => id; set => id = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthaiban { get => trangthaiban; set => trangthaiban = value; }
    }
}
