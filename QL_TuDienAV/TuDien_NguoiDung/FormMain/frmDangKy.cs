using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace FormMain
{
    public partial class frmDangKy : Form
    {
        TD_BLL_DAL td_bll_dal = new TD_BLL_DAL();
        public delegate void sendMess(string user, string pass);
        public sendMess send;
        public frmDangKy()
        {
            InitializeComponent();
            
        }

        public frmDangKy(sendMess sendMess)
        {
            InitializeComponent();
            this.send = sendMess;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            bool gioitinh;
            if (rdoNu.Checked == true) gioitinh = true;
            else gioitinh = false;
            td_bll_dal.themKH(txtTenDangNhap.Text,txtXacNhanMatKhau.Text,int.Parse(cboDiaChi.SelectedValue.ToString()),dtpNgaySinh.Value,gioitinh,txtTenNguoiDung.Text, txtSDT.Text, txtMail.Text);
            DialogResult r=MessageBox.Show(this, "Thông báo", "Bạn có muốn đăng nhập hay không?", MessageBoxButtons.YesNo);
            if(r==DialogResult.Yes)
            {
                this.Close();
                this.send(txtTenDangNhap.Text, txtXacNhanMatKhau.Text);
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                errorProviderTenDangNhap.SetError(txtTenDangNhap, "Không bỏ trống");

            }
            else
            {
                if(td_bll_dal.TraKQKTTK(txtTenDangNhap.Text)==true) errorProviderTenDangNhap.SetError(txtTenDangNhap, "đã có tài khoản này"); 
                else errorProviderTenDangNhap.Clear();
            }
        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                errorProviderXacNhanMatKhau.SetError(txtXacNhanMatKhau, "Pass khác nhau");
            }
            else errorProviderXacNhanMatKhau.Clear();
        }

        public void loadTT()
        {
            cboDiaChi.DataSource = td_bll_dal.loadTT();
            cboDiaChi.DisplayMember = "TENTINH";
            cboDiaChi.ValueMember = "MATINH";
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            loadTT(); rdoNu.Checked = true;
        }
    }
}
