using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DTO
{
    class Menu
    {
        private string tenMon;
        private int soLuong;
        private float giaTien;
        private float tongTien;

        public Menu(string foodName, int count, float price, float totalPrice)
        {
            this.TenMon = foodName;
            this.SoLuong = count;
            this.GiaTien = price;
            this.TongTien = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.TenMon = row["TenMon"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.GiaTien = (float)row["GiaTien"];
            this.TongTien = (float)row["TongTien"];
        }

        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
