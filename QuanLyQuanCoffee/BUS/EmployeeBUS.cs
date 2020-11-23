using QuanLyQuanCoffee.DAO;
using QuanLyQuanCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.BUS
{
    class EmployeeBUS
    {

        public static void ThemNhanVien(Employee emp)
        {
            try
            {
                EmployeeDAO.ThemNhanVien(emp);
            }
            catch (Exception e)
            {

                MessageBox.Show("Thêm nhân viên không thành công!" + e);
            }
        }

        public static void SuaNhanVien(Employee emp)
        {
            if (MessageBox.Show("Bạn muốn cập nhật nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    EmployeeDAO.SuaNhanVien(emp);
                }
                catch (Exception)
                {

                    MessageBox.Show("Cập nhật nhân viên không thành công!");
                }
            }
        }
        public static void XoaNhanVien(Employee emp)
        {
            if (MessageBox.Show("Bạn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    EmployeeDAO.XoaNhanVien(emp);
                }
                catch (Exception)
                {

                    MessageBox.Show("Xóa nhân viên không thành công!");
                }
            }
        }

    }
}
