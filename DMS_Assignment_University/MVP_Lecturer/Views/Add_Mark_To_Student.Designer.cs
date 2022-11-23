namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    partial class Add_Mark_To_Student
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
            this.lb_student_id = new System.Windows.Forms.Label();
            this.lb_full_name = new System.Windows.Forms.Label();
            this.txtbox_mark = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_mark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_student_id
            // 
            this.lb_student_id.AutoSize = true;
            this.lb_student_id.Location = new System.Drawing.Point(29, 13);
            this.lb_student_id.Name = "lb_student_id";
            this.lb_student_id.Size = new System.Drawing.Size(97, 20);
            this.lb_student_id.TabIndex = 0;
            this.lb_student_id.Text = "ID: 2013537";
            // 
            // lb_full_name
            // 
            this.lb_full_name.AutoSize = true;
            this.lb_full_name.Location = new System.Drawing.Point(29, 58);
            this.lb_full_name.Name = "lb_full_name";
            this.lb_full_name.Size = new System.Drawing.Size(195, 20);
            this.lb_full_name.TabIndex = 0;
            this.lb_full_name.Text = "Ho Va Ten: Dinh Tien Khoi";
            // 
            // txtbox_mark
            // 
            this.txtbox_mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.txtbox_mark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_mark.ForeColor = System.Drawing.Color.White;
            this.txtbox_mark.Location = new System.Drawing.Point(33, 114);
            this.txtbox_mark.Name = "txtbox_mark";
            this.txtbox_mark.Size = new System.Drawing.Size(277, 23);
            this.txtbox_mark.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(33, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 1);
            this.panel1.TabIndex = 2;
            // 
            // btn_add_mark
            // 
            this.btn_add_mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_mark.Location = new System.Drawing.Point(350, 114);
            this.btn_add_mark.Name = "btn_add_mark";
            this.btn_add_mark.Size = new System.Drawing.Size(100, 37);
            this.btn_add_mark.TabIndex = 3;
            this.btn_add_mark.Text = "Thêm";
            this.btn_add_mark.UseVisualStyleBackColor = true;
            this.btn_add_mark.Click += new System.EventHandler(this.btn_add_mark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(171, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mẫu: 6.25; 6.0; 6.5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.close_icon;
            this.pictureBox1.Location = new System.Drawing.Point(410, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Add_Mark_To_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(473, 259);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_add_mark);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbox_mark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_full_name);
            this.Controls.Add(this.lb_student_id);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Mark_To_Student";
            this.Text = "Add_Mark_To_Student";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_student_id;
        private System.Windows.Forms.Label lb_full_name;
        private System.Windows.Forms.TextBox txtbox_mark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_mark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}