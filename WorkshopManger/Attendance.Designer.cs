
namespace WorkshopManger
{
    partial class Attendance
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BacktoHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleList = new System.Windows.Forms.ComboBox();
            this.Attendance_Status = new System.Windows.Forms.Label();
            this.Audiecne_Nmae = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BacktoHome);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.TitleList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Attendance_Status);
            this.splitContainer1.Panel2.Controls.Add(this.Audiecne_Nmae);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(905, 581);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // BacktoHome
            // 
            this.BacktoHome.AutoSize = true;
            this.BacktoHome.Location = new System.Drawing.Point(13, 537);
            this.BacktoHome.Name = "BacktoHome";
            this.BacktoHome.Size = new System.Drawing.Size(87, 32);
            this.BacktoHome.TabIndex = 2;
            this.BacktoHome.Text = "Home";
            this.BacktoHome.UseVisualStyleBackColor = true;
            this.BacktoHome.Click += new System.EventHandler(this.BacktoHomebtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Workshop:";
            // 
            // TitleList
            // 
            this.TitleList.FormattingEnabled = true;
            this.TitleList.Location = new System.Drawing.Point(13, 60);
            this.TitleList.Name = "TitleList";
            this.TitleList.Size = new System.Drawing.Size(260, 28);
            this.TitleList.TabIndex = 0;
            this.TitleList.SelectedIndexChanged += new System.EventHandler(this.TitleList_SelectedIndexChanged);
            // 
            // Attendance_Status
            // 
            this.Attendance_Status.AutoSize = true;
            this.Attendance_Status.Location = new System.Drawing.Point(427, 13);
            this.Attendance_Status.Name = "Attendance_Status";
            this.Attendance_Status.Size = new System.Drawing.Size(127, 20);
            this.Attendance_Status.TabIndex = 2;
            this.Attendance_Status.Text = "Attendance status";
            // 
            // Audiecne_Nmae
            // 
            this.Audiecne_Nmae.AutoSize = true;
            this.Audiecne_Nmae.Location = new System.Drawing.Point(88, 13);
            this.Audiecne_Nmae.Name = "Audiecne_Nmae";
            this.Audiecne_Nmae.Size = new System.Drawing.Size(115, 20);
            this.Audiecne_Nmae.TabIndex = 1;
            this.Audiecne_Nmae.Text = "Audiecne Nmae";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(88, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 125);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Attendance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(905, 581);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Load_workshopTitle);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BacktoHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TitleList;
        private System.Windows.Forms.Label Attendance_Status;
        private System.Windows.Forms.Label Audiecne_Nmae;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}