namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    partial class AddTextBookView
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_TextBook_Name = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_subject_id = new System.Windows.Forms.Label();
            this.lb_subject_name = new System.Windows.Forms.Label();
            this.txtbox_specialization = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Giáo Trình";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbox_TextBook_Name
            // 
            this.txtbox_TextBook_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.txtbox_TextBook_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_TextBook_Name.ForeColor = System.Drawing.Color.White;
            this.txtbox_TextBook_Name.Location = new System.Drawing.Point(60, 136);
            this.txtbox_TextBook_Name.Name = "txtbox_TextBook_Name";
            this.txtbox_TextBook_Name.Size = new System.Drawing.Size(206, 19);
            this.txtbox_TextBook_Name.TabIndex = 0;
            this.txtbox_TextBook_Name.Tag = "0";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(262, 229);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 46);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_subject_id
            // 
            this.lb_subject_id.AutoSize = true;
            this.lb_subject_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subject_id.Location = new System.Drawing.Point(55, 34);
            this.lb_subject_id.Name = "lb_subject_id";
            this.lb_subject_id.Size = new System.Drawing.Size(170, 25);
            this.lb_subject_id.TabIndex = 4;
            this.lb_subject_id.Text = "Mã Môn: CO2017";
            // 
            // lb_subject_name
            // 
            this.lb_subject_name.AutoSize = true;
            this.lb_subject_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subject_name.Location = new System.Drawing.Point(410, 34);
            this.lb_subject_name.Name = "lb_subject_name";
            this.lb_subject_name.Size = new System.Drawing.Size(220, 25);
            this.lb_subject_name.TabIndex = 4;
            this.lb_subject_name.Text = "Môn: Hệ Cơ Sở Dữ Liệu";
            this.lb_subject_name.Click += new System.EventHandler(this.lb_subject_name_Click);
            // 
            // txtbox_specialization
            // 
            this.txtbox_specialization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_specialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.txtbox_specialization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_specialization.ForeColor = System.Drawing.Color.White;
            this.txtbox_specialization.Location = new System.Drawing.Point(415, 136);
            this.txtbox_specialization.Name = "txtbox_specialization";
            this.txtbox_specialization.Size = new System.Drawing.Size(233, 19);
            this.txtbox_specialization.TabIndex = 0;
            this.txtbox_specialization.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuyên Ngành";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(683, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(60, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(418, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 1);
            this.panel2.TabIndex = 7;
            // 
            // AddTextBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(766, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_subject_name);
            this.Controls.Add(this.lb_subject_id);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_TextBook_Name);
            this.Controls.Add(this.txtbox_specialization);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddTextBookView";
            this.Text = "AddTextBookView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_TextBook_Name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_subject_id;
        private System.Windows.Forms.Label lb_subject_name;
        private System.Windows.Forms.TextBox txtbox_specialization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}