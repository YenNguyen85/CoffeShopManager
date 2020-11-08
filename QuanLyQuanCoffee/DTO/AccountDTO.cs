using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DTO
{
    class AccountDTO
    {       
        private string tenNguoiDung;
        private string tenHienThi;
        private int loaiTK;

        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }
        public int LoaiTK { get => loaiTK; set => loaiTK = value; }
    }
}
