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

            // ẩn các nút quan trọng
            btAddFood.Enabled = false;
            btDeleteFood.Enabled = false;
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

                bt.Text = "Bàn " + table.Id + "\n" + (table.Trangthaiban == "True" ? "Có người" : "Trống");

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

            int idBill = HoaDonDAO.GetUnCheckBillIDByTableID(idBanAn); // Lấy id hóa đơn của bàn ăn hiện tại 
            int idNhanVien = AccountDAO.GetIdNhanVien(fLogin.TenNguoiDung); // Lấy id người đăng nhập

            if (idBill == -1) // nếu bàn đang trống
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm bill cho bàn ăn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dialog == DialogResult.OK)
                {
                    HoaDonDAO.InsertBill(idBanAn, idNhanVien); // Thêm hóa đơn trống
                    BanAnDAO.ChangeTableStatus(idBanAn.ToString(), "1"); // thay đổi status của bàn thành đang có khách
                    btAddFood.Enabled = true; // enable nút thêm
                    DisplayTable();
                }
            }
            else
            {
                btAddFood.Enabled = true; // enable nút thêm, 
                // không để ở ngoài vì: loại trừ trường hợp click vào bàn đang trống mà không có bill => thêm bị lỗi
            }

        }

        // Nút Thêm món
        private void btAddFood_Click(object sender, EventArgs e)
        {
            int idBanAn = -1;
            int idMonAn = -1;
            int idNhanVien = AccountDAO.GetIdNhanVien(fLogin.TenNguoiDung);
            int idHoaDonHienTai = -1;

            if (lvBill.Tag != null)
            {
                idBanAn = Convert.ToInt32(lvBill.Tag.ToString()); // Lấy id của bàn ăn vừa chọn
                idHoaDonHienTai = HoaDonDAO.GetUnCheckBillIDByTableID(idBanAn); // Lấy id hóa đơn hiện tại của bàn ăn;
                MessageBox.Show(idHoaDonHienTai.ToString());
            }
            else
                MessageBox.Show("Vui lòng chọn bàn ăn cần thêm hóa đơn");

            if (cbFood.SelectedValue != null)
                idMonAn = (int)cbFood.SelectedValue;// lấy id món ăn

            int soluong = (int)numFoodCount.Value > 0 ? (int)numFoodCount.Value : 1; // số lượng món chọn phải từ 1 trở lên

            if(idBanAn > 0 && idMonAn > 0 && idNhanVien > 0 && idHoaDonHienTai > 0)
            {
                DataTable cthd = CTHDDAO.GetBillItem(new DTO.CTHD(idHoaDonHienTai, idMonAn, soluong)); 

                if (cthd.Rows.Count > 0)
                    CTHDDAO.Update(new CTHD(idHoaDonHienTai, idMonAn, soluong)); // update nếu đã có món ăn tồn tại trong Bill
                else
                    CTHDDAO.Insert(new CTHD(idHoaDonHienTai, idMonAn, soluong)); // Insert nếu chưa có món ăn tồn tại trong bill

                ShowBill(Convert.ToInt32(lvBill.Tag.ToString())); // hiển thị thông tin bill đang trên bàn
            }
            else
            {
                MessageBox.Show("Thêm vào bill không thành công");
            }
        }

        // Hiển thị bill hiện tại của bàn khi nhấp vào bàn đó
        private void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<DTO.Menu> menus = MenuDAO.GetMenuListByTable(id);

            // Dùng hiển thị tổng tiền cả bill
            double totalPrice = 0;

            foreach (DTO.Menu item in menus) {
                ListViewItem viewItem = new ListViewItem(item.TenMon.ToString());
                viewItem.SubItems.Add(item.SoLuong.ToString());
                viewItem.SubItems.Add(item.GiaTien.ToString());
                viewItem.SubItems.Add(item.TongTien.ToString());
                totalPrice += item.TongTien; // Cộng tổng tiền mỗi hàng vào tổng tiền cả bill
                lvBill.Items.Add(viewItem);
            }

            //Format tiền thành VND
            tbTotalPrice.Text = totalPrice.ToString("c", new CultureInfo("vi-VN"));
        }
    }
}
