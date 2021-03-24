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
        {

            OrgEmployee emp = new OrgEmployee();
            int OrgID = emp.GetOrgIdByEmpId(Account.AccountId);
            
            Workshop workshop = new Workshop();
            workshop.AddWorkshop(textBoxTitle.Text, dateTimePickerDate.Value, textBoxDuration.Text,
                textBoxPresenter.Text, numericUpDownSeats.Value, textBoxLocation.Text, richTextBoxDesc.Text, OrgID);
            MessageBox.Show("Data Inserted successfully.");
            textBoxTitle.Text = "";
            dateTimePickerDate.Text = "";
            textBoxDuration.Text = "";
            textBoxPresenter.Text = "";
            numericUpDownSeats.Text = "";
            textBoxLocation.Text = "";
            richTextBoxDesc.Text = "";
        }
    }
}
