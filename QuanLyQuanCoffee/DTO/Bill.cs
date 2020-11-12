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
            this.Id = Convert.ToInt32(row["id"].ToString());
            this.ThoiGianVao = (DateTime?)row["ThoiGianVao"];
            this.ThoiGianRa = (DateTime?)row["ThoiGianRa"];
            this.IdTable = (int)row["idTable"];
            this.IdKhuyenMai = row["idKhuyenMai"].ToString() == ""? 0 : Convert.ToInt32(row["idKhuyenMai"].ToString()); // coi chừng lỗi
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
