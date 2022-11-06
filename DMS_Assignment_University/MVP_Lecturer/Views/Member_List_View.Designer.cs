namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    partial class Member_List_View
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
            this.datagrid_student_list = new System.Windows.Forms.DataGridView();
            this.lb_number_member = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_student_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_student_list
            // 
            this.datagrid_student_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_student_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_student_list.Location = new System.Drawing.Point(-1, 2);
            this.datagrid_student_list.Name = "datagrid_student_list";
            this.datagrid_student_list.RowHeadersWidth = 62;
            this.datagrid_student_list.Size = new System.Drawing.Size(647, 384);
            this.datagrid_student_list.TabIndex = 0;
            // 
            // lb_number_member
            // 
            this.lb_number_member.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_number_member.AutoSize = true;
            this.lb_number_member.Location = new System.Drawing.Point(30, 402);
            this.lb_number_member.Name = "lb_number_member";
            this.lb_number_member.Size = new System.Drawing.Size(51, 20);
            this.lb_number_member.TabIndex = 2;
            this.lb_number_member.Text = "Sĩ Số:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.power_off;
            this.pictureBox1.Location = new System.Drawing.Point(710, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Member_List_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_number_member);
            this.Controls.Add(this.datagrid_student_list);
            this.Name = "Member_List_View";
            this.Text = "Member_List_View";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_student_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_student_list;
        private System.Windows.Forms.Label lb_number_member;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}