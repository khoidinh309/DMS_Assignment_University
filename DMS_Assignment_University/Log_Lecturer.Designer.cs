namespace DMS_Assignment_University
{
    partial class Log_Lecturer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_lecturer_id = new System.Windows.Forms.TextBox();
            this.btn_log_in = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_error = new System.Windows.Forms.Panel();
            this.label_error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_error.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer ID";
            // 
            // txtbox_lecturer_id
            // 
            this.txtbox_lecturer_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtbox_lecturer_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_lecturer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_lecturer_id.ForeColor = System.Drawing.Color.White;
            this.txtbox_lecturer_id.Location = new System.Drawing.Point(123, 50);
            this.txtbox_lecturer_id.Name = "txtbox_lecturer_id";
            this.txtbox_lecturer_id.Size = new System.Drawing.Size(330, 23);
            this.txtbox_lecturer_id.TabIndex = 1;
            // 
            // btn_log_in
            // 
            this.btn_log_in.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_log_in.FlatAppearance.BorderSize = 2;
            this.btn_log_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log_in.ForeColor = System.Drawing.Color.Aqua;
            this.btn_log_in.Location = new System.Drawing.Point(329, 349);
            this.btn_log_in.Name = "btn_log_in";
            this.btn_log_in.Size = new System.Drawing.Size(137, 39);
            this.btn_log_in.TabIndex = 2;
            this.btn_log_in.Text = "Log in";
            this.btn_log_in.UseVisualStyleBackColor = true;
            this.btn_log_in.Click += new System.EventHandler(this.btn_log_in_Click);
            this.btn_log_in.MouseEnter += new System.EventHandler(this.btn_log_in_MouseEnter);
            this.btn_log_in.MouseLeave += new System.EventHandler(this.btn_log_in_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtbox_lecturer_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 103);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(123, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_error);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(169, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 162);
            this.panel3.TabIndex = 4;
            // 
            // panel_error
            // 
            this.panel_error.Controls.Add(this.label_error);
            this.panel_error.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_error.Location = new System.Drawing.Point(0, 103);
            this.panel_error.Name = "panel_error";
            this.panel_error.Size = new System.Drawing.Size(464, 40);
            this.panel_error.TabIndex = 5;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(119, 3);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(161, 20);
            this.label_error.TabIndex = 1;
            this.label_error.Text = "Mã Số Không Hợp Lệ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.hcmut;
            this.pictureBox1.Location = new System.Drawing.Point(311, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox2.Image = global::DMS_Assignment_University.Properties.Resources.profile_user;
            this.pictureBox2.Location = new System.Drawing.Point(21, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Log_Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_log_in);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log_Lecturer";
            this.Text = "Log_Lecturer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_error.ResumeLayout(false);
            this.panel_error.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_lecturer_id;
        private System.Windows.Forms.Button btn_log_in;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_error;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}