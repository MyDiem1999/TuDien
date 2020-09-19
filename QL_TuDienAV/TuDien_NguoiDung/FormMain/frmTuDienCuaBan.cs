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
    public partial class frmTuDienCuaBan : Form
    {
        TD_BLL_DAL td_bll_dal = new TD_BLL_DAL();
        string user, password;
        public frmTuDienCuaBan(string tk, string mk)
        {
            InitializeComponent();
            this.user =tk;
            this.password = mk;
        }

        public void loadComboboxTu()
        {
            cboLoaiTu.DataSource = td_bll_dal.Loaitu();
            cboLoaiTu.DisplayMember = "NGHIALOAITU";
            cboLoaiTu.ValueMember = "MALOAI";

        }

        public void loadDGV()
        {
            dgvTuDien.DataSource = td_bll_dal.loadTD(user);
            dgvTuDien.Columns[5].Visible = false;
            dgvTuDien.Columns[6].Visible = false;
        }

        private void frmTuDienCuaBan_Load(object sender, EventArgs e)
        {
            loadComboboxTu();
            if(user !=null)
            {
                loadDGV();
            }

            txtTuVung.Enabled = txtPhienAm.Enabled = txtNghia.Enabled = cboLoaiTu.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            td_bll_dal.themTuDienCuaBan(txtTuVung.Text, cboLoaiTu.SelectedValue.ToString(), txtPhienAm.Text, txtNghia.Text, user);
            btnXoa.Enabled = btnSua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void dgvTuDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDGV();
            txtTuVung.Enabled = txtPhienAm.Enabled = txtNghia.Enabled = cboLoaiTu.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTuVung.Enabled = txtPhienAm.Enabled = txtNghia.Enabled = cboLoaiTu.Enabled = btnLuu.Enabled = true;
        }
    }
}
