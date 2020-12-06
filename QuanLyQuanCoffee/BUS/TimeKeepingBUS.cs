using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffee.BUS
{
    class TimeKeepingBUS
    {
        /**
         * Kiểm tra thông tin chấm công ngày (@param date) đã tồn tại chưa
         * @return id CHAMCONG nếu tồn tại
         *          -1 nếu không tồn tại
         * */
        public static Int32 CheckExists(string date)
        {
            int id = -1;
            DataTable data = DAO.TimeKeepingDAO.FindTimeKeeping(date);
            if (data.Rows.Count > 0)
            {
                id = Convert.ToInt32(data.Rows[0]["id"].ToString());
            }
            return id;
        }

        /**
         * Kiểm tra xem nhân viên đó đã chấm công chưa (@param idNhanVien, date)
         * @return id CHAMCONGNHANVIEN || -1
         * */
        public static Int32 CheckExistsNhanVien(string idNhanVien, string idChamCong)
        {
            int id = -1;
            DataTable data = DAO.TimeKeepingDAO.FindNhanVien(idNhanVien, idChamCong);
            if(data.Rows.Count > 0)
            {
                id = Convert.ToInt32(data.Rows[0]["id"].ToString());
            }
            return id;
            
        }
    }
}
