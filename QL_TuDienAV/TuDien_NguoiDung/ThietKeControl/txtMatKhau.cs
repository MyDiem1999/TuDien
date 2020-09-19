using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeGiaoDien
{
    public class txtPass: TextBox
    {
        ErrorProvider err = new ErrorProvider();

        public txtPass()
        {
            this.KeyPress += txtPass_KeyPress;
            this.Leave += txtPass_Leave;
        }

        void txtPass_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (this.TextLength < 6)
            {
                this.err.SetError(ctr, "sai");
            }
            else
                err.Clear();
        }

        void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                this.err.SetError(ctr, "sai");
            }
            else
                err.Clear();

        }
    }
}
