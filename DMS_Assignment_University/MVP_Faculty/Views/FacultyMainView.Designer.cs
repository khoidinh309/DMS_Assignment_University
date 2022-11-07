namespace DMS_Assignment_University.MVP_Faculty.Views
{
    partial class FacultyMainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbox_faculty_name = new System.Windows.Forms.TextBox();
            this.txtbox_faculty_ID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbox_faculty_name);
            this.panel1.Controls.Add(this.txtbox_faculty_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 87);
            this.panel1.TabIndex = 0;
            // 
            // txtbox_faculty_name
            // 
            this.txtbox_faculty_name.Location = new System.Drawing.Point(556, 44);
            this.txtbox_faculty_name.Name = "txtbox_faculty_name";
            this.txtbox_faculty_name.Size = new System.Drawing.Size(198, 26);
            this.txtbox_faculty_name.TabIndex = 0;
            this.txtbox_faculty_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_faculty_ID
            // 
            this.txtbox_faculty_ID.Location = new System.Drawing.Point(591, 12);
            this.txtbox_faculty_ID.Name = "txtbox_faculty_ID";
            this.txtbox_faculty_ID.Size = new System.Drawing.Size(131, 26);
            this.txtbox_faculty_ID.TabIndex = 0;
            this.txtbox_faculty_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FacultyMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FacultyMainView";
            this.Text = "FacultyMainView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbox_faculty_name;
        private System.Windows.Forms.TextBox txtbox_faculty_ID;
    }
}