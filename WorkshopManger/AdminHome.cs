using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            MyProfile_Click();
        }

        private void ManageOrgnaizer_Click(object sender, EventArgs e)
        {
            ManageOrganizer MOrg = new ManageOrganizer();
            MOrg.Tag = this;
            MOrg.Show(this);
            Hide();
        }

        private void AddNewOrg_Click(object sender, EventArgs e)
        {
            AddOrganizer AddNewOrg = new AddOrganizer();
            AddNewOrg.Tag = this;
            AddNewOrg.Show(this);
            Hide();
        }


        private void ViewWorkshop_Click(object sender, EventArgs e)
        {



        }

        private void ViewAudience_Click(object sender, EventArgs e)
        {

            ViewAudience ViewAud = new ViewAudience();
            ViewAud.Tag = this;
            ViewAud.Show(this);
            Hide();

        }

        private void MyProfile_Click()
        {

            int Id = Account.AccountId;
            int tableNumber = Account.AccountType;

            DataTable DT = new Account().GetUserById(Id, tableNumber);
            DataRow row = DT.Rows[0];
            FNametextBox.Text = row["FName"].ToString();
            LNametextBox.Text = row["LName"].ToString();
            EmailtextBox.Text = row["Email"].ToString();
            PhonetextBox.Text = row["Phone"].ToString();
            PasswordtextBox.Text = row["UserPassword"].ToString();

        }
    }
}
