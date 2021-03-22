
namespace WorkshopManger
{
    partial class AudienceHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logouttoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MyProfiletoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EnrolledtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logouttoolStripMenuItem1,
            this.MyProfiletoolStripMenuItem1,
            this.EnrolledtoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // logouttoolStripMenuItem1
            // 
            this.logouttoolStripMenuItem1.Name = "logouttoolStripMenuItem1";
            this.logouttoolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.logouttoolStripMenuItem1.Text = "Logout";
            // 
            // MyProfiletoolStripMenuItem1
            // 
            this.MyProfiletoolStripMenuItem1.Name = "MyProfiletoolStripMenuItem1";
            this.MyProfiletoolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.MyProfiletoolStripMenuItem1.Text = "My Profile";
            // 
            // EnrolledtoolStripMenuItem1
            // 
            this.EnrolledtoolStripMenuItem1.Name = "EnrolledtoolStripMenuItem1";
            this.EnrolledtoolStripMenuItem1.Size = new System.Drawing.Size(154, 24);
            this.EnrolledtoolStripMenuItem1.Text = "Enrolled Workshops";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(822, 560);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // AudienceHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 595);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AudienceHome";
            this.Text = "Audience";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logouttoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MyProfiletoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EnrolledtoolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}