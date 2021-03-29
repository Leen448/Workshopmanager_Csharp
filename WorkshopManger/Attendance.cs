using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class Attendance : Form
    {
        DataTable Table;
        Workshop workshop = new Workshop();
        int OrgID = 0;

        
        public Attendance()
        {
            InitializeComponent();
        }

        private void Load_workshopTitle(object sender, EventArgs e)
        {   
            
            if (Account.AccountType == 2)
            {
                OrgEmployee emp = new OrgEmployee();
                OrgID = emp.GetOrgIdByEmpId(Account.AccountId);

            }
            else if (Account.AccountType == 1)
            {
                OrgID = Account.AccountId;
            }

            Workshop workshop = new Workshop();
            Table = workshop.GetWorkshopTitle(OrgID);
                 foreach (DataRow row in Table.Rows)
            {
                TitleList.Items.Add(row["Title"]);
            }
      
        }

        private void TitleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            String SelectedWorkshopTitle= TitleList.SelectedItem.ToString();

            DataTable RegestredAudiance = workshop.getAllRegisrtationbyOrg(OrgID,SelectedWorkshopTitle);
            int index = 0;
            int Wid=0;
            int AudID = 0;
            foreach (DataRow row in RegestredAudiance.Rows)
            { String name = row["AudName"].ToString();
              String Status;

                if ((row["Attendance"].ToString()).Equals("True")) {
                    Status = "Attend";
                }
                else {
                    Status = "Absent";
                }

                tableLayoutPanel1.Controls.Add(new Label() { Text = name, AutoSize = true }, 0, index);
               
                Button B = new Button();
                B.Text = Status;
                B.AutoSize = true;


                B.Click += (sender, EventArgs) => { ChangeStatusAttendance(sender, EventArgs, int.Parse(row["Wid"].ToString()), int.Parse(row["AudID"].ToString())); };
                tableLayoutPanel1.Controls.Add(B);

                index += 1;
            }

        }
        private void ChangeStatusAttendance(object sender, EventArgs e,int Wid,int AudID)
        {
            Button btn = (Button)sender;
         

           int result = workshop.Attendance_status_update(AudID, Wid);
            if (result != 0) {
                if (btn.Text == "Attend") {
                    btn.Text = "Absent";
                }
                else {
                    btn.Text = "Attend";
                }
             
            }
        }

        private void BacktoHomebtn(object sender, EventArgs e)
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
