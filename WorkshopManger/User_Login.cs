using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }
      //  Account acc = new Account();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            int slected_index = comboBox1.SelectedIndex;
            
            int UId;


            Account account = new Account();
        

            if (account.CheckUserExists(txtUserName.Text, txtPassord.Text, slected_index, out UId) != 0)
            {
                Account.AccountId = UId;
                switch (slected_index) {
                    case 0:
                        Account.AccountType = 0;
                        AudienceHome aud = new AudienceHome();
                            aud.Tag = this;
                            aud.Show(this);
                            Hide();

                        break;
                    case 1:
                        Account.AccountType = 1;
                        OrganizerAdminHome Orgadmin = new OrganizerAdminHome();
                            Orgadmin.Tag = this;
                            Orgadmin.Show(this);
                            Hide();
                        break;
                    case 2:
                        Account.AccountType = 2;
                        OrgnaizerEmpHome OrgEmp = new OrgnaizerEmpHome();
                            OrgEmp.Tag = this;
                            OrgEmp.Show(this);
                            Hide();
                        break;
                    case 3:

                        Account.AccountType = 3;
                        AdminHome admin = new AdminHome();
                            admin.Tag = this;
                            admin.Show(this);
                            Hide();
                        break;
                    default:
                        MessageBox.Show("something went wrong");
                        break;



                }
            }
            else
            {
                MessageBox.Show("Invalid Username or password");
            }

        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            signup Form = new signup();
            Form.Tag = this;
            Form.Show(this);
            Hide();
        }
    }
}
