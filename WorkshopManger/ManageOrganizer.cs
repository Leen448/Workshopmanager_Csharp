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
            int result = org.UpdateOrganizer(r,textBoxNameOrg.Text, textBoxPhoneOrg.Text, textBoxEmailOrg.Text, textBoxPasswordOrg.Text);
            if (result != 0)
            {
                MessageBox.Show("Data Updated Successfully.");
                LoadData();
                ClearControls();
            }
        }


        private void ClearControls()
        {
            textBoxNameOrg.Text = "";
            textBoxPhoneOrg.Text = "";
            textBoxEmailOrg.Text = "";
            textBoxPasswordOrg.Text = "";
        }

        int r;
        private void dgvOrg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            r = (int)dgvOrg.CurrentRow.Cells[0].Value;
            DataTable dt = org.GetOrganizerById(r);
            DataRow row = dt.Rows[0];
            textBoxNameOrg.Text = row["OrgName"].ToString();
            textBoxPhoneOrg.Text = row["Phone"].ToString();
            textBoxEmailOrg.Text = row["Email"].ToString();
            textBoxPasswordOrg.Text = row["OrgAdmPassword"].ToString();
            

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
