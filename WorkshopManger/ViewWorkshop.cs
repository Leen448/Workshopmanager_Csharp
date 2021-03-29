using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class ViewWorkshop : Form
    {
        public ViewWorkshop()
        {
            InitializeComponent();
        }

        private void BacktoHome_Click(object sender, EventArgs e)
        {
            
                    AdminHome admin = new AdminHome();
                    admin.Tag = this;
                    admin.Show(this);
                    Hide();

        }

        private void ViewWorkshop_Load(object sender, EventArgs e)
        {
            Workshop ws = new Workshop();
            DataTable data = ws.GetAllWorkshop();
            if (data.Rows.Count != 0)
            {
                dataGridView1.DataSource = data;
            }

        }
    }
}
