using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class ViewAudience : Form
    {
        public ViewAudience()
        {
            InitializeComponent();
          
        }

        private void BacktoHome_Click(object sender, EventArgs e)
        {
                switch (Account.AccountType)
                {
                case 1:
                    Account.AccountType = 1;
                    OrganizerAdminHome Orgadmin = new OrganizerAdminHome();
                    Orgadmin.Tag = this;
                    Orgadmin.Show(this);
                    Hide();
                    break;
                case 2:
                    Account.AccountType = 2;
                    OrgnaizerEmpHome OrgEmp = new OrgnaizerEmpHome();
                    OrgEmp.Tag = this;
                    OrgEmp.Show(this);
                    Hide();
                    break;
                case 3:

                    Account.AccountType = 3;
                    AdminHome admin = new AdminHome();
                    admin.Tag = this;
                    admin.Show(this);
                    Hide();
                    break;

            }
            
        }

        private void ViewAudience_Load(object sender, EventArgs e)
        {
           Audience aud = new Audience();
            DataTable data = aud.GetAllAudience();
            if (data.Rows.Count != 0)
            {
                dataGridView1.DataSource = data;
            }

        }

    }



}
