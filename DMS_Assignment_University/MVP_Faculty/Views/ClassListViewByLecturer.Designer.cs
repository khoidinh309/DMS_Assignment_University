namespace DMS_Assignment_University.MVP_Faculty.Views
{
    partial class ClassListViewByLecturer
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
            this.btn_remove = new System.Windows.Forms.Button();
            this.lb_Lecturer_Name = new System.Windows.Forms.Label();
            this.lb_lecturer_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class_list)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_class_list
            // 
            this.datagrid_class_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.datagrid_class_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_class_list.Location = new System.Drawing.Point(13, 101);
            this.datagrid_class_list.Name = "datagrid_class_list";
            this.datagrid_class_list.RowHeadersWidth = 62;
            this.datagrid_class_list.RowTemplate.Height = 28;
            this.datagrid_class_list.Size = new System.Drawing.Size(611, 349);
            this.datagrid_class_list.TabIndex = 0;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_remove.Location = new System.Drawing.Point(641, 158);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(119, 50);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Xóa Khỏi Lớp";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lb_Lecturer_Name
            // 
            this.lb_Lecturer_Name.AutoSize = true;
            this.lb_Lecturer_Name.Location = new System.Drawing.Point(33, 46);
            this.lb_Lecturer_Name.Name = "lb_Lecturer_Name";
            this.lb_Lecturer_Name.Size = new System.Drawing.Size(126, 20);
            this.lb_Lecturer_Name.TabIndex = 2;
            this.lb_Lecturer_Name.Text = "Trần Thanh Bình";
            // 
            // lb_lecturer_ID
            // 
            this.lb_lecturer_ID.AutoSize = true;
            this.lb_lecturer_ID.Location = new System.Drawing.Point(52, 9);
            this.lb_lecturer_ID.Name = "lb_lecturer_ID";
            this.lb_lecturer_ID.Size = new System.Drawing.Size(70, 20);
            this.lb_lecturer_ID.TabIndex = 2;
            this.lb_lecturer_ID.Text = "ID: 1000";
            // 
            // ClassListViewByLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_lecturer_ID);
            this.Controls.Add(this.lb_Lecturer_Name);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.datagrid_class_list);
            this.Name = "ClassListViewByLecturer";
            this.Text = "ClassListViewByLecturer";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_class_list;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lb_Lecturer_Name;
        private System.Windows.Forms.Label lb_lecturer_ID;
    }
}