namespace DMS_Assignment_University
{
    partial class Log_Faculty
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
            this.lb_Faculty = new System.Windows.Forms.Label();
            this.txtbox_faculty_ID = new System.Windows.Forms.TextBox();
            this.btn_faculty_log_in = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_error = new System.Windows.Forms.Panel();
            this.label_error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_error.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Faculty
            // 
            this.lb_Faculty.AutoSize = true;
            this.lb_Faculty.Location = new System.Drawing.Point(125, 14);
            this.lb_Faculty.Name = "lb_Faculty";
            this.lb_Faculty.Size = new System.Drawing.Size(81, 20);
            this.lb_Faculty.TabIndex = 0;
            this.lb_Faculty.Text = "Faculty ID";
            // 
            // txtbox_faculty_ID
            // 
            this.txtbox_faculty_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtbox_faculty_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_faculty_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_faculty_ID.ForeColor = System.Drawing.Color.White;
            this.txtbox_faculty_ID.Location = new System.Drawing.Point(129, 37);
            this.txtbox_faculty_ID.Name = "txtbox_faculty_ID";
            this.txtbox_faculty_ID.Size = new System.Drawing.Size(311, 28);
            this.txtbox_faculty_ID.TabIndex = 1;
            // 
            // btn_faculty_log_in
            // 
            this.btn_faculty_log_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_faculty_log_in.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_faculty_log_in.FlatAppearance.BorderSize = 2;
            this.btn_faculty_log_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_faculty_log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_faculty_log_in.ForeColor = System.Drawing.Color.Aqua;
            this.btn_faculty_log_in.Location = new System.Drawing.Point(387, 399);
            this.btn_faculty_log_in.Name = "btn_faculty_log_in";
            this.btn_faculty_log_in.Size = new System.Drawing.Size(176, 45);
            this.btn_faculty_log_in.TabIndex = 2;
            this.btn_faculty_log_in.Text = "Log in";
            this.btn_faculty_log_in.UseVisualStyleBackColor = true;
            this.btn_faculty_log_in.Click += new System.EventHandler(this.btn_faculty_log_in_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtbox_faculty_ID);
            this.panel1.Controls.Add(this.lb_Faculty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 102);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(30, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(129, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel_error);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(198, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 157);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DMS_Assignment_University.Properties.Resources.hcmut;
            this.pictureBox2.Location = new System.Drawing.Point(410, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel_error
            // 
            this.panel_error.Controls.Add(this.label_error);
            this.panel_error.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_error.Location = new System.Drawing.Point(0, 102);
            this.panel_error.Name = "panel_error";
            this.panel_error.Size = new System.Drawing.Size(563, 39);
            this.panel_error.TabIndex = 4;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(125, 3);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(161, 20);
            this.label_error.TabIndex = 1;
            this.label_error.Text = "Mã Số Không Hợp Lệ";
            // 
            // Log_Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(919, 538);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_faculty_log_in);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log_Faculty";
            this.Text = "Log_Faculty";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_error.ResumeLayout(false);
            this.panel_error.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Faculty;
        private System.Windows.Forms.TextBox txtbox_faculty_ID;
        private System.Windows.Forms.Button btn_faculty_log_in;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_error;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}