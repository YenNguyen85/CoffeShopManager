using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DTO
{
    class Category
    {
        private int id;
        private string tenLoai;

        public Category() { }

        public Category(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"].ToString());
            this.TenLoai = row["TenLoai"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
