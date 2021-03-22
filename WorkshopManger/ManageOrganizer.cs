using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class ManageOrganizer : Form
    {

        Organizer org = new Organizer();


        public ManageOrganizer()
        {
            InitializeComponent();
        }

        private void FRM_ManageOrganizer_Load(object sender, EventArgs e)
        {

            LoadData();

        }

        private void LoadData()
        {
            DataTable data = org.GetAllOrganizer();
            if (data.Rows.Count != 0)
            {
                dgvOrg.DataSource = data;
            }
        }

        private void updateOrg_Click(object sender, EventArgs e)
        {
            int result = org.UpdateOrganizer(r,textBoxName.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxPassword.Text);
            if (result != 0)
            {
                MessageBox.Show("Data Updated Successfully.");
                LoadData();
                ClearControls();
            }
        }


        private void ClearControls()
        {
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
        }

        int r;
        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GetCustomerById
            r = (int)dgvOrg.CurrentRow.Cells[0].Value;
            DataTable dt = org.GetOrganizerById(r);
            DataRow row = dt.Rows[0];
            textBoxName.Text = row["Name"].ToString();
            textBoxPhone.Text = row["Phone"].ToString();
            textBoxEmail.Text = row["Email"].ToString();
            textBoxPassword.Text = row["Password"].ToString();


        }

        private void deleteOrg_Click(object sender, EventArgs e)
        {
            int result = org.DeleteOrganizer(r);
            if (result != 0)
            {
                MessageBox.Show("Data Deleted.");
                ClearControls();
                LoadData();
            }
        }


    }
}
