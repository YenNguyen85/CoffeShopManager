using QuanLyQuanCoffee.BUS;
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
    public partial class fAdmin : Form
    {
        public object BanAnBUS { get; private set; }

        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            DisplayProductTreeView();
            DisplayTable();
            DisplayListViewAccount();
            DisplayLoaiTK();

            DisplayTTNhanVien();
            DisplayCBChucVu();
            DisplayCBTenTK();
            DisplayCategory();
        }

        // Gọi hàm khi thay đổi selected tab
        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabAdmin.SelectedTab.Name)
            {
                case "tabProduct":
                    DisplayProductTreeView();
                    break;

            }
        }

        // --------------------Các hàm xử lý tab sản phẩm----------------------
        private void DisplayCategory()
        {
            cbCategory.DataSource = LoaiSanPhamDAO.GetLoaiSP();
            cbCategory.DisplayMember = "TenLoai";
            cbCategory.ValueMember = "id";
        }

        // Hiển thị tree view loại sản phẩm
        private void DisplayProductTreeView()
        {
            tvProduct.Nodes.Clear();
            DataTable data = LoaiSanPhamDAO.GetLoaiSP();
            TreeNode parentNode = new TreeNode();
            foreach (DataRow row in data.Rows)
            {
                parentNode = tvProduct.Nodes.Add(row["TenLoai"].ToString());
                parentNode.Tag = row["id"].ToString();
                PopulateTreeView(row["id"].ToString(), parentNode);
            }
        }

        // Hiển thị thông tin các node con thuộc node parent
        private void PopulateTreeView(string idLoaiSP, TreeNode parentNode)
        {
            DataTable data = SanPhamDAO.GetSanPham(idLoaiSP);
            TreeNode childNode;
            foreach (DataRow row in data.Rows)
            {
                if (parentNode == null)
                {
                    childNode = tvProduct.Nodes.Add(row["TenMon"].ToString() + "_" + row["GiaTien"].ToString());
                    childNode.Tag = row["id"].ToString();
                }
                else
                {
                    childNode = parentNode.Nodes.Add(row["TenMon"].ToString() + "_" + row["GiaTien"].ToString());
                    childNode.Tag = row["id"].ToString();
                    //gọi lại hàm này nếu có thêm node con
                }
            }
        }
        private void tvProduct_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(tvProduct.SelectedNode.Parent == null)
            {
                tbCategory.Text = tvProduct.SelectedNode.Text;
                cbCategory.Text = tvProduct.SelectedNode.Text;
            }
            else
            {
                DataTable data = new DataTable();
                data = SanPhamDAO.GetTTSanPham(tvProduct.SelectedNode.Tag.ToString());

                DataRow foodInfo = data.Rows[0];
                tbFood.Text = foodInfo["TenMon"].ToString();
                numPrice.Value = Decimal.Parse(foodInfo["GiaTien"].ToString(), NumberStyles.Currency, new CultureInfo("vi-VN"));
            }
        }

        private void btSaveCategory_Click(object sender, EventArgs e)
        {
            if(tbCategory.Text != "")
            {
                try
                {
                    LoaiSanPhamDAO.InsertLoaiSP(tbCategory.Text);

                    DisplayProductTreeView();
                    DisplayCategory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert error, " + ex);
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập ít nhất 2 kí tự");
            }
        }

        private void btUpdateCategory_Click(object sender, EventArgs e)
        {
            if(tvProduct.SelectedNode.Text != null && tvProduct.SelectedNode.Parent == null)
            {
                DTO.Category loaisp = new DTO.Category();
                loaisp.Id = Convert.ToInt32(tvProduct.SelectedNode.Tag.ToString());
                loaisp.TenLoai = tbCategory.Text;
                LoaiSanPhamDAO.UpdateLoaiSP(loaisp);

                DisplayProductTreeView();
                DisplayCategory();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần update");
            }
        }

        private void btDeleteCategory_Click(object sender, EventArgs e)
        {
            if (tvProduct.SelectedNode.Text != null && tvProduct.SelectedNode.Parent == null)
            {
                LoaiSanPhamDAO.DeleteLoaiSP(tvProduct.SelectedNode.Tag.ToString());

                DisplayProductTreeView();
                DisplayCategory();
            }
        }


        private void btSaveFood_Click(object sender, EventArgs e)
        {
            if(tbFood.Text != "" && numPrice.Value > 0)
            {
                DTO.Food newFood = new DTO.Food(-1, tbFood.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), (float)numPrice.Value);
                SanPhamDAO.InsertSanPham(newFood);
                DisplayProductTreeView();
            }
        }

        private void btUpdateFood_Click(object sender, EventArgs e)
        {
            if (tvProduct.SelectedNode.Text != null && tvProduct.SelectedNode.Parent != null)
            {
                if(tbFood.Text != "" && numPrice.Value > 0)
                {
                    DTO.Food newFood = new DTO.Food(Convert.ToInt32(tvProduct.SelectedNode.Tag.ToString()), tbFood.Text, Convert.ToInt32(cbCategory.SelectedValue.ToString()), (float)numPrice.Value);
                    SanPhamDAO.InsertSanPham(newFood);
                    DisplayProductTreeView();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin món ăn");
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm cần sửa");
            }

        }

        private void btDeleteFood_Click(object sender, EventArgs e)
        {
            if (tvProduct.SelectedNode.Text != null && tvProduct.SelectedNode.Parent != null)
            {
                if (MessageBox.Show("Bạn muốn xóa món  này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        SanPhamDAO.DeleteSanPham(tvProduct.SelectedNode.Tag.ToString());

                        DisplayProductTreeView();
                        tbFood.Text = "";
                        numPrice.Value = 0;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Xóa món không thành công!, " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm cần xóa");
            }
        }

        //--------------TAB BÀN ĂN--------------

        void DisplayTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = BanAnDAO.GetBanAnList();

            int soluong = 0;

            foreach (Table table in tableList)
            {
                Button bt = new Button() { Width = 100, Height = 60 }; // Tạo mới 1 button có dài rộng

                bt.Text = "Bàn " + table.Id + "\n" + (table.Trangthaiban == "true" ? "Có người" : "Trống");

                bt.Tag = table.Id.ToString(); // lưu lại thông tin id bàn ăn vào tag của button

                bt.Click += btBanAn_Click; // Thêm xử lý khi click vào nút 

                flpTable.Controls.Add(bt); // thêm cái button tượng trưng cho bàn ăn vào flow layout panel
                soluong++;
            }

            label1.Text = "Số lượng bàn ăn: " + soluong;
        }
        void btBanAn_Click(object sender, EventArgs e)
        {
            int idBanAn = Convert.ToInt32((sender as Button).Tag.ToString());
            tbTableName.Text = idBanAn.ToString();
        }

        private void btThemBan_Click(object sender, EventArgs e)
        {
            tbTableName.Text = TableBUS.GetNextIdTable().ToString();
        }

        private void btLuuBan_Click(object sender, EventArgs e)
        {
            BanAnDAO.LuuBanAN();
            DisplayTable();
            tbTableName.Text = "";
        }

        private void btXoaBan_Click(object sender, EventArgs e)
        {
            if (tbTableName.Text != "")
                TableBUS.XoaBanAn(tbTableName.Text);
            else
                MessageBox.Show("Vui lòng chọn một bàn cần xóa");
            DisplayTable();
            
        }





        //--------------TAB TAI KHOAN--------------
        void DisplayListViewAccount()
        {
            listAccounts.Items.Clear();
            DataTable dt = AccountDAO.GetTTAccount();
            int sl = dt.Rows.Count;
            for (int i = 0; i < sl; i++)
            {
                listAccounts.Items.Add(dt.Rows[i]["TenNguoiDung"].ToString());
                listAccounts.Items[i].SubItems.Add(dt.Rows[i]["TenHienThi"].ToString());
                listAccounts.Items[i].SubItems.Add(dt.Rows[i]["TenLoaiTK"].ToString());
            }
        }

        void DisplayLoaiTK()
        {
            cbLoaiTK.DataSource = LoaiTKDAO.GetData();
            cbLoaiTK.DisplayMember = "TenLoaiTK";
            cbLoaiTK.ValueMember = "idLoaiTK";
        }

        private void listAccounts_Click(object sender, EventArgs e)
        {
            tbUserName.Text = listAccounts.SelectedItems[0].SubItems[0].Text;
            tbDisplayName.Text = listAccounts.SelectedItems[0].SubItems[1].Text;
            cbLoaiTK.Text = listAccounts.SelectedItems[0].SubItems[2].Text;
        }

        private void btLuuTK_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.TenNguoiDung = tbUserName.Text;
            acc.TenHienThi = tbDisplayName.Text;
            acc.LoaiTK = (int)cbLoaiTK.SelectedValue;

            // Kiểm tra tên đăng nhập có tồn tại chưa
            if (AccountDAO.CheckExistsTenNguoiDung(acc.TenNguoiDung))
            {
                MessageBox.Show("Tên người dùng đã tồn tại");
            }
            else
            {
                AccountBUS.ThemTK(acc);
                listAccounts.Items.Clear();
                DisplayListViewAccount();
                MessageBox.Show("Lưu tài khoản thành công!");
            }
        }

        private void btCapnhatTK_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.TenNguoiDung = tbUserName.Text;
            acc.TenHienThi = tbDisplayName.Text;
            acc.LoaiTK = (int)cbLoaiTK.SelectedValue;
            AccountBUS.SuaTK(acc);
            listAccounts.Items.Clear();
            DisplayListViewAccount();
            MessageBox.Show("Cập nhật tài khoản thành công!");
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.TenNguoiDung = tbUserName.Text;
            AccountBUS.XoaTK(acc);
            listAccounts.Items.Clear();
            DisplayListViewAccount();
            MessageBox.Show("Xóa tài khoản thành công!");
        }

        //--------------TAB NHÂN VIEN--------------
        void DisplayTTNhanVien()
        {
            dtgvNhanVien.DataSource = EmployeeDAO.GetEmployeeList(); 
        }

        void DisplayCBChucVu()
        {
            cbChucVu.DataSource = EmployeeDAO.GetChucVU();
            cbChucVu.DisplayMember = "TenChucVu";
            cbChucVu.ValueMember = "id";
        }

        void DisplayCBTenTK()
        {
            cbTenTK.DataSource = AccountDAO.GetTTAccount();
            cbTenTK.DisplayMember = "TenNguoiDung";
            cbTenTK.ValueMember = "TenNguoiDung";
        }

        private int employeeID = -1;

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Employee selectedEmployee = EmployeeDAO.GetEmployee(dtgvNhanVien.Rows[dtgvNhanVien.CurrentRow.Index].Cells[0].Value.ToString());
            cbTenTK.Text = selectedEmployee.TenTaiKhoan;
            tbTenNV.Text = selectedEmployee.TenNhanVien;
            dtNgaySinh.Value = selectedEmployee.NgaySinh;
            tbDiachi.Text = selectedEmployee.DiaChi;
            tbSDT.Text = selectedEmployee.Sdt;
            employeeID = selectedEmployee.Id;
           
        }

        private void btLuuNV_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.TenNhanVien = tbTenNV.Text;
            emp.NgaySinh = dtNgaySinh.Value;
            emp.DiaChi = tbDiachi.Text;
            emp.TenTaiKhoan = cbTenTK.SelectedValue.ToString();
            emp.Sdt = tbSDT.Text;
            emp.IdChucVu = Convert.ToInt32(cbChucVu.SelectedValue.ToString());

            EmployeeBUS.ThemNhanVien(emp);

            // reload datagridview 
            DisplayTTNhanVien();
        }

        private void btCapNhatNV_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Id = employeeID;
            emp.TenNhanVien = tbTenNV.Text;
            emp.NgaySinh = dtNgaySinh.Value;
            emp.DiaChi = tbDiachi.Text;
            emp.TenTaiKhoan = cbTenTK.SelectedValue.ToString();
            emp.Sdt = tbSDT.Text;
            emp.IdChucVu = Convert.ToInt32(cbChucVu.SelectedValue.ToString());
            
            EmployeeBUS.SuaNhanVien(emp);

            // reload datagridview 
            DisplayTTNhanVien();
        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    EmployeeBUS.XoaNhanVien(employeeID);
                    DisplayTTNhanVien();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Xóa nhân viên không thành công!, " + ex);
                }
            }
        }

        private void btViewBill_Click(object sender, EventArgs e)
        {
            DataTable dt = HoaDonDAO.GetAllHoaDon(String.Format("{0:MM/dd/yyyy}", dtpkNgayBatDau.Value), String.Format("{0:MM/dd/yyyy}", dtpkNgayKetThuc.Value));

            GUI.Report.DoanhThuReport report = new GUI.Report.DoanhThuReport();
            report.SetDataSource(dt);
            DoanhThuViewer.ReportSource = report;
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            if(dtpBatDau.Value < dtpKetThuc.Value)
            {
                DataTable data = SalaryDAO.FindAllSalaryFromDateToDate(dtpBatDau.Value.ToString(), dtpKetThuc.Value.ToString());
                GUI.Report.SalaryReport report = new GUI.Report.SalaryReport();
                report.SetDataSource(data);
                LuongNVViewer.ReportSource = report;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu và ngày kết thúc tính lương lại");
            }
            
        }
    }
}
