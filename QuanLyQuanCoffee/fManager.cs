using QuanLyQuanCoffee.DAO;
using QuanLyQuanCoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }

        private void fManager_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Xin chào " + fLogin.TenNguoiDung);
            adminToolStripMenuItem.Visible = AccountDAO.GetAuthority(fLogin.TenNguoiDung);

            DisplayCategory();
            tbDisplayName.Text = fLogin.TenNguoiDung;
            DisplayTable();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccountDAO.GetAuthority(fLogin.TenNguoiDung))
            {
                fAdmin admin = new fAdmin();
                this.Hide();
                admin.Show();
            }
        }

        private void thongTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Hide();
            login.Show();
        }

        private void timeKeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTimeKeeping fTime = new fTimeKeeping();
            fTime.Show();
        }


        void DisplayCategory()
        {
            cbCategory.DataSource = LoaiSanPhamDAO.GetLoaiSP();
            cbCategory.DisplayMember = "TenLoai";
            cbCategory.ValueMember = "id";
        }

        void DisplayFood(string idLoai)
        {
            cbFood.DataSource = SanPhamDAO.GetSanPham(idLoai);
            cbFood.DisplayMember = "TenMon";
            cbFood.ValueMember = "id";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategory.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                DisplayFood(cbCategory.SelectedValue.ToString());
            }
        }

        // Hiện thị thông tin các bàn ăn hiện tại
        void DisplayTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = BanAnDAO.GetBanAnList();

            foreach(Table table in tableList)
            {
                Button bt = new Button() { Width = 100, Height = 60 }; // Tạo mới 1 button có dài rộng

                bt.Text = "Bàn " + table.Id + "\n" + (table.Trangthaiban == "true" ? "Có người" : "Trống");

                bt.Tag = table.Id.ToString(); // lưu lại thông tin id bàn ăn vào tag của button

                bt.Click += btBanAn_Click; // Thêm xử lý khi click vào nút 
                
                flpTable.Controls.Add(bt); // thêm cái button tượng trưng cho bàn ăn vào flow layout panel
            }

        }

        void btBanAn_Click(object sender, EventArgs e)
        {
            int idBanAn = Convert.ToInt32((sender as Button).Tag.ToString());
            lvBill.Tag = (sender as Button).Tag;
            
            ShowBill(idBanAn);
        }

        private void btAddFood_Click(object sender, EventArgs e)
        {

        }

        // Hiển thị bill hiện tại của bàn khi nhấp vào bàn đó
        private void ShowBill(int id)
        {
            MessageBox.Show(lvBill.Tag.ToString());
            lvBill.Items.Clear();
            List<DTO.Menu> menus = MenuDAO.GetMenuListByTable(id);

            // Dùng hiển thị tổng tiền cả bill
            float totalPrice = 0;

            foreach (DTO.Menu item in menus) {
                ListViewItem viewItem = new ListViewItem(item.FoodName.ToString());
                viewItem.SubItems.Add(item.Count.ToString());
                viewItem.SubItems.Add(item.Price.ToString());
                viewItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice; // Cộng tổng tiền mỗi hàng vào tổng tiền cả bill
                lvBill.Items.Add(viewItem);
            }

            //Format tiền thành VND
            tbTotalPrice.Text = totalPrice.ToString("c", new CultureInfo("vi-VN"));
        }
    }
}
