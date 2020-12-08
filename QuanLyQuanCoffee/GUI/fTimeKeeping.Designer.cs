namespace QuanLyQuanCoffee
{
    partial class fTimeKeeping
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTimeKeepingList = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeKeepingList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpNgayLam);
            this.groupBox2.Controls.Add(this.btnChamCong);
            this.groupBox2.Controls.Add(this.cbNhanVien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(324, 411);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN CHẤM CÔNG";
            // 
            // btnVe
            // 
            this.btnVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVe.Location = new System.Drawing.Point(209, 178);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(95, 43);
            this.btnVe.TabIndex = 19;
            this.btnVe.Text = "Về";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ngày làm:";
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Enabled = false;
            this.dtpNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLam.Location = new System.Drawing.Point(127, 121);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(177, 23);
            this.dtpNgayLam.TabIndex = 14;
            this.dtpNgayLam.ValueChanged += new System.EventHandler(this.dtpNgayLam_ValueChanged);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Location = new System.Drawing.Point(91, 178);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(95, 43);
            this.btnChamCong.TabIndex = 13;
            this.btnChamCong.Text = "Vào làm";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(127, 60);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(177, 25);
            this.cbNhanVien.TabIndex = 11;
            this.cbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbNhanVien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên nhân viên:";
            // 
            // dgvTimeKeepingList
            // 
            this.dgvTimeKeepingList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTimeKeepingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeKeepingList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTimeKeepingList.Location = new System.Drawing.Point(339, 28);
            this.dgvTimeKeepingList.Name = "dgvTimeKeepingList";
            this.dgvTimeKeepingList.Size = new System.Drawing.Size(453, 411);
            this.dgvTimeKeepingList.TabIndex = 6;
            // 
            // fTimeKeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTimeKeepingList);
            this.Controls.Add(this.groupBox2);
            this.Name = "fTimeKeeping";
            this.Text = "Chấm công";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTimeKeeping_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fTimeKeeping_FormClosed);
            this.Load += new System.EventHandler(this.fTimeKeeping_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeKeepingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTimeKeepingList;
        private System.Windows.Forms.Button btnVe;
    }
}