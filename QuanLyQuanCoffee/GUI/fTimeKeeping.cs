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
    public partial class fTimeKeeping : Form
    {
        private Form fManager;
        //private bool goPrevious;

        public fTimeKeeping(Form fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
            this.fManager.Hide();
        }

        private void fTimeKeeping_Load(object sender, EventArgs e)
        {
            DisplayEmployee();
            DisplayCurrentDate();
           
        }

        void DisplayCurrentDate()
        {
            dtpNgayLam.Value = DateTime.Now;
        }

        void DisplayEmployee()
        {
            DataTable data = DAO.EmployeeDAO.GetEmployeeList();
            cbNhanVien.DataSource = data;
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "id";
        }

        void DisplayTimeKeepingOfDate()
        {
            string date = String.Format("{0:MM/dd/yyyy}", dtpNgayLam.Value);
            
            Int32 id = BUS.TimeKeepingBUS.CheckExists(date);
            if (id != -1)
            {
                dgvTimeKeepingList.DataSource = DAO.TimeKeepingDAO.FindTimeKeepingByDate(date);
                dgvTimeKeepingList.Tag = id;
            }
            else
            {
                DAO.TimeKeepingDAO.Save(date);
                DisplayTimeKeepingOfDate();
            }
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayLam_ValueChanged(object sender, EventArgs e)
        {
            DisplayTimeKeepingOfDate();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            int id = BUS.TimeKeepingBUS.CheckExistsNhanVien(cbNhanVien.SelectedValue.ToString(), dgvTimeKeepingList.Tag.ToString());
            if(id == -1)
            {
                DAO.TimeKeepingDAO.Save(dgvTimeKeepingList.Tag.ToString(), cbNhanVien.SelectedValue.ToString(), DateTime.Now.ToLocalTime().ToString(), DateTime.Now.ToLocalTime().ToString());
            }
            else
            {
                MessageBox.Show("Nhân viên "+ cbNhanVien.SelectedText + " đã chấm công");
            }
            DisplayTimeKeepingOfDate();
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            int id = BUS.TimeKeepingBUS.CheckExistsNhanVien(cbNhanVien.SelectedValue.ToString(), dgvTimeKeepingList.Tag.ToString());
            if (id == -1)
            {
                MessageBox.Show("Nhân viên " + cbNhanVien.SelectedText + " chưa vào làm");
            }
            else
            {
                DAO.TimeKeepingDAO.Update(dgvTimeKeepingList.Tag.ToString(), cbNhanVien.SelectedValue.ToString(), DateTime.Now.ToLocalTime().ToString());
            }
            DisplayTimeKeepingOfDate();
        }

        private void fTimeKeeping_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn quay lại trang quản lý", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                e.Cancel = true;
        }

        private void fTimeKeeping_FormClosed(object sender, FormClosedEventArgs e)
        {
            fManager.Show();
        }
    }
}
