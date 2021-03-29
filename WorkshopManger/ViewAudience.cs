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
            String Query = "";


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


            switch (Account.AccountType)
            {
                case 1:
                    Query = "Select DISTINCT Audience.ID,FName,LName,Email,Phone from Audience " +
                        "join Registration on Registration.AudienceID = Audience.ID " +
                        "where Registration.OrganaizerID="+OrgID;
                    break;
                case 2:
                    Query = "Select DISTINCT  Audience.ID,FName,LName,Email,Phone from Audience " +
                            "join Registration on Registration.AudienceID = Audience.ID " +
                            "where Registration.OrganaizerID="+OrgID;
                    break;
                case 3:
                    Query = "Select * from Audience";
                    break;
            }

            DataTable data = aud.GetAllAudience(Query);
            if (data.Rows.Count != 0)
            {
                dataGridView1.DataSource = data;
            }

        }

    }



}
