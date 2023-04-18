using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUSoftware.Controls
{
    public partial class CreateUserUC : UserControl
    {
        public CreateUserUC()
        {
            InitializeComponent();
        }

        private void gosterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (gosterCb.Checked)
                paswordTxt.PasswordChar = '\0';
            else
                paswordTxt.PasswordChar = '*';
        }
    }
}
