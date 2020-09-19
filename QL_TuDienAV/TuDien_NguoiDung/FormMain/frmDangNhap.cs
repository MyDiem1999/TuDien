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
    public partial class frmDangNhap : Form
    {
        TD_BLL_DAL td_bll_dal = new TD_BLL_DAL();
        public delegate void sendMess(string mess,string pass);
        public sendMess mess;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public frmDangNhap(sendMess sender)
        {
            InitializeComponent();
            this.mess = sender;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == string.Empty || txtMatKhau.Text==string.Empty)
            {
                MessageBox.Show("Không để trống");
            }
            else
            {
                td_bll_dal.loadKhachHang(txtTenDangNhap.Text,txtMatKhau.Text);
                this.mess(txtTenDangNhap.Text, txtMatKhau.Text);
                this.Close();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }
    }
}
