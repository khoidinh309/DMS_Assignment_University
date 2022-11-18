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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.datagrid_released_subject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_released_subject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_released_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_released_subject.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_released_subject.EnableHeadersVisualStyles = false;
            this.datagrid_released_subject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.datagrid_released_subject.Location = new System.Drawing.Point(13, 13);
            this.datagrid_released_subject.MultiSelect = false;
            this.datagrid_released_subject.Name = "datagrid_released_subject";
            this.datagrid_released_subject.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_released_subject.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_released_subject.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.datagrid_released_subject.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_released_subject.RowTemplate.Height = 28;
            this.datagrid_released_subject.Size = new System.Drawing.Size(879, 561);
            this.datagrid_released_subject.TabIndex = 0;
            // 
            // btn_add_new_subject
            // 
            this.btn_add_new_subject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_new_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new_subject.Location = new System.Drawing.Point(913, 30);
            this.btn_add_new_subject.Name = "btn_add_new_subject";
            this.btn_add_new_subject.Size = new System.Drawing.Size(135, 47);
            this.btn_add_new_subject.TabIndex = 1;
            this.btn_add_new_subject.Text = "Mở môn";
            this.btn_add_new_subject.UseVisualStyleBackColor = true;
            // 
            // btn_add_new_class
            // 
            this.btn_add_new_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_new_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new_class.Location = new System.Drawing.Point(913, 124);
            this.btn_add_new_class.Name = "btn_add_new_class";
            this.btn_add_new_class.Size = new System.Drawing.Size(135, 47);
            this.btn_add_new_class.TabIndex = 1;
            this.btn_add_new_class.Text = "Mở Lớp";
            this.btn_add_new_class.UseVisualStyleBackColor = true;
            // 
            // btn_lecturer_view
            // 
            this.btn_lecturer_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lecturer_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lecturer_view.Location = new System.Drawing.Point(913, 230);
            this.btn_lecturer_view.Name = "btn_lecturer_view";
            this.btn_lecturer_view.Size = new System.Drawing.Size(135, 47);
            this.btn_lecturer_view.TabIndex = 1;
            this.btn_lecturer_view.Text = "Giảng Viên";
            this.btn_lecturer_view.UseVisualStyleBackColor = true;
            // 
            // btn_view_textbook
            // 
            this.btn_view_textbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view_textbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_textbook.Location = new System.Drawing.Point(913, 328);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1094, 586);
            this.Controls.Add(this.btn_view_textbook);
            this.Controls.Add(this.btn_lecturer_view);
            this.Controls.Add(this.btn_add_new_class);
            this.Controls.Add(this.btn_add_new_subject);
            this.Controls.Add(this.datagrid_released_subject);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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