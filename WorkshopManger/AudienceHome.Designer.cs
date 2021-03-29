
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.My_Profile_Tab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.LNametextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Workshops_tab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.My_Profile_Tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Workshops_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.My_Profile_Tab);
            this.tabControl1.Controls.Add(this.Workshops_tab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 590);
            this.tabControl1.TabIndex = 10;
            // 
            // My_Profile_Tab
            // 
            this.My_Profile_Tab.Controls.Add(this.panel1);
            this.My_Profile_Tab.Location = new System.Drawing.Point(4, 29);
            this.My_Profile_Tab.Name = "My_Profile_Tab";
            this.My_Profile_Tab.Size = new System.Drawing.Size(816, 557);
            this.My_Profile_Tab.TabIndex = 2;
            this.My_Profile_Tab.Text = "My Profile";
            this.My_Profile_Tab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.PasswordtextBox);
            this.panel1.Controls.Add(this.EmailtextBox);
            this.panel1.Controls.Add(this.PhonetextBox);
            this.panel1.Controls.Add(this.LNametextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FNametextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 561);
            this.panel1.TabIndex = 0;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(187, 423);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(539, 37);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(187, 353);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(539, 27);
            this.PasswordtextBox.TabIndex = 19;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(187, 277);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(539, 27);
            this.EmailtextBox.TabIndex = 18;
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(187, 200);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(539, 27);
            this.PhonetextBox.TabIndex = 17;
            // 
            // LNametextBox
            // 
            this.LNametextBox.Location = new System.Drawing.Point(187, 128);
            this.LNametextBox.Name = "LNametextBox";
            this.LNametextBox.Size = new System.Drawing.Size(539, 27);
            this.LNametextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name";
            // 
            // FNametextBox
            // 
            this.FNametextBox.Location = new System.Drawing.Point(187, 50);
            this.FNametextBox.Name = "FNametextBox";
            this.FNametextBox.Size = new System.Drawing.Size(539, 27);
            this.FNametextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            // 
            // Workshops_tab
            // 
            this.Workshops_tab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Workshops_tab.Controls.Add(this.flowLayoutPanel1);
            this.Workshops_tab.Location = new System.Drawing.Point(4, 29);
            this.Workshops_tab.Name = "Workshops_tab";
            this.Workshops_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Workshops_tab.Size = new System.Drawing.Size(816, 557);
            this.Workshops_tab.TabIndex = 1;
            this.Workshops_tab.Text = "Workshops";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(824, 561);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 557);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Logout";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.Logout_Click);
            // 
            // AudienceHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 595);
            this.Controls.Add(this.tabControl1);
            this.Name = "AudienceHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audience";
            this.tabControl1.ResumeLayout(false);
            this.My_Profile_Tab.ResumeLayout(false);
            this.My_Profile_Tab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Workshops_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enrolled_Workshops_tap;
        private System.Windows.Forms.TabPage Workshops_tab;
        private System.Windows.Forms.TabPage My_Profile_Tab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.TextBox LNametextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FNametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabPage tabPage1;
    }
}