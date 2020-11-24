using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DTO
{
    class CTHD
    {
        private int id;
        private int idHoaDon;
        private int idMonAn;
        private int soLuong;

        public CTHD (int id, int idHoaDon, int idMonAn, int soLuong){
            this.Id = id;
            this.IdHoaDon = idHoaDon;
            this.IdMonAn = idMonAn;
            this.SoLuong = soLuong;
        }

        public CTHD(int idHoaDon, int idMonAn, int soLuong)
        {
            this.IdHoaDon = idHoaDon;
            this.IdMonAn = idMonAn;
            this.SoLuong = soLuong;
        }

        public int Id { get => id; set => id = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdMonAn { get => idMonAn; set => idMonAn = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
