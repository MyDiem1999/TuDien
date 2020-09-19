namespace FormMain
{
    partial class frmDangNhap
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
            this.panelDangNhap = new System.Windows.Forms.Panel();
            this.txtMatKhau = new ThietKeGiaoDien.txtPass();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.panelDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDangNhap
            // 
            this.panelDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelDangNhap.Controls.Add(this.txtMatKhau);
            this.panelDangNhap.Controls.Add(this.btnExit);
            this.panelDangNhap.Controls.Add(this.txtTenDangNhap);
            this.panelDangNhap.Controls.Add(this.btnLogin);
            this.panelDangNhap.Controls.Add(this.lblMatKhau);
            this.panelDangNhap.Controls.Add(this.lblTenDangNhap);
            this.panelDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDangNhap.Location = new System.Drawing.Point(0, 0);
            this.panelDangNhap.Name = "panelDangNhap";
            this.panelDangNhap.Size = new System.Drawing.Size(363, 176);
            this.panelDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(117, 84);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(200, 20);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(285, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(117, 43);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(200, 20);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(117, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(29, 84);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(52, 13);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(29, 46);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(82, 13);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên người dùng";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 176);
            this.Controls.Add(this.panelDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panelDangNhap.ResumeLayout(false);
            this.panelDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Button btnExit;
        private ThietKeGiaoDien.txtPass txtMatKhau;
    }
}