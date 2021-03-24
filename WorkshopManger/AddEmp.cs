using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class AddEmp : Form
    {
        public AddEmp()
        {
            InitializeComponent();
        }

        private void buttonAddNewEmp_Click(object sender, EventArgs e)
        {
           
            OrgEmployee oe = new OrgEmployee();
            oe.AddEmp(FName_textbox.Text, LName_textbox.Text, Phone_textbox.Text,Email_textbox.Text, Password_textbox.Text, Account.AccountId);
            MessageBox.Show("Data Inserted successfully.");
            FName_textbox.Text = "";
            LName_textbox.Text = "";
            Phone_textbox.Text = "";
            Email_textbox.Text = "";
            Password_textbox.Text = "";
        }
    }
}
