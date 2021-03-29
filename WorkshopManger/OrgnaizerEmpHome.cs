using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class OrgnaizerEmpHome : Form
    {
        public OrgnaizerEmpHome()
        {
            InitializeComponent();
            MyProfile_Click();
        }

        private void buttonViewWorkshop_Click(object sender, EventArgs e)
        {
            ManageWorkshop Mw = new ManageWorkshop();
            Mw.Tag = this;
            Mw.Show(this);
            Hide();
        }

        private void buttonAddNewWorkshop_Click(object sender, EventArgs e)
        {
            AddWorkshop aw = new AddWorkshop();
            aw.Tag = this;
            aw.Show(this);
            Hide();
        }

        private void buttonViewAud_Click(object sender, EventArgs e)
        {
            ViewAudience va = new ViewAudience();
            va.Tag = this;
            va.Show(this);
            Hide();
        }

        private void buttonTakeAtt_Click(object sender, EventArgs e)
        {
            Attendance att = new Attendance();
            att.Tag = this;
            att.Show(this);
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
            PasswordtextBox.Text = row["EmpPassword"].ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int Id = Account.AccountId;
            OrgEmployee emp = new OrgEmployee();
            int result = emp.UpdateEmpinfo(Id, FNametextBox.Text, LNametextBox.Text, PhonetextBox.Text, EmailtextBox.Text, PasswordtextBox.Text);
            if (result != 0)
            {
                MessageBox.Show("Data Updated Successfully.");
                MyProfile_Click();

            }
        }



        private void Logout_Click(object sender, EventArgs e)
        {
            Account.AccountId = -1;
            Account.AccountType = -1;
            User_Login user = new User_Login();
            user.Tag = this;
            user.Show(this);
            Hide();
        }

    }
}
