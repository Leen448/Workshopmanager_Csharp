using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisrtDataAccess
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }
        Account acc = new Account();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int CId;
            if (acc.CheckUserExists(txtUserName.Text, txtPassord.Text,out CId) == 1)
            {

                Account.CustomerId = CId;
                //redirect to main form
                FormMain frm = new FormMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or password");
            }

        }
    }
}
