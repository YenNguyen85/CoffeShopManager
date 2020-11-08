namespace QuanLyQuanCoffee
{
    partial class fLogin
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
            this.bb = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bb.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bb
            // 
            this.bb.Controls.Add(this.btExit);
            this.bb.Controls.Add(this.btLogin);
            this.bb.Controls.Add(this.panel3);
            this.bb.Controls.Add(this.panel2);
            this.bb.Location = new System.Drawing.Point(21, 24);
            this.bb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(401, 167);
            this.bb.TabIndex = 1;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(278, 121);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(82, 32);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(182, 121);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(82, 32);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPassWord);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(16, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 44);
            this.panel3.TabIndex = 2;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(142, 14);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(203, 20);
            this.tbPassWord.TabIndex = 1;
            this.tbPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 44);
            this.panel2.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(142, 14);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(203, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 223);
            this.Controls.Add(this.bb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fLogin";
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing_1);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.bb.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bb;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
    }
}