namespace DMS_Assignment_University.MVP_Faculty.Views
{
    partial class ClassView
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
            this.datagrid_class_list = new System.Windows.Forms.DataGridView();
            this.btn_add_new_class = new System.Windows.Forms.Button();
            this.btn_view_number_member = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_class_list
            // 
            this.datagrid_class_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_class_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.datagrid_class_list.Location = new System.Drawing.Point(0, 0);
            this.datagrid_class_list.Name = "datagrid_class_list";
            this.datagrid_class_list.RowHeadersWidth = 62;
            this.datagrid_class_list.RowTemplate.Height = 28;
            this.datagrid_class_list.Size = new System.Drawing.Size(630, 450);
            this.datagrid_class_list.TabIndex = 0;
            // 
            // btn_add_new_class
            // 
            this.btn_add_new_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_new_class.Location = new System.Drawing.Point(670, 106);
            this.btn_add_new_class.Name = "btn_add_new_class";
            this.btn_add_new_class.Size = new System.Drawing.Size(90, 54);
            this.btn_add_new_class.TabIndex = 1;
            this.btn_add_new_class.Text = "Thêm Lớp";
            this.btn_add_new_class.UseVisualStyleBackColor = true;
            this.btn_add_new_class.Click += new System.EventHandler(this.btn_add_new_class_Click);
            // 
            // btn_view_number_member
            // 
            this.btn_view_number_member.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view_number_member.Location = new System.Drawing.Point(670, 204);
            this.btn_view_number_member.Name = "btn_view_number_member";
            this.btn_view_number_member.Size = new System.Drawing.Size(90, 54);
            this.btn_view_number_member.TabIndex = 1;
            this.btn_view_number_member.Text = "SL Sinh Viên";
            this.btn_view_number_member.UseVisualStyleBackColor = true;
            this.btn_view_number_member.Click += new System.EventHandler(this.btn_view_number_member_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(724, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ClassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_view_number_member);
            this.Controls.Add(this.btn_add_new_class);
            this.Controls.Add(this.datagrid_class_list);
            this.Name = "ClassView";
            this.Text = "ClassView";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_class_list;
        private System.Windows.Forms.Button btn_add_new_class;
        private System.Windows.Forms.Button btn_view_number_member;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}