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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Giáo Trình";
            // 
            // txtbox_TextBook_Name
            // 
            this.txtbox_TextBook_Name.Location = new System.Drawing.Point(70, 189);
            this.txtbox_TextBook_Name.Name = "txtbox_TextBook_Name";
            this.txtbox_TextBook_Name.Size = new System.Drawing.Size(207, 26);
            this.txtbox_TextBook_Name.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(325, 291);
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
            this.lb_subject_id.Location = new System.Drawing.Point(66, 66);
            this.lb_subject_id.Name = "lb_subject_id";
            this.lb_subject_id.Size = new System.Drawing.Size(133, 20);
            this.lb_subject_id.TabIndex = 4;
            this.lb_subject_id.Text = "Mã Môn: CO2017";
            // 
            // lb_subject_name
            // 
            this.lb_subject_name.AutoSize = true;
            this.lb_subject_name.Location = new System.Drawing.Point(507, 66);
            this.lb_subject_name.Name = "lb_subject_name";
            this.lb_subject_name.Size = new System.Drawing.Size(176, 20);
            this.lb_subject_name.TabIndex = 4;
            this.lb_subject_name.Text = "Môn: Hệ Cơ Sở Dữ Liệu";
            // 
            // txtbox_specialization
            // 
            this.txtbox_specialization.Location = new System.Drawing.Point(511, 189);
            this.txtbox_specialization.Name = "txtbox_specialization";
            this.txtbox_specialization.Size = new System.Drawing.Size(253, 26);
            this.txtbox_specialization.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuyên Ngành";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(718, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddTextBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_subject_name);
            this.Controls.Add(this.lb_subject_id);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_TextBook_Name);
            this.Controls.Add(this.txtbox_specialization);
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
    }
}