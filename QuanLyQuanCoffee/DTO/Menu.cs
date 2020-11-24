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
        private double giaTien;
        private double tongTien;

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
            this.GiaTien = Convert.ToDouble(row["GiaTien"].ToString());
            this.TongTien = Convert.ToDouble(row["TongTien"].ToString());
        }

        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
    }
}
