using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.GUI.Report
{
    public partial class ReportViewer : Form
    {
        private MenuBill menuBill;

        public ReportViewer()
        {
            InitializeComponent();
        }

        public ReportViewer(MenuBill menuBill)
        {
            InitializeComponent();
            this.menuBill = menuBill;
            MessageBox.Show("Đang xuất bill");
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = menuBill;

            //DataTable dt = new DataTable();
            //dt = DAO.MenuDAO.GetDataReport("1");
            //MenuBill reportData = new MenuBill();
            //reportData.SetDataSource(dt);
            //crystalReportViewer1.ReportSource = reportData;

        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            fManager manager = new fManager();
            manager.Show();
        }
    }
}
