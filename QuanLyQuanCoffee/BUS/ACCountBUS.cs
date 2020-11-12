using QuanLyQuanCoffee.DAO;
using QuanLyQuanCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.BUS
{
    class AccountBUS
    {
        public static void ThemTK(Account acc)
        {
            try
            {
                AccountDAO.ThemTK(acc);             
            }
            catch (Exception e)
            {

                MessageBox.Show("Thêm tài khoản không thành công!" + e);
            }
        }

        public static void SuaTK(Account acc)
        {
            if(MessageBox.Show("Bạn muốn cập nhật tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    AccountDAO.SuaTK(acc);
                }
                catch (Exception)
                {

                    MessageBox.Show("Sửa tài khoản không thành công!");
                }
            }            
        }
        public static void XoaTK(Account acc)
        {
            if (MessageBox.Show("Bạn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    AccountDAO.XoaTK(acc);
                }
                catch (Exception)
                {

                    MessageBox.Show("Xóa tài khoản không thành công!");
                }
            }
        }


    }
}
