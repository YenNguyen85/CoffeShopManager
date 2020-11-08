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

        public static string TenNguoiDung = ""; // biến lưu lại tên người dùng đăng nhập

        private void btLogin_Click(object sender, EventArgs e)
        {
            TenNguoiDung = AccountDAO.GetTenNguoiDung(tbUserName.Text, tbPassWord.Text);
            if (TenNguoiDung != null)
            {
                fManager f = new fManager();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu");
            }
        }

        //Tắt bằng dấu x
        private void fLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Xài luôn messagebox của formClosing
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            TenNguoiDung = "";
        }
    }
}
