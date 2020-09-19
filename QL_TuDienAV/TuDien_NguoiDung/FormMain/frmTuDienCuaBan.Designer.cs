namespace FormMain
{
    partial class frmTuDienCuaBan
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
            this.panelTD = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.txtPhienAm = new System.Windows.Forms.TextBox();
            this.cboLoaiTu = new System.Windows.Forms.ComboBox();
            this.txtTuVung = new System.Windows.Forms.TextBox();
            this.lblNghia = new System.Windows.Forms.Label();
            this.lblPhienAm = new System.Windows.Forms.Label();
            this.lblLoaiTu = new System.Windows.Forms.Label();
            this.lblTuVung = new System.Windows.Forms.Label();
            this.dgvTuDien = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelTD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuDien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTD
            // 
            this.panelTD.Controls.Add(this.button1);
            this.panelTD.Controls.Add(this.btnLuu);
            this.panelTD.Controls.Add(this.btnSua);
            this.panelTD.Controls.Add(this.btnXoa);
            this.panelTD.Controls.Add(this.btnThem);
            this.panelTD.Controls.Add(this.txtNghia);
            this.panelTD.Controls.Add(this.txtPhienAm);
            this.panelTD.Controls.Add(this.cboLoaiTu);
            this.panelTD.Controls.Add(this.txtTuVung);
            this.panelTD.Controls.Add(this.lblNghia);
            this.panelTD.Controls.Add(this.lblPhienAm);
            this.panelTD.Controls.Add(this.lblLoaiTu);
            this.panelTD.Controls.Add(this.lblTuVung);
            this.panelTD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTD.Location = new System.Drawing.Point(0, 0);
            this.panelTD.Name = "panelTD";
            this.panelTD.Size = new System.Drawing.Size(541, 204);
            this.panelTD.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(436, 124);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(436, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm từ mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNghia
            // 
            this.txtNghia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNghia.Location = new System.Drawing.Point(118, 121);
            this.txtNghia.Multiline = true;
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(285, 63);
            this.txtNghia.TabIndex = 4;
            // 
            // txtPhienAm
            // 
            this.txtPhienAm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhienAm.Location = new System.Drawing.Point(118, 86);
            this.txtPhienAm.Name = "txtPhienAm";
            this.txtPhienAm.Size = new System.Drawing.Size(285, 26);
            this.txtPhienAm.TabIndex = 3;
            // 
            // cboLoaiTu
            // 
            this.cboLoaiTu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiTu.FormattingEnabled = true;
            this.cboLoaiTu.Location = new System.Drawing.Point(118, 53);
            this.cboLoaiTu.Name = "cboLoaiTu";
            this.cboLoaiTu.Size = new System.Drawing.Size(285, 27);
            this.cboLoaiTu.TabIndex = 2;
            // 
            // txtTuVung
            // 
            this.txtTuVung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuVung.Location = new System.Drawing.Point(118, 17);
            this.txtTuVung.Name = "txtTuVung";
            this.txtTuVung.Size = new System.Drawing.Size(285, 26);
            this.txtTuVung.TabIndex = 1;
            // 
            // lblNghia
            // 
            this.lblNghia.AutoSize = true;
            this.lblNghia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNghia.Location = new System.Drawing.Point(29, 124);
            this.lblNghia.Name = "lblNghia";
            this.lblNghia.Size = new System.Drawing.Size(45, 19);
            this.lblNghia.TabIndex = 0;
            this.lblNghia.Text = "Nghĩa";
            // 
            // lblPhienAm
            // 
            this.lblPhienAm.AutoSize = true;
            this.lblPhienAm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhienAm.Location = new System.Drawing.Point(28, 88);
            this.lblPhienAm.Name = "lblPhienAm";
            this.lblPhienAm.Size = new System.Drawing.Size(64, 19);
            this.lblPhienAm.TabIndex = 0;
            this.lblPhienAm.Text = "Phiên âm";
            // 
            // lblLoaiTu
            // 
            this.lblLoaiTu.AutoSize = true;
            this.lblLoaiTu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiTu.Location = new System.Drawing.Point(28, 57);
            this.lblLoaiTu.Name = "lblLoaiTu";
            this.lblLoaiTu.Size = new System.Drawing.Size(53, 19);
            this.lblLoaiTu.TabIndex = 0;
            this.lblLoaiTu.Text = "Loại từ";
            // 
            // lblTuVung
            // 
            this.lblTuVung.AutoSize = true;
            this.lblTuVung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuVung.Location = new System.Drawing.Point(29, 24);
            this.lblTuVung.Name = "lblTuVung";
            this.lblTuVung.Size = new System.Drawing.Size(65, 19);
            this.lblTuVung.TabIndex = 0;
            this.lblTuVung.Text = "Từ Vựng";
            // 
            // dgvTuDien
            // 
            this.dgvTuDien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuDien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTuDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTuDien.Location = new System.Drawing.Point(0, 204);
            this.dgvTuDien.Name = "dgvTuDien";
            this.dgvTuDien.Size = new System.Drawing.Size(541, 246);
            this.dgvTuDien.TabIndex = 0;
            this.dgvTuDien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuDien_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(436, 88);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa từ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(436, 57);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmTuDienCuaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.dgvTuDien);
            this.Controls.Add(this.panelTD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTuDienCuaBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTuDienCuaBan";
            this.Load += new System.EventHandler(this.frmTuDienCuaBan_Load);
            this.panelTD.ResumeLayout(false);
            this.panelTD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTD;
        private System.Windows.Forms.DataGridView dgvTuDien;
        private System.Windows.Forms.TextBox txtNghia;
        private System.Windows.Forms.TextBox txtPhienAm;
        private System.Windows.Forms.ComboBox cboLoaiTu;
        private System.Windows.Forms.TextBox txtTuVung;
        private System.Windows.Forms.Label lblNghia;
        private System.Windows.Forms.Label lblPhienAm;
        private System.Windows.Forms.Label lblLoaiTu;
        private System.Windows.Forms.Label lblTuVung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}