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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_view_Student = new System.Windows.Forms.Button();
            this.btn_add_textbook = new System.Windows.Forms.Button();
            this.btn_View_TextBook = new System.Windows.Forms.Button();
            this.datagrid_class_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class_list)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_view_Student
            // 
            this.btn_view_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_view_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_Student.Location = new System.Drawing.Point(664, 122);
            this.btn_view_Student.Name = "btn_view_Student";
            this.btn_view_Student.Size = new System.Drawing.Size(137, 38);
            this.btn_view_Student.TabIndex = 1;
            this.btn_view_Student.Text = "View";
            this.btn_view_Student.UseVisualStyleBackColor = true;
            // 
            // btn_add_textbook
            // 
            this.btn_add_textbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_textbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_textbook.Location = new System.Drawing.Point(664, 197);
            this.btn_add_textbook.Name = "btn_add_textbook";
            this.btn_add_textbook.Size = new System.Drawing.Size(137, 38);
            this.btn_add_textbook.TabIndex = 1;
            this.btn_add_textbook.Text = "Thêm TextBook";
            this.btn_add_textbook.UseVisualStyleBackColor = true;
            // 
            // btn_View_TextBook
            // 
            this.btn_View_TextBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_View_TextBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_TextBook.Location = new System.Drawing.Point(664, 279);
            this.btn_View_TextBook.Name = "btn_View_TextBook";
            this.btn_View_TextBook.Size = new System.Drawing.Size(137, 38);
            this.btn_View_TextBook.TabIndex = 1;
            this.btn_View_TextBook.Text = "Xem TextBook";
            this.btn_View_TextBook.UseVisualStyleBackColor = true;
            // 
            // datagrid_class_list
            // 
            this.datagrid_class_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_class_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_class_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_class_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_class_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_class_list.EnableHeadersVisualStyles = false;
            this.datagrid_class_list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.datagrid_class_list.Location = new System.Drawing.Point(0, 0);
            this.datagrid_class_list.MultiSelect = false;
            this.datagrid_class_list.Name = "datagrid_class_list";
            this.datagrid_class_list.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_class_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_class_list.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.datagrid_class_list.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_class_list.RowTemplate.Height = 28;
            this.datagrid_class_list.Size = new System.Drawing.Size(621, 450);
            this.datagrid_class_list.TabIndex = 7;
            // 
            // LecturerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.datagrid_class_list);
            this.Controls.Add(this.btn_View_TextBook);
            this.Controls.Add(this.btn_add_textbook);
            this.Controls.Add(this.btn_view_Student);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "LecturerView";
            this.Text = "LecturerView";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_view_Student;
        private System.Windows.Forms.Button btn_add_textbook;
        private System.Windows.Forms.Button btn_View_TextBook;
        private System.Windows.Forms.DataGridView datagrid_class_list;
    }
}