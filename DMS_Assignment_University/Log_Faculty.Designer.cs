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
            this.SuspendLayout();
            // 
            // lb_Faculty
            // 
            this.lb_Faculty.AutoSize = true;
            this.lb_Faculty.Location = new System.Drawing.Point(123, 102);
            this.lb_Faculty.Name = "lb_Faculty";
            this.lb_Faculty.Size = new System.Drawing.Size(114, 20);
            this.lb_Faculty.TabIndex = 0;
            this.lb_Faculty.Text = "Nhập Mã Khoa";
            // 
            // txtbox_faculty_ID
            // 
            this.txtbox_faculty_ID.Location = new System.Drawing.Point(127, 156);
            this.txtbox_faculty_ID.Name = "txtbox_faculty_ID";
            this.txtbox_faculty_ID.Size = new System.Drawing.Size(311, 26);
            this.txtbox_faculty_ID.TabIndex = 1;
            // 
            // btn_faculty_log_in
            // 
            this.btn_faculty_log_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_faculty_log_in.Location = new System.Drawing.Point(557, 140);
            this.btn_faculty_log_in.Name = "btn_faculty_log_in";
            this.btn_faculty_log_in.Size = new System.Drawing.Size(80, 49);
            this.btn_faculty_log_in.TabIndex = 2;
            this.btn_faculty_log_in.Text = "Log in";
            this.btn_faculty_log_in.UseVisualStyleBackColor = true;
            this.btn_faculty_log_in.Click += new System.EventHandler(this.btn_faculty_log_in_Click);
            // 
            // Log_Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_faculty_log_in);
            this.Controls.Add(this.txtbox_faculty_ID);
            this.Controls.Add(this.lb_Faculty);
            this.Name = "Log_Faculty";
            this.Text = "Log_Faculty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Faculty;
        private System.Windows.Forms.TextBox txtbox_faculty_ID;
        private System.Windows.Forms.Button btn_faculty_log_in;
    }
}