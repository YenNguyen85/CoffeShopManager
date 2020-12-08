namespace QuanLyQuanCoffee
{
    partial class fManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.numFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDeleteFood = new System.Windows.Forms.NumericUpDown();
            this.btDeleteFood = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.cbChangeTable = new System.Windows.Forms.ComboBox();
            this.btChangeTable = new System.Windows.Forms.Button();
            this.btDiscount = new System.Windows.Forms.Button();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBill = new System.Windows.Forms.ListView();
            this.thongTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timeKeepingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDisplayName = new System.Windows.Forms.Label();
            this.tbSelectedTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteFood)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 49);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(400, 406);
            this.flpTable.TabIndex = 7;
            // 
            // numFoodCount
            // 
            this.numFoodCount.Location = new System.Drawing.Point(415, 20);
            this.numFoodCount.Name = "numFoodCount";
            this.numFoodCount.Size = new System.Drawing.Size(48, 19);
            this.numFoodCount.TabIndex = 1;
            this.numFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btAddFood
            // 
            this.btAddFood.Location = new System.Drawing.Point(332, 4);
            this.btAddFood.Name = "btAddFood";
            this.btAddFood.Size = new System.Drawing.Size(77, 53);
            this.btAddFood.TabIndex = 1;
            this.btAddFood.Text = "Thêm món";
            this.btAddFood.UseVisualStyleBackColor = true;
            this.btAddFood.Click += new System.EventHandler(this.btAddFood_Click);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(97, 33);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(214, 21);
            this.cbFood.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.numDeleteFood);
            this.panel4.Controls.Add(this.btDeleteFood);
            this.panel4.Controls.Add(this.numFoodCount);
            this.panel4.Controls.Add(this.btAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(418, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 57);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên món:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh mục:";
            // 
            // numDeleteFood
            // 
            this.numDeleteFood.Location = new System.Drawing.Point(579, 20);
            this.numDeleteFood.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDeleteFood.Name = "numDeleteFood";
            this.numDeleteFood.Size = new System.Drawing.Size(48, 19);
            this.numDeleteFood.TabIndex = 9;
            this.numDeleteFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btDeleteFood
            // 
            this.btDeleteFood.Location = new System.Drawing.Point(496, 4);
            this.btDeleteFood.Name = "btDeleteFood";
            this.btDeleteFood.Size = new System.Drawing.Size(77, 53);
            this.btDeleteFood.TabIndex = 8;
            this.btDeleteFood.Text = "Xóa món";
            this.btDeleteFood.UseVisualStyleBackColor = true;
            this.btDeleteFood.Click += new System.EventHandler(this.btDeleteFood_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(97, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(214, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbTotalPrice.Location = new System.Drawing.Point(486, 28);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(141, 23);
            this.tbTotalPrice.TabIndex = 2;
            this.tbTotalPrice.Text = "0";
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.FormattingEnabled = true;
            this.cbChangeTable.Location = new System.Drawing.Point(9, 32);
            this.cbChangeTable.Name = "cbChangeTable";
            this.cbChangeTable.Size = new System.Drawing.Size(118, 21);
            this.cbChangeTable.TabIndex = 6;
            // 
            // btChangeTable
            // 
            this.btChangeTable.Location = new System.Drawing.Point(9, 4);
            this.btChangeTable.Name = "btChangeTable";
            this.btChangeTable.Size = new System.Drawing.Size(118, 25);
            this.btChangeTable.TabIndex = 5;
            this.btChangeTable.Text = "Chuyển bàn";
            this.btChangeTable.UseVisualStyleBackColor = true;
            // 
            // btDiscount
            // 
            this.btDiscount.Location = new System.Drawing.Point(144, 4);
            this.btDiscount.Name = "btDiscount";
            this.btDiscount.Size = new System.Drawing.Size(118, 25);
            this.btDiscount.TabIndex = 3;
            this.btDiscount.Text = "Gộp bàn";
            this.btDiscount.UseVisualStyleBackColor = true;
            // 
            // btCheckOut
            // 
            this.btCheckOut.Location = new System.Drawing.Point(486, 4);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(141, 25);
            this.btCheckOut.TabIndex = 2;
            this.btCheckOut.Text = "Thanh toán";
            this.btCheckOut.UseVisualStyleBackColor = true;
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.btDiscount);
            this.panel3.Controls.Add(this.tbTotalPrice);
            this.panel3.Controls.Add(this.cbChangeTable);
            this.panel3.Controls.Add(this.btCheckOut);
            this.panel3.Controls.Add(this.btChangeTable);
            this.panel3.Location = new System.Drawing.Point(418, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 58);
            this.panel3.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(284, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giảm giá (%)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 163;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.Enabled = false;
            this.lvBill.FullRowSelect = true;
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(418, 114);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(641, 277);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // thongTinTaiKhoanToolStripMenuItem
            // 
            this.thongTinTaiKhoanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinTaiKhoanToolStripMenuItem.Name = "thongTinTaiKhoanToolStripMenuItem";
            this.thongTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.thongTinTaiKhoanToolStripMenuItem.Text = "Đăng Xuất";
            this.thongTinTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.thongTinTaiKhoanToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.adminToolStripMenuItem.Text = "Quản lý";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thongTinTaiKhoanToolStripMenuItem,
            this.timeKeepingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timeKeepingToolStripMenuItem
            // 
            this.timeKeepingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeKeepingToolStripMenuItem.Name = "timeKeepingToolStripMenuItem";
            this.timeKeepingToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.timeKeepingToolStripMenuItem.Text = "Chấm công";
            this.timeKeepingToolStripMenuItem.Click += new System.EventHandler(this.timeKeepingToolStripMenuItem_Click);
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.AutoSize = true;
            this.tbDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbDisplayName.Location = new System.Drawing.Point(963, 477);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(83, 17);
            this.tbDisplayName.TabIndex = 8;
            this.tbDisplayName.Text = "Tên hiển thị";
            // 
            // tbSelectedTable
            // 
            this.tbSelectedTable.Enabled = false;
            this.tbSelectedTable.Location = new System.Drawing.Point(726, 477);
            this.tbSelectedTable.Name = "tbSelectedTable";
            this.tbSelectedTable.Size = new System.Drawing.Size(100, 19);
            this.tbSelectedTable.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bàn ăn đang chọn:";
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSelectedTable);
            this.Controls.Add(this.lvBill);
            this.Controls.Add(this.tbDisplayName);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fManager";
            this.Text = "PHẦN MỀM QUẢN LÝ QUÁN COFFE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fManager_FormClosing);
            this.Load += new System.EventHandler(this.fManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFoodCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeleteFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.NumericUpDown numFoodCount;
        private System.Windows.Forms.Button btAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numDeleteFood;
        private System.Windows.Forms.Button btDeleteFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.ComboBox cbChangeTable;
        private System.Windows.Forms.Button btChangeTable;
        private System.Windows.Forms.Button btDiscount;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ToolStripMenuItem thongTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label tbDisplayName;
        private System.Windows.Forms.ToolStripMenuItem timeKeepingToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox tbSelectedTable;
        private System.Windows.Forms.Label label2;
    }
}