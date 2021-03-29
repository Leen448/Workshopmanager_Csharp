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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Audience aud = new Audience();


            if ( FName_textbox.TextLength != 0 &&
                 LName_textbox.TextLength != 0 &&
                 Phone_textbox.TextLength != 0 &&
                 Email_textbox.TextLength != 0 &&
                 Password_textbox.TextLength != 0
                )
            {
                if (aud.AudienceSignUp(FName_textbox.Text,
                                       LName_textbox.Text,
                                       Phone_textbox.Text,
                                       Email_textbox.Text,
                                       Password_textbox.Text) == 1)
                {
                    FName_textbox.Text = "";
                    LName_textbox.Text = "";
                    Phone_textbox.Text = "";
                    Email_textbox.Text = "";
                    Password_textbox.Text = "";
                    MessageBox.Show("Signed up successfully..Now you can login to your account");
                 
                }
                else
                {
                    MessageBox.Show("User Already exists.. Please try to Login");
                }
            }else
            {
                MessageBox.Show("Please ensure fill all fileds"); 
            }

        }

   
        private void GoToLogin_Click(object sender, MouseEventArgs e)
        {
           
            User_Login Form = new User_Login();
            Form.Tag = this;
            Form.Show(this);
            Hide();

        }
    }
}
