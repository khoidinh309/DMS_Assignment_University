namespace DMS_Assignment_University.MVP_Student.Views
{
    partial class Register_form
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
            this.datagrid_subject = new System.Windows.Forms.DataGridView();
            this.btn_register = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_search_subject = new System.Windows.Forms.TextBox();
            this.btn_search_subject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_subject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_subject
            // 
            this.datagrid_subject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_subject.Location = new System.Drawing.Point(0, 90);
            this.datagrid_subject.Name = "datagrid_subject";
            this.datagrid_subject.RowHeadersWidth = 62;
            this.datagrid_subject.RowTemplate.Height = 28;
            this.datagrid_subject.Size = new System.Drawing.Size(671, 360);
            this.datagrid_subject.TabIndex = 0;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.Location = new System.Drawing.Point(697, 112);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(107, 37);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Đăng Ký";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(726, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtbox_search_subject
            // 
            this.txtbox_search_subject.Location = new System.Drawing.Point(22, 23);
            this.txtbox_search_subject.Name = "txtbox_search_subject";
            this.txtbox_search_subject.Size = new System.Drawing.Size(366, 26);
            this.txtbox_search_subject.TabIndex = 3;
            // 
            // btn_search_subject
            // 
            this.btn_search_subject.Location = new System.Drawing.Point(448, 19);
            this.btn_search_subject.Name = "btn_search_subject";
            this.btn_search_subject.Size = new System.Drawing.Size(94, 35);
            this.btn_search_subject.TabIndex = 4;
            this.btn_search_subject.Text = "Tìm Kiếm";
            this.btn_search_subject.UseVisualStyleBackColor = true;
            this.btn_search_subject.Click += new System.EventHandler(this.btn_search_subject_Click);
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.btn_search_subject);
            this.Controls.Add(this.txtbox_search_subject);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.datagrid_subject);
            this.Name = "Register_form";
            this.Text = "Register_form";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_subject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_subject;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox_search_subject;
        private System.Windows.Forms.Button btn_search_subject;
    }
}