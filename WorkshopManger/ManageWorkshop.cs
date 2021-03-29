using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class ManageWorkshop : Form
    {

        Workshop workshop = new Workshop();
        OrgEmployee emp = new OrgEmployee();
      
        public ManageWorkshop()
        {
            InitializeComponent();

        }
        private void FRM_ManageWorkshop_Load(object sender, EventArgs e)
        {
            //call GetAllCustomers function
            // fill datagridview with returned of function
            LoadData();

        }

        private void LoadData()
        {
            if (Account.AccountType == 2)
            {
                int OrgID = emp.GetOrgIdByEmpId(Account.AccountId);
                DataTable data = workshop.GetAllOrgWorkshops(OrgID);
                if (data.Rows.Count != 0)
                {
                    dgvWorkshop.DataSource = data;
                }
            }
            else if(Account.AccountType == 1)
            {

                DataTable data = workshop.GetAllOrgWorkshops(Account.AccountId);
                if (data.Rows.Count != 0)
                {
                    dgvWorkshop.DataSource = data;
                }
            }

            
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Workshop workshop = new Workshop();

            // call to UpdateCustomer Function
            int OrgID = 0;
            if (Account.AccountType == 2)
            {
                OrgID = emp.GetOrgIdByEmpId(Account.AccountId);
            }
            else if (Account.AccountType == 1)
            {
                OrgID = Account.AccountId;
            }
            int result = workshop.UpdateWorkshop(r, textBoxTitle.Text, dateTimePickerDate.Value, textBoxDuration.Text,
                 textBoxPresenter.Text, numericUpDownSeats.Value, textBoxLocation.Text, richTextBoxDesc.Text, OrgID);


            if (result != 0)
            {
                MessageBox.Show("Data Updated.");
               
                LoadData();
                ClearControls();
            }
            else 
            {
                MessageBox.Show("Something went wrong try again later.");
            }



        }

        private void ClearControls()
        {
            textBoxTitle.Text = "";
            dateTimePickerDate.Text = "";
            textBoxDuration.Text = "";
            textBoxPresenter.Text = "";
            numericUpDownSeats.Text = "";
            textBoxLocation.Text = "";
            richTextBoxDesc.Clear();

        }

        int r;
        private void dgvWorkshop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GetCustomerById
            r = (int)dgvWorkshop.CurrentRow.Cells[0].Value;
            DataTable dt = workshop.GetWorkshopById(r);

            if (dt.Rows.Count != 0)
            {
                DataRow row = dt.Rows[0];
                textBoxTitle.Text = row["Title"].ToString();
                dateTimePickerDate.Value = DateTime.Parse(row["WDate"].ToString());
                textBoxDuration.Text = row["Duration"].ToString();
                textBoxPresenter.Text = row["Presenter"].ToString();
                numericUpDownSeats.Text = row["SeatsCount"].ToString();
                textBoxLocation.Text = row["WLocation"].ToString();
                richTextBoxDesc.Text = row["WDescription"].ToString();
            }
            else
            {
                MessageBox.Show("There is no data");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int result = workshop.DeleteWorkshop(r);
            if (result != 0)
            {
                MessageBox.Show("Data Deleted.");
                ClearControls();
                LoadData();
            }
        }


        private void BacktoHome_clcik(object sender, EventArgs e)
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
