namespace DMS_Assignment_University
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_log_student = new System.Windows.Forms.Button();
            this.btn_log_lecturer = new System.Windows.Forms.Button();
            this.btn_log_faculty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.hcmut;
            this.pictureBox1.Location = new System.Drawing.Point(350, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // btn_log_student
            // 
            this.btn_log_student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_log_student.Location = new System.Drawing.Point(304, 255);
            this.btn_log_student.Name = "btn_log_student";
            this.btn_log_student.Size = new System.Drawing.Size(294, 56);
            this.btn_log_student.TabIndex = 2;
            this.btn_log_student.Text = "Student";
            this.btn_log_student.UseVisualStyleBackColor = true;
            this.btn_log_student.Click += new System.EventHandler(this.btn_log_student_Click);
            // 
            // btn_log_lecturer
            // 
            this.btn_log_lecturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_log_lecturer.Location = new System.Drawing.Point(304, 337);
            this.btn_log_lecturer.Name = "btn_log_lecturer";
            this.btn_log_lecturer.Size = new System.Drawing.Size(294, 56);
            this.btn_log_lecturer.TabIndex = 2;
            this.btn_log_lecturer.Text = "Lecturer";
            this.btn_log_lecturer.UseVisualStyleBackColor = true;
            this.btn_log_lecturer.Click += new System.EventHandler(this.btn_log_lecturer_Click);
            // 
            // btn_log_faculty
            // 
            this.btn_log_faculty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_log_faculty.Location = new System.Drawing.Point(304, 416);
            this.btn_log_faculty.Name = "btn_log_faculty";
            this.btn_log_faculty.Size = new System.Drawing.Size(294, 56);
            this.btn_log_faculty.TabIndex = 2;
            this.btn_log_faculty.Text = "Faculty";
            this.btn_log_faculty.UseVisualStyleBackColor = true;
            this.btn_log_faculty.Click += new System.EventHandler(this.btn_log_faculty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 561);
            this.Controls.Add(this.btn_log_faculty);
            this.Controls.Add(this.btn_log_lecturer);
            this.Controls.Add(this.btn_log_student);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_log_student;
        private System.Windows.Forms.Button btn_log_lecturer;
        private System.Windows.Forms.Button btn_log_faculty;
    }
}

