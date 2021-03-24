using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class ManageEmp : Form
    {
        OrgEmployee emp = new OrgEmployee();
        public ManageEmp()
        {
            InitializeComponent();
        }

        private void FRM_ManageEmp_Load(object sender, EventArgs e)
        {
            //call GetAllCustomers function
            // fill datagridview with returned of function
            LoadData();

        }

        private void LoadData()
        {
            OrgEmployee emp = new OrgEmployee();
            int OrgID = Account.AccountId;
            MessageBox.Show("OrgID:" + OrgID);
            DataTable data = emp.GetAllEmpInOrg(OrgID);
            if (data.Rows.Count != 0)
            {
                dataGridView1.DataSource = data;
            }
        }



        private void Update_button_click(object sender, EventArgs e)
        {
            int result = emp.UpdateEmp(r, FName_textbox.Text, LName_textbox.Text , Phone_textbox.Text, Email_textbox.Text , Account.AccountId);
            if (result != 0)
            {
                MessageBox.Show("Data Updated Successfully.");
                LoadData();
                ClearControls();
            }

        }


        private void Delete_button_click(object sender, EventArgs e)
        {
            int result = emp.DeleteEmp(r);
            if (result != 0)
            {
                MessageBox.Show("Data Deleted.");
                ClearControls();
                LoadData();
            }

        }



        int r;
        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            r = (int)dataGridView1.CurrentRow.Cells[0].Value;
            DataTable dt = emp.GetEmployeeById(r);
            if (dt.Rows.Count != 0)
            {


                DataRow row = dt.Rows[0];
                FName_textbox.Text = row["FName"].ToString();
                LName_textbox.Text = row["LName"].ToString();
                Phone_textbox.Text = row["Phone"].ToString();
                Email_textbox.Text = row["Email"].ToString();
            }
            else {
                MessageBox.Show("There is no data");
            }

        }




        private void ClearControls()
        {
            FName_textbox.Text = "";
            LName_textbox.Text = "";
            Phone_textbox.Text = "";
            Email_textbox.Text = "";
        }





    }
}
