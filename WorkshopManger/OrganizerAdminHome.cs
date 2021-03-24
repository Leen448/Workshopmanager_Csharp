using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class OrganizerAdminHome : Form
    {
        public OrganizerAdminHome()
        {
            InitializeComponent();
            MyProfile_Click();
        }

        private void Manage_Employees_button_Click(object sender, EventArgs e)
        {
            ManageEmp emp = new ManageEmp();
            emp.Tag = this;
            emp.Show(this);
            Hide();
        }

        private void Add_New_Employees_button_Click(object sender, EventArgs e)
        {
            AddEmp emp = new AddEmp();
            emp.Tag = this;
            emp.Show(this);
            Hide();
        }

        private void Manage_Workshop_button_Click(object sender, EventArgs e)
        {
          ManageWorkshop ws = new ManageWorkshop();
            ws.Tag = this;
            ws.Show(this);
            Hide();
        }

        private void Add_New_Workshop_button_Click(object sender, EventArgs e)
        {
            AddWorkshop ADDws = new AddWorkshop();
            ADDws.Tag = this;
            ADDws.Show(this);
            Hide();
        }

        private void View_Audience_button_Click(object sender, EventArgs e)
        {
            ViewAudience VA = new ViewAudience();
            VA.Tag = this;
            VA.Show(this);
            Hide();

        }
        private void MyProfile_Click()
        {

            int Id = Account.AccountId;
            int tableNumber = Account.AccountType;

            DataTable DT = new Account().GetUserById(Id, tableNumber);
            DataRow row = DT.Rows[0];
            NameTextBox.Text = row["OrgName"].ToString();
            EmailtextBox.Text = row["Email"].ToString();
            PhonetextBox.Text = row["Phone"].ToString();
            PasswordtextBox.Text = row["OrgAdmPassword"].ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int Id = Account.AccountId;
            Organizer org = new Organizer();
            int result = org.UpdateOrganizer(Id, NameTextBox.Text, PhonetextBox.Text, EmailtextBox.Text, PasswordtextBox.Text);
            if (result != 0)
            {
                MessageBox.Show("Data Updated Successfully.");
                MyProfile_Click();

            }
        }



    }
}
