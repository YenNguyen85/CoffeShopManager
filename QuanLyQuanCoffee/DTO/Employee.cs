using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DTO
{
    class Employee
    {
        private int id;
        private string tenNhanVien;
        private DateTime ngaySinh;
        private String diaChi;
        private string sdt;
        private string tenTaiKhoan;
        private int idChucVu;

        public Employee() { }

        public Employee(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"].ToString());
            this.TenNhanVien = row["TenNhanVien"].ToString();
            this.NgaySinh = Convert.ToDateTime(row["NgaySinh"].ToString());
            this.DiaChi = row["DiaChi"].ToString();
            this.Sdt = row["Sdt"].ToString();
            this.TenTaiKhoan = row["TenTaiKhoan"].ToString();
            this.IdChucVu = Convert.ToInt32(row["idChucVu"].ToString());
        }

        public int Id { get => id; set => id = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int IdChucVu { get => idChucVu; set => idChucVu = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
    }
}
