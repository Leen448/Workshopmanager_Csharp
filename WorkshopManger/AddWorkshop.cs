using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class AddWorkshop : Form
    {
        public AddWorkshop()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {   Workshop ws = new Workshop();
          
            int OrgID = -1;
            if (Account.AccountType == 2)
            {
                OrgEmployee emp = new OrgEmployee();
                OrgID = emp.GetOrgIdByEmpId(Account.AccountId);
            }
            else if (Account.AccountType == 1)
            {
                OrgID = Account.AccountId;
            }


            ws.AddWorkshop(
            textBoxTitle.Text,
            dateTimePickerDate.Value,
            textBoxDuration.Text,
            textBoxPresenter.Text,
            int.Parse(numericUpDownSeats.Text),
            textBoxLocation.Text,
            richTextBoxDesc.Text,
              OrgID);

            MessageBox.Show("Data Inserted successfully.");
            ClearControls();
        }


        private void ClearControls()
        {
            textBoxTitle.Text = "";
            dateTimePickerDate.Value = DateTime.Today;
            textBoxDuration.Text = "";
            textBoxPresenter.Text = "";
            numericUpDownSeats.Text = "";
            textBoxLocation.Text = "";
            richTextBoxDesc.Clear();

        }
        private void BacktoHomebtn(object sender, EventArgs e)
        {
            switch (Account.AccountType)
            {
                case 1:
                    OrganizerAdminHome Orgadmin = new OrganizerAdminHome();
                    Orgadmin.Tag = this;
                    Orgadmin.Show(this);
                    Hide();
                    break;
                case 2:
                    OrgnaizerEmpHome OrgEmp = new OrgnaizerEmpHome();
                    OrgEmp.Tag = this;
                    OrgEmp.Show(this);
                    Hide();
                    break;
            }
        }
    }
}
