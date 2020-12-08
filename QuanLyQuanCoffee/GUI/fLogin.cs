using QuanLyQuanCoffee.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        //public static string TenNguoiDung = ""; // biến lưu lại tên người dùng đăng nhập

        private void btLogin_Click(object sender, EventArgs e)
        {
            string TenNguoiDung = AccountDAO.GetTenNguoiDung(tbUserName.Text, tbPassWord.Text);
            if (TenNguoiDung != "") //không dùng null vì database luôn trả về giá trị
            {
                fManager f = new fManager(TenNguoiDung, this);
                f.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            //TenNguoiDung = "";
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
