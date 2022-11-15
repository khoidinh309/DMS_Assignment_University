namespace DMS_Assignment_University.MVP_Student.Views
{
    partial class MainStudentView
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
            this.gradient_Panel1 = new DMS_Assignment_University.Gradient_Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtbox_faculty_name = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.gradient_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient_Panel1
            // 
            this.gradient_Panel1.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.gradient_Panel1.ColorMid = System.Drawing.Color.Empty;
            this.gradient_Panel1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gradient_Panel1.Controls.Add(this.pictureBox2);
            this.gradient_Panel1.Controls.Add(this.pictureBox3);
            this.gradient_Panel1.Controls.Add(this.txtbox_faculty_name);
            this.gradient_Panel1.Controls.Add(this.txtbox_name);
            this.gradient_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradient_Panel1.Location = new System.Drawing.Point(0, 0);
            this.gradient_Panel1.Name = "gradient_Panel1";
            this.gradient_Panel1.Size = new System.Drawing.Size(1465, 100);
            this.gradient_Panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::DMS_Assignment_University.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(1377, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.pictureBox3.Image = global::DMS_Assignment_University.Properties.Resources.hcmut;
            this.pictureBox3.Location = new System.Drawing.Point(21, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // txtbox_faculty_name
            // 
            this.txtbox_faculty_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_faculty_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtbox_faculty_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_faculty_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_faculty_name.Location = new System.Drawing.Point(1002, 52);
            this.txtbox_faculty_name.Name = "txtbox_faculty_name";
            this.txtbox_faculty_name.Size = new System.Drawing.Size(358, 23);
            this.txtbox_faculty_name.TabIndex = 4;
            this.txtbox_faculty_name.Text = "Khoa khoa học và kỹ thuật Máy Tính";
            this.txtbox_faculty_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtbox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtbox_name.Location = new System.Drawing.Point(1086, 12);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(166, 23);
            this.txtbox_name.TabIndex = 3;
            this.txtbox_name.Text = "Đinh Tiến Khởi";
            this.txtbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 686);
            this.Controls.Add(this.gradient_Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainStudentView";
            this.Text = "MainStudentView";
            this.gradient_Panel1.ResumeLayout(false);
            this.gradient_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_faculty_name;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Gradient_Panel gradient_Panel1;
    }
}