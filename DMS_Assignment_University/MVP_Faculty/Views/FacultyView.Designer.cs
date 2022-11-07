namespace DMS_Assignment_University.MVP_Faculty.Views
{
    partial class FacultyView
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
            this.datagrid_released_subject = new System.Windows.Forms.DataGridView();
            this.btn_add_new_subject = new System.Windows.Forms.Button();
            this.btn_add_new_class = new System.Windows.Forms.Button();
            this.btn_lecturer_view = new System.Windows.Forms.Button();
            this.btn_view_textbook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_released_subject)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_released_subject
            // 
            this.datagrid_released_subject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_released_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_released_subject.Location = new System.Drawing.Point(13, 13);
            this.datagrid_released_subject.Name = "datagrid_released_subject";
            this.datagrid_released_subject.RowHeadersWidth = 62;
            this.datagrid_released_subject.RowTemplate.Height = 28;
            this.datagrid_released_subject.Size = new System.Drawing.Size(537, 425);
            this.datagrid_released_subject.TabIndex = 0;
            // 
            // btn_add_new_subject
            // 
            this.btn_add_new_subject.Location = new System.Drawing.Point(619, 13);
            this.btn_add_new_subject.Name = "btn_add_new_subject";
            this.btn_add_new_subject.Size = new System.Drawing.Size(135, 47);
            this.btn_add_new_subject.TabIndex = 1;
            this.btn_add_new_subject.Text = "Mở môn";
            this.btn_add_new_subject.UseVisualStyleBackColor = true;
            // 
            // btn_add_new_class
            // 
            this.btn_add_new_class.Location = new System.Drawing.Point(619, 111);
            this.btn_add_new_class.Name = "btn_add_new_class";
            this.btn_add_new_class.Size = new System.Drawing.Size(135, 47);
            this.btn_add_new_class.TabIndex = 1;
            this.btn_add_new_class.Text = "Mở Lớp";
            this.btn_add_new_class.UseVisualStyleBackColor = true;
            // 
            // btn_lecturer_view
            // 
            this.btn_lecturer_view.Location = new System.Drawing.Point(619, 212);
            this.btn_lecturer_view.Name = "btn_lecturer_view";
            this.btn_lecturer_view.Size = new System.Drawing.Size(135, 47);
            this.btn_lecturer_view.TabIndex = 1;
            this.btn_lecturer_view.Text = "Giảng Viên";
            this.btn_lecturer_view.UseVisualStyleBackColor = true;
            // 
            // btn_view_textbook
            // 
            this.btn_view_textbook.Location = new System.Drawing.Point(619, 310);
            this.btn_view_textbook.Name = "btn_view_textbook";
            this.btn_view_textbook.Size = new System.Drawing.Size(135, 47);
            this.btn_view_textbook.TabIndex = 1;
            this.btn_view_textbook.Text = "Giáo Trình";
            this.btn_view_textbook.UseVisualStyleBackColor = true;
            // 
            // FacultyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_view_textbook);
            this.Controls.Add(this.btn_lecturer_view);
            this.Controls.Add(this.btn_add_new_class);
            this.Controls.Add(this.btn_add_new_subject);
            this.Controls.Add(this.datagrid_released_subject);
            this.Name = "FacultyView";
            this.Text = "FacultyView";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_released_subject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_released_subject;
        private System.Windows.Forms.Button btn_add_new_subject;
        private System.Windows.Forms.Button btn_add_new_class;
        private System.Windows.Forms.Button btn_lecturer_view;
        private System.Windows.Forms.Button btn_view_textbook;
    }
}