
namespace WorkshopManger
{
    partial class ManageOrganizer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BacktoHome = new System.Windows.Forms.Button();
            this.deleteOrg = new System.Windows.Forms.Button();
            this.updateOrg = new System.Windows.Forms.Button();
            this.dgvOrg = new System.Windows.Forms.DataGridView();
            this.textBoxPhoneOrg = new System.Windows.Forms.TextBox();
            this.textBoxEmailOrg = new System.Windows.Forms.TextBox();
            this.textBoxPasswordOrg = new System.Windows.Forms.TextBox();
            this.textBoxNameOrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BacktoHome);
            this.groupBox1.Controls.Add(this.deleteOrg);
            this.groupBox1.Controls.Add(this.updateOrg);
            this.groupBox1.Controls.Add(this.dgvOrg);
            this.groupBox1.Controls.Add(this.textBoxPhoneOrg);
            this.groupBox1.Controls.Add(this.textBoxEmailOrg);
            this.groupBox1.Controls.Add(this.textBoxPasswordOrg);
            this.groupBox1.Controls.Add(this.textBoxNameOrg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(874, 529);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Organizer";
            // 
            // BacktoHome
            // 
            this.BacktoHome.Location = new System.Drawing.Point(744, 472);
            this.BacktoHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BacktoHome.Name = "BacktoHome";
            this.BacktoHome.Size = new System.Drawing.Size(87, 32);
            this.BacktoHome.TabIndex = 11;
            this.BacktoHome.Text = "Cancel";
            this.BacktoHome.UseVisualStyleBackColor = true;
            this.BacktoHome.Click += new System.EventHandler(this.BacktoHomebtn);
            // 
            // deleteOrg
            // 
            this.deleteOrg.Location = new System.Drawing.Point(641, 472);
            this.deleteOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteOrg.Name = "deleteOrg";
            this.deleteOrg.Size = new System.Drawing.Size(87, 32);
            this.deleteOrg.TabIndex = 10;
            this.deleteOrg.Text = "Delete";
            this.deleteOrg.UseVisualStyleBackColor = true;
            this.deleteOrg.Click += new System.EventHandler(this.deleteOrg_Click);
            // 
            // updateOrg
            // 
            this.updateOrg.Location = new System.Drawing.Point(538, 472);
            this.updateOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateOrg.Name = "updateOrg";
            this.updateOrg.Size = new System.Drawing.Size(87, 32);
            this.updateOrg.TabIndex = 9;
            this.updateOrg.Text = "Update";
            this.updateOrg.UseVisualStyleBackColor = true;
            this.updateOrg.Click += new System.EventHandler(this.updateOrg_Click);
            // 
            // dgvOrg
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrg.Location = new System.Drawing.Point(57, 192);
            this.dgvOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrg.Name = "dgvOrg";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrg.RowHeadersWidth = 51;
            this.dgvOrg.RowTemplate.Height = 25;
            this.dgvOrg.Size = new System.Drawing.Size(775, 236);
            this.dgvOrg.TabIndex = 8;
            this.dgvOrg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrg_CellContentClick);
            // 
            // textBoxPhoneOrg
            // 
            this.textBoxPhoneOrg.Location = new System.Drawing.Point(560, 132);
            this.textBoxPhoneOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhoneOrg.Name = "textBoxPhoneOrg";
            this.textBoxPhoneOrg.Size = new System.Drawing.Size(271, 27);
            this.textBoxPhoneOrg.TabIndex = 7;
            // 
            // textBoxEmailOrg
            // 
            this.textBoxEmailOrg.Location = new System.Drawing.Point(560, 57);
            this.textBoxEmailOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmailOrg.Name = "textBoxEmailOrg";
            this.textBoxEmailOrg.Size = new System.Drawing.Size(271, 27);
            this.textBoxEmailOrg.TabIndex = 6;
            // 
            // textBoxPasswordOrg
            // 
            this.textBoxPasswordOrg.Location = new System.Drawing.Point(170, 132);
            this.textBoxPasswordOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPasswordOrg.Name = "textBoxPasswordOrg";
            this.textBoxPasswordOrg.Size = new System.Drawing.Size(259, 27);
            this.textBoxPasswordOrg.TabIndex = 5;
            // 
            // textBoxNameOrg
            // 
            this.textBoxNameOrg.Location = new System.Drawing.Point(170, 57);
            this.textBoxNameOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNameOrg.Name = "textBoxNameOrg";
            this.textBoxNameOrg.Size = new System.Drawing.Size(259, 27);
            this.textBoxNameOrg.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(466, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(466, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // ManageOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 581);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageOrganizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrganizer";
            this.Load += new System.EventHandler(this.FRM_ManageOrganizer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteOrg;
        private System.Windows.Forms.Button updateOrg;
        private System.Windows.Forms.DataGridView dgvOrg;
        private System.Windows.Forms.TextBox textBoxPhoneOrg;
        private System.Windows.Forms.TextBox textBoxEmailOrg;
        private System.Windows.Forms.TextBox textBoxPasswordOrg;
        private System.Windows.Forms.TextBox textBoxNameOrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BacktoHome;
    }
}