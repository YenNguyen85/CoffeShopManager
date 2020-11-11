using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.DTO
{
    class Food
    {
        private int id;
        private string tenMon;
        private int idLoaiMon;
        private float giaTien;

        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.TenMon = row["TenMon"].ToString();
            this.IdLoaiMon = (int)row["idLoaiMon"];
            this.GiaTien = (float)row["GiaTien"];
        }

        public int Id { get => id; set => id = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int IdLoaiMon { get => idLoaiMon; set => idLoaiMon = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
    }
}
