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
            String Query="";

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
                case 2:
                    Query = "Select * from  Workshop where OrgID=" + OrgID;
                    break;
                case 3:
                    Query = "Select * from Workshop";
                    break;
            }




            DataTable data = ws.GetAllWorkshop(Query);
            if (data.Rows.Count != 0)
            {
                dataGridView1.DataSource = data;
            }

        }
    }
}
