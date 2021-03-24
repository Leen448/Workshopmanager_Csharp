using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class AudienceHome : Form
    {
        
        public AudienceHome()
        {
            InitializeComponent();
            //MyProfile_Click();
            //Load_workshop();
            
        }

        //private void Load_workshop() {
        //    Workshop workshop = new Workshop();

        //    DataTable WSTable = workshop.GetUnEnrolledWorkshop(Account.AccountId);
        //    DataTable WSENrolledId = workshop.GetEnrolledWorkshop(Account.AccountId);

        //    int count= WSENrolledId.Rows.Count;
        //    if (count == 0)
        //    {
        //        foreach (DataRow row in WSTable.Rows)
        //        {
        //            flowLayoutPanel1.Controls.Add(GetGroupBox(row, 800, 250, false));
        //        }
        //    }
        //    else
        //    {

        //        foreach (DataRow row in WSTable.Rows)
        //        {
        //            foreach (DataRow rowId in WSENrolledId.Rows)
        //            {
        //                if (rowId["WorkshopID"] != row["ID"])
        //                {
        //                    flowLayoutPanel1.Controls.Add(GetGroupBox(row, 800, 250, false));
        //                }
        //                else {
        //                    flowLayoutPanel1.Controls.Add(GetGroupBox(row, 800, 250, false));
        //                }

        //            }
        //        }
        //    }
        //}


        ////private void Load_Enrolledworkshop()
        ////{


        ////}


        //private GroupBox GetGroupBox(DataRow row, int width, int height,bool flag)
        //{
        //    int OrgID =(int) row["OrgID"];
        //    Organizer org = new Organizer();


        //    DataTable OrgTb = org.GetOrganizerById(OrgID);
        //    String  OrgName = OrgTb.Rows[0]["OrgName"].ToString();


        //    GroupBox g = new GroupBox();
        //    g.Size = new Size(width, height);
        //    g.Text = row["Title"].ToString();


        //    Label Orgnaizer = new Label();
        //    Orgnaizer.Text = "Provided by: " + OrgName;
        //    Orgnaizer.AutoSize = true;
        //    Orgnaizer.Location = new Point(5, 40);

        //    Label Presenter = new Label();
        //    Presenter.Text="Presenter name: " + row["Presenter"].ToString();
        //    Presenter.AutoSize=true;
        //    Presenter.Location = new Point(5,60);


        //    Label Date = new Label();
        //    Date.Text = "Date: " + row["WDate"].ToString();
        //    Date.AutoSize = true;
        //    Date.Location = new Point(5, 80);


        //    Label Duration = new Label();
        //    Duration.Text = "Duration: " + row["Duration"].ToString();
        //    Duration.AutoSize = true;
        //    Duration.Location = new Point(5, 100);


        //    Label Location = new Label();
        //    Location.Text = "Location: " + row["WLocation"].ToString();
        //    Location.AutoSize = true;
        //    Location.Location = new Point(5, 120);



        //    Label DescriptionLable = new Label();
        //    DescriptionLable.Text = "Description: ";
        //    DescriptionLable.AutoSize = true;
        //    DescriptionLable.Location = new Point(5, 140);


        //    Label Description = new Label();
        //    Description.Text = row["WDescription"].ToString();
        //    Description.AutoSize = true;
        //    Description.TextAlign= ContentAlignment.MiddleLeft;
        //    Description.MaximumSize = new Size(500, 0);
        //    Description.Location = new Point(70, 140);

        //    Button EnrollBtn = new Button();

        //    EnrollBtn.Location = new Point(500,0);
        //    EnrollBtn.Size = new Size(80, 40);
        //    if (flag == false)
        //    {
        //        EnrollBtn.Text = "Enroll";
        //        // you can add an event here...
        //        EnrollBtn.Click += (s, e) => EnrollBtnEvent((int)row["ID"], (int)row["OrgID"]);
        //    }
        //    else
        //    {
        //        EnrollBtn.Text = "Unenroll";
        //        // you can add an event here...
        //        EnrollBtn.Click += (s, e) => UnEnrollBtnEvent((int)row["ID"]);

        //    }

        //    g.Controls.Add(Orgnaizer);
        //    g.Controls.Add(Presenter);
        //    g.Controls.Add(Date);
        //    g.Controls.Add(Duration);
        //    g.Controls.Add(Location);
        //    g.Controls.Add(DescriptionLable);
        //    g.Controls.Add(Description);
        //    g.Controls.Add(EnrollBtn);
        //    return g;
        //}

        //private void EnrollBtnEvent(int Wid, int orgId )
        //{

        //    Audience aud = new Audience();

        //    if (aud.Regester(Account.AccountId, Wid, orgId) == 1)
        //    {
        //        MessageBox.Show("Enrolled successfully.");
        //        AudienceHome from = new AudienceHome();
        //        from.Tag = this;
        //        from.Show(this);
        //        Hide();
        //    }
        //    else if (aud.Regester(Account.AccountId, Wid, orgId) == 0)
        //    {

        //        MessageBox.Show("Something went wrong please try agin later.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("You are alreadey Enrolled in this workshop");
        //    }


        //}


        //private void UnEnrollBtnEvent(int Wid) {
        //    Audience aud = new Audience();

        //    if (aud.DeleteRegistration(Account.AccountId, Wid) == 1)
        //    {
        //        MessageBox.Show("Unenrolled successfully.");

        //    }
        //    else if (aud.DeleteRegistration(Account.AccountId, Wid) == 0)
        //    {

        //        MessageBox.Show("Something went wrong please try agin later.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("You are alreadey Unenrolled in this workshop");
        //    }
        //}


        private void MyProfile_Click()
        {

            int Id = Account.AccountId;
            int tableNumber = Account.AccountType;

            DataTable DT = new Account().GetUserById(Id, tableNumber);
            DataRow row = DT.Rows[0];
            FNametextBox.Text = row["FName"].ToString();
            LNametextBox.Text = row["LName"].ToString();
            EmailtextBox.Text = row["Email"].ToString();
            PhonetextBox.Text = row["Phone"].ToString();
            PasswordtextBox.Text = row["AudPassword"].ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int Id = Account.AccountId;
            Audience aud = new Audience();
            int result = aud.UpdateAud(Id, FNametextBox.Text, LNametextBox.Text, PhonetextBox.Text, EmailtextBox.Text, PasswordtextBox.Text);
            if (result != 0)
            {
                MessageBox.Show("Data Updated Successfully.");
                MyProfile_Click();

            }
        }

    }
}

