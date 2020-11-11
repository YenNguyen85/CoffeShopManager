using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DTO
{
    class Bill
    {
        private int id;
        private DateTime? thoiGianVao;
        private DateTime? thoiGianRa;
        private int idTable;
        private int idKhuyenMai;
        private int idNhanVien;
        private string trangThaiHoaDon;
        

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.ThoiGianVao = (DateTime?)row["ThoiGianVao"];
            this.ThoiGianRa = (DateTime?)row["ThoiGianRa"];
            this.IdTable = (int)row["idTable"];
            this.IdKhuyenMai = (int)row["idKhuyenMai"]; // coi chừng lỗi
            this.IdNhanVien = (int)row["idNhanVien"];
            this.TrangThaiHoaDon = row["TrangThaiHoaDon"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public DateTime? ThoiGianVao { get => thoiGianVao; set => thoiGianVao = value; }
        public DateTime? ThoiGianRa { get => thoiGianRa; set => thoiGianRa = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int IdKhuyenMai { get => idKhuyenMai; set => idKhuyenMai = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public string TrangThaiHoaDon { get => trangThaiHoaDon; set => trangThaiHoaDon = value; }
    }
}
