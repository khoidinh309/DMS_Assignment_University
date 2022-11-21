namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    partial class LecturerMainView
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
            this.txtbox_fac_name = new System.Windows.Forms.TextBox();
            this.txtbox_lecturer_name = new System.Windows.Forms.TextBox();
            this.gradient_Panel1 = new DMS_Assignment_University.Gradient_Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gradient_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_fac_name
            // 
            this.txtbox_fac_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_fac_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtbox_fac_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_fac_name.ForeColor = System.Drawing.Color.White;
            this.txtbox_fac_name.Location = new System.Drawing.Point(771, 52);
            this.txtbox_fac_name.Name = "txtbox_fac_name";
            this.txtbox_fac_name.Size = new System.Drawing.Size(284, 19);
            this.txtbox_fac_name.TabIndex = 1;
            this.txtbox_fac_name.Text = "Khoa học và kỹ thuật Máy Tính";
            this.txtbox_fac_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_lecturer_name
            // 
            this.txtbox_lecturer_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_lecturer_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtbox_lecturer_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_lecturer_name.ForeColor = System.Drawing.Color.White;
            this.txtbox_lecturer_name.Location = new System.Drawing.Point(831, 12);
            this.txtbox_lecturer_name.Name = "txtbox_lecturer_name";
            this.txtbox_lecturer_name.Size = new System.Drawing.Size(173, 19);
            this.txtbox_lecturer_name.TabIndex = 0;
            this.txtbox_lecturer_name.Text = "Trần Thanh Bình";
            this.txtbox_lecturer_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gradient_Panel1
            // 
            this.gradient_Panel1.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.gradient_Panel1.ColorMid = System.Drawing.Color.Empty;
            this.gradient_Panel1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gradient_Panel1.Controls.Add(this.pictureBox3);
            this.gradient_Panel1.Controls.Add(this.pictureBox4);
            this.gradient_Panel1.Controls.Add(this.txtbox_lecturer_name);
            this.gradient_Panel1.Controls.Add(this.txtbox_fac_name);
            this.gradient_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradient_Panel1.Location = new System.Drawing.Point(0, 0);
            this.gradient_Panel1.Name = "gradient_Panel1";
            this.gradient_Panel1.Size = new System.Drawing.Size(1162, 87);
            this.gradient_Panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DMS_Assignment_University.Properties.Resources.logout;
            this.pictureBox3.Location = new System.Drawing.Point(1074, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.pictureBox4.Image = global::DMS_Assignment_University.Properties.Resources.hcmut;
            this.pictureBox4.Location = new System.Drawing.Point(21, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // LecturerMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 592);
            this.Controls.Add(this.gradient_Panel1);
            this.IsMdiContainer = true;
            this.Name = "LecturerMainView";
            this.Text = "LecturerMainView";
            this.gradient_Panel1.ResumeLayout(false);
            this.gradient_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_fac_name;
        private System.Windows.Forms.TextBox txtbox_lecturer_name;
        private Gradient_Panel gradient_Panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}