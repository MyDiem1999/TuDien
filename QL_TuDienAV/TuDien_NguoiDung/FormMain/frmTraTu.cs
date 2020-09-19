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
    public partial class frmTraTu : Form
    {
        TD_BLL_DAL td_bll_dal = new TD_BLL_DAL();
        public string user;
        public frmTraTu()
        {
            InitializeComponent();
        }

        public frmTraTu(string send)
        {
            InitializeComponent();
            this.user = send;
            label1.Text = user;
        }

        private void frmTraTu_Load(object sender, EventArgs e)
        {
            loadTu();
            cboTu.Text = "";
            cboTu.Focus();
        }

        public void loadTu()
        {
            cboTu.DataSource = td_bll_dal.loadTU();
            cboTu.DisplayMember = "TUVUNG".TrimEnd();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        { 
            if(cboTu.Text !=string.Empty)
            {
                lstTu.Items.Clear();
                List<string> lst = td_bll_dal.DichNghia(cboTu.Text);
                foreach (string str in lst)
                {
                    lstTu.Items.Add(str);
                }
            }    
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            {
                if(string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Hãy đăng nhập!");
                } 
                else
                {
                    td_bll_dal.themTuYT(user,cboTu.Text);
                }                    
            }
        }
    }
}
