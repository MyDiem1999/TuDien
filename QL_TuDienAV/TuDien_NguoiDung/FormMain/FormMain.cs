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
    public partial class FormMain : Form
    {
        private Form activeForm = null;
        TD_BLL_DAL td_bll_dal = new TD_BLL_DAL();
        public FormMain()
        {
            InitializeComponent();
            panelSuaMK.Visible = panelTTTK.Visible = false;
            hideSubMenu();
            loadTT();
            btnLogout.Visible = false;
        }

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            bool gioitinh;
            if (rdoNu.Checked == true) gioitinh = true;
            else gioitinh = false;
            td_bll_dal.capnhatTTKH(txtTenDangNhap.Text, txtMatKhau.Text, int.Parse(cboDiaChi.SelectedValue.ToString()), dtpNgaySinh.Value, gioitinh, txtTenNguoiDung.Text,txtSDT.Text,txtMail.Text);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == string.Empty)
            {
                hideSubMenu();
                frmDangNhap frm = new frmDangNhap(showMSG);
                this.Visible = false;
                frm.ShowDialog();
                this.Visible = true;

            }
            else
            {
                panelDN.Controls.Add(panelTTTK);
                panelTTTK.Visible = true;
                panelTTTK.Enabled = false;
                showSubMenu(panelLogin);
                loadTTTK();
                btnLogout.Visible = true;
            }
        }

        private void hideSubMenu()
        {
            panelLogin.Visible = false;
            panelTD.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        public void showMSG(string tendn, string pass)
        {
            txtTenDangNhap.Text = tendn;
            txtMatKhau.Text = pass;
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            panelTTTK.Enabled = true;
            panelSuaMK.Visible = false;
            txtTenDangNhap.Enabled = txtMatKhau.Enabled = false;
            loadTTTK();
        }

        public void loadTTTK()
        {
            loadTT();
            txtTenNguoiDung.Text = td_bll_dal.loadTenNguoiDung(txtTenDangNhap.Text);
            dtpNgaySinh.Text = td_bll_dal.loadNgaySinh(txtTenDangNhap.Text).ToShortDateString();
            if (td_bll_dal.loadGioiTinh(txtTenDangNhap.Text) == true)
                rdoNu.Checked = true;
            else rdoNam.Checked = false;
            int dc = td_bll_dal.loadDiaChi(txtTenDangNhap.Text);
            cboDiaChi.SelectedIndex = dc - 1;
            txtMail.Text = td_bll_dal.loadEmail(txtTenDangNhap.Text);
            txtSDT.Text = td_bll_dal.loadSDT(txtTenDangNhap.Text);
        }

        private void btnTDMK_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != string.Empty && txtMatKhau.Text != string.Empty)
            {
                if (string.IsNullOrEmpty(txtMKHT.Text) && string.IsNullOrEmpty(txtMKM.Text) && string.IsNullOrEmpty(txtXNMKM.Text))
                {
                    panelDN.Controls.Add(panelSuaMK);
                    panelSuaMK.Visible = true;
                    panelSuaMK.Enabled = true;
                    panelTTTK.Visible = false;
                }
            }
        }

        public void loadTT()
        {
            cboDiaChi.DataSource = td_bll_dal.loadTT();
            cboDiaChi.DisplayMember = "TENTINH";
            cboDiaChi.ValueMember = "MATINH";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) && string.IsNullOrEmpty(txtMatKhau.Text))
            {
                frmDangKy frm = new frmDangKy(showMSG);
                this.Visible = false;
                frm.ShowDialog();
                this.Visible = true;
            }
            else
            {
                panelTTTK.Visible = true;
                panelSuaMK.Enabled = false;
                showSubMenu(panelLogin);
                loadTTTK();
            }
        }

        private void txtMKHT_TextChanged(object sender, EventArgs e)
        {
            if (txtMKM.Text != txtXNMKM.Text)
            {
                errorProvider2.SetError(txtXNMKM, "Pass khác nhau");
            }
            else errorProvider2.Clear();
        }

        private void btnSuaMK_Click(object sender, EventArgs e)
        {
            td_bll_dal.capnhatMatKhau(txtTenDangNhap.Text, txtXNMKM.Text);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != null)
            {
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                dtpNgaySinh.ResetText();
                cboDiaChi.Text = "";
                txtTenNguoiDung.Text = "";
                txtMail.Text = txtSDT.Text = "";
                MessageBox.Show("Đăng xuất thành công");
                panelTTTK.Visible = false;
            }
        }

        private void btnTuDien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTD);
            openChildForm(new frmTraTu(txtTenDangNhap.Text));
        }

        private void openChildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childform);
            panelMain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnDMYT_Click(object sender, EventArgs e)
        {
            openChildForm(new frmYeuThich(txtTenDangNhap.Text, txtMatKhau.Text));

        }

        private void btnTDCB_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTuDienCuaBan(txtTenDangNhap.Text, txtMatKhau.Text));

        }

        private void panelDN_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
