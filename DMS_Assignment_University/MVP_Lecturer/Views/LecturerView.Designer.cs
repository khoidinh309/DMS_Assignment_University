namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    partial class LecturerView
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
            this.btn_view_Student = new System.Windows.Forms.Button();
            this.btn_add_textbook = new System.Windows.Forms.Button();
            this.btn_View_TextBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class_list)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_class_list
            // 
            this.datagrid_class_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_class_list.Location = new System.Drawing.Point(13, 22);
            this.datagrid_class_list.Name = "datagrid_class_list";
            this.datagrid_class_list.RowHeadersWidth = 62;
            this.datagrid_class_list.RowTemplate.Height = 28;
            this.datagrid_class_list.Size = new System.Drawing.Size(641, 416);
            this.datagrid_class_list.TabIndex = 0;
            // 
            // btn_view_Student
            // 
            this.btn_view_Student.Location = new System.Drawing.Point(684, 22);
            this.btn_view_Student.Name = "btn_view_Student";
            this.btn_view_Student.Size = new System.Drawing.Size(137, 38);
            this.btn_view_Student.TabIndex = 1;
            this.btn_view_Student.Text = "View";
            this.btn_view_Student.UseVisualStyleBackColor = true;
            // 
            // btn_add_textbook
            // 
            this.btn_add_textbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_textbook.Location = new System.Drawing.Point(684, 99);
            this.btn_add_textbook.Name = "btn_add_textbook";
            this.btn_add_textbook.Size = new System.Drawing.Size(137, 38);
            this.btn_add_textbook.TabIndex = 1;
            this.btn_add_textbook.Text = "Thêm TextBook";
            this.btn_add_textbook.UseVisualStyleBackColor = true;
            // 
            // btn_View_TextBook
            // 
            this.btn_View_TextBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_View_TextBook.Location = new System.Drawing.Point(684, 180);
            this.btn_View_TextBook.Name = "btn_View_TextBook";
            this.btn_View_TextBook.Size = new System.Drawing.Size(137, 38);
            this.btn_View_TextBook.TabIndex = 1;
            this.btn_View_TextBook.Text = "Xem TextBook";
            this.btn_View_TextBook.UseVisualStyleBackColor = true;
            // 
            // LecturerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.btn_View_TextBook);
            this.Controls.Add(this.btn_add_textbook);
            this.Controls.Add(this.btn_view_Student);
            this.Controls.Add(this.datagrid_class_list);
            this.Name = "LecturerView";
            this.Text = "LecturerView";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_class_list;
        private System.Windows.Forms.Button btn_view_Student;
        private System.Windows.Forms.Button btn_add_textbook;
        private System.Windows.Forms.Button btn_View_TextBook;
    }
}