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
            this.txtbox_faculty_name = new System.Windows.Forms.TextBox();
            this.txtbox_faculty_ID = new System.Windows.Forms.TextBox();
            this.gradient_Panel1 = new DMS_Assignment_University.Gradient_Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gradient_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_faculty_name
            // 
            this.txtbox_faculty_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_faculty_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtbox_faculty_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_faculty_name.ForeColor = System.Drawing.Color.White;
            this.txtbox_faculty_name.Location = new System.Drawing.Point(935, 51);
            this.txtbox_faculty_name.Name = "txtbox_faculty_name";
            this.txtbox_faculty_name.Size = new System.Drawing.Size(198, 19);
            this.txtbox_faculty_name.TabIndex = 0;
            this.txtbox_faculty_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_faculty_ID
            // 
            this.txtbox_faculty_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_faculty_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtbox_faculty_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_faculty_ID.ForeColor = System.Drawing.Color.White;
            this.txtbox_faculty_ID.Location = new System.Drawing.Point(975, 12);
            this.txtbox_faculty_ID.Name = "txtbox_faculty_ID";
            this.txtbox_faculty_ID.Size = new System.Drawing.Size(131, 19);
            this.txtbox_faculty_ID.TabIndex = 0;
            this.txtbox_faculty_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gradient_Panel1
            // 
            this.gradient_Panel1.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.gradient_Panel1.ColorMid = System.Drawing.Color.Empty;
            this.gradient_Panel1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gradient_Panel1.Controls.Add(this.pictureBox3);
            this.gradient_Panel1.Controls.Add(this.pictureBox2);
            this.gradient_Panel1.Controls.Add(this.txtbox_faculty_name);
            this.gradient_Panel1.Controls.Add(this.txtbox_faculty_ID);
            this.gradient_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradient_Panel1.Location = new System.Drawing.Point(0, 0);
            this.gradient_Panel1.Name = "gradient_Panel1";
            this.gradient_Panel1.Size = new System.Drawing.Size(1282, 97);
            this.gradient_Panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.pictureBox3.Image = global::DMS_Assignment_University.Properties.Resources.hcmut;
            this.pictureBox3.Location = new System.Drawing.Point(33, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::DMS_Assignment_University.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(1199, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FacultyMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 650);
            this.Controls.Add(this.gradient_Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FacultyMainView";
            this.Text = "FacultyMainView";
            this.gradient_Panel1.ResumeLayout(false);
            this.gradient_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_faculty_name;
        private System.Windows.Forms.TextBox txtbox_faculty_ID;
        private Gradient_Panel gradient_Panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}