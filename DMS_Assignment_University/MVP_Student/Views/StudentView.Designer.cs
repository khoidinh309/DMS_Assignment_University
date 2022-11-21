namespace DMS_Assignment_University.MVP_Student.Views
{
    partial class StudentView
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_textbook_list = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lb_number_registered_subject = new System.Windows.Forms.Label();
            this.lb_number_credit_sum = new System.Windows.Forms.Label();
            this.datagrid_list_sub = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_list_sub)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh Sách Các Môn Đã Đăng Ký";
            // 
            // btn_textbook_list
            // 
            this.btn_textbook_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_textbook_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_textbook_list.Location = new System.Drawing.Point(991, 404);
            this.btn_textbook_list.Name = "btn_textbook_list";
            this.btn_textbook_list.Size = new System.Drawing.Size(99, 41);
            this.btn_textbook_list.TabIndex = 3;
            this.btn_textbook_list.Text = "TextBook";
            this.btn_textbook_list.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Location = new System.Drawing.Point(991, 167);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(99, 41);
            this.btn_register.TabIndex = 3;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(991, 279);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 41);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lb_number_registered_subject
            // 
            this.lb_number_registered_subject.AutoSize = true;
            this.lb_number_registered_subject.Location = new System.Drawing.Point(22, 525);
            this.lb_number_registered_subject.Name = "lb_number_registered_subject";
            this.lb_number_registered_subject.Size = new System.Drawing.Size(81, 20);
            this.lb_number_registered_subject.TabIndex = 5;
            this.lb_number_registered_subject.Text = "Số môn: 5";
            // 
            // lb_number_credit_sum
            // 
            this.lb_number_credit_sum.AutoSize = true;
            this.lb_number_credit_sum.Location = new System.Drawing.Point(167, 525);
            this.lb_number_credit_sum.Name = "lb_number_credit_sum";
            this.lb_number_credit_sum.Size = new System.Drawing.Size(100, 20);
            this.lb_number_credit_sum.TabIndex = 5;
            this.lb_number_credit_sum.Text = "Số tín chỉ: 12";
            // 
            // datagrid_list_sub
            // 
            this.datagrid_list_sub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_list_sub.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_list_sub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_list_sub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_list_sub.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_list_sub.EnableHeadersVisualStyles = false;
            this.datagrid_list_sub.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.datagrid_list_sub.Location = new System.Drawing.Point(26, 66);
            this.datagrid_list_sub.MultiSelect = false;
            this.datagrid_list_sub.Name = "datagrid_list_sub";
            this.datagrid_list_sub.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_list_sub.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_list_sub.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.datagrid_list_sub.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_list_sub.RowTemplate.Height = 28;
            this.datagrid_list_sub.Size = new System.Drawing.Size(937, 414);
            this.datagrid_list_sub.TabIndex = 6;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1148, 570);
            this.Controls.Add(this.datagrid_list_sub);
            this.Controls.Add(this.lb_number_credit_sum);
            this.Controls.Add(this.lb_number_registered_subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_textbook_list);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentView";
            this.Text = "StudentView";
            this.Load += new System.EventHandler(this.StudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_list_sub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_textbook_list;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lb_number_registered_subject;
        private System.Windows.Forms.Label lb_number_credit_sum;
        private System.Windows.Forms.DataGridView datagrid_list_sub;
    }
}