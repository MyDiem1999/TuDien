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
    public partial class frmYeuThich : Form
    {
        TD_BLL_DAL td_bll_dal = new TD_BLL_DAL();
        string user,  pass;

        public frmYeuThich(string tk, string mk)
        {
            InitializeComponent();
            this.user = tk;
            this.pass = mk;
        }

        public void loadDGV()
        {
            dgvYT.DataSource = td_bll_dal.loadTUYT(user);
            dgvYT.AutoGenerateColumns = false;
            dgvYT.Columns[3].Visible = false;
            dgvYT.Columns[4].Visible = false;
            dgvYT.Columns[5].Visible = false;
        }

        private void frmYeuThich_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(user) && string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Chưa đăng nhập");
            }    
            else loadDGV();
        }
    }
}
