using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class OrganizerAdminHome : Form
    {
        public OrganizerAdminHome()
        {
            InitializeComponent();
        }

        private void Manage_Employees_button_Click(object sender, EventArgs e)
        {
            ManageEmp emp = new ManageEmp();
            emp.Tag = this;
            emp.Show(this);
            Hide();
        }

        private void Add_New_Employees_button_Click(object sender, EventArgs e)
        {
            AddEmp emp = new AddEmp();
            emp.Tag = this;
            emp.Show(this);
            Hide();
        }

        private void Manage_Workshop_button_Click(object sender, EventArgs e)
        {
          ManageWorkshop ws = new ManageWorkshop();
            ws.Tag = this;
            ws.Show(this);
            Hide();
        }

        private void Add_New_Workshop_button_Click(object sender, EventArgs e)
        {
            AddWorkshop ADDws = new AddWorkshop();
            ADDws.Tag = this;
            ADDws.Show(this);
            Hide();
        }

        private void View_Audience_button_Click(object sender, EventArgs e)
        {
            ViewAudience VA = new ViewAudience();
            VA.Tag = this;
            VA.Show(this);
            Hide();

        }
    }
}
