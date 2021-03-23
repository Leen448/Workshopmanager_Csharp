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
            DataTable data = workshop.GetAllWorkshop();
            if (data.Rows.Count != 0)
            {
                dgvWorkshop.DataSource = data;
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // call to UpdateCustomer Function
            int result = workshop.UpdateWorkshop(r, textBoxTitle.Text, dateTimePickerDate.Value, textBoxDuration.Text,
                 textBoxPresenter.Text, numericUpDownSeats.Value, textBoxLocation.Text, richTextBoxDesc.Text);


            if (result != 0)
            {
                MessageBox.Show("Data Updated Successfully.");
                LoadData();
                ClearControls();
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
            richTextBoxDesc.Text = "";
        }

        int r;
        private void dgvWorkshop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GetCustomerById
            r = (int)dgvWorkshop.CurrentRow.Cells[0].Value;
            DataTable dt = workshop.GetWorkshopById(r);
            DataRow row = dt.Rows[0];
            textBoxTitle.Text = row["Title"].ToString();
            dateTimePickerDate.Text = row["Date"].ToString();
            textBoxDuration.Text = row["Duration"].ToString();
            textBoxPresenter.Text = row["Presenter"].ToString();
            numericUpDownSeats.Text = row["SeatsCount"].ToString();
            textBoxLocation.Text = row["Location"].ToString();
            richTextBoxDesc.Text = row["Description"].ToString();

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

    }
}
