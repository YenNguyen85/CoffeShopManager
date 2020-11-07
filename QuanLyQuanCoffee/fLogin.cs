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

        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string passWord = tbPassWord.Text;

            if (Login(userName, passWord))
            {
                fManager f = new fManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai tên tài khoản hoặc mật khẩu");
            }
        }
        //private void btLogin_Click(object sender, EventArgs e)
        //{
        //    
        //}

        bool Login(string userName, string passWord)
        {
            return DAO.AccountDAO.Instance.Login(userName, passWord);
        }

        //private void btExit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
        //    {
        //        e.Cancel = true;
        //    }
        //}
    }
}
