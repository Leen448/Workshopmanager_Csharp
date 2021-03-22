using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class AddOrganizer : Form
    {
        public AddOrganizer()
        {
            InitializeComponent();
        }

        private void buttonAddOrg_Click(object sender, EventArgs e)
        {


            Organizer org = new Organizer();
            org.AddOrganizer(textBoxName.Text, textBoxPhone.Text, textBoxEmail.Text,
                textBoxPassword.Text);
            MessageBox.Show("Data Inserted successfully.");
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";


        }
    }
}
