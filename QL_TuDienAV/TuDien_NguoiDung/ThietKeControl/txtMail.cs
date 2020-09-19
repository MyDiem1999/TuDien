using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ThietKeGiaoDien
{
    public class txtMail:TextBox
    {
        ErrorProvider err = new ErrorProvider();

        public txtMail()
        {
            this.Leave += txtMail_Leave;
        }

        void txtMail_Leave(object sender, EventArgs e)
        {
            string chuoi = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (!Regex.IsMatch(this.Text, chuoi))
            {
                err.SetError(this, "Email k hop le!");
            }
            else
                err.Clear();
        }

    }
}
