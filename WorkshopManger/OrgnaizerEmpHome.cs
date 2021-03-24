using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManger
{
    public partial class OrgnaizerEmpHome : Form
    {
        public OrgnaizerEmpHome()
        {
            InitializeComponent();
        }

        private void buttonViewWorkshop_Click(object sender, EventArgs e)
        {
            ManageWorkshop Mw = new ManageWorkshop();
            Mw.Tag = this;
            Mw.Show(this);
            Hide();
        }

        private void buttonAddNewWorkshop_Click(object sender, EventArgs e)
        {
            AddWorkshop aw = new AddWorkshop();
            aw.Tag = this;
            aw.Show(this);
            Hide();
        }

        private void buttonViewAud_Click(object sender, EventArgs e)
        {
            ViewAudience va = new ViewAudience();
            va.Tag = this;
            va.Show(this);
            Hide();
        }


    }
}
