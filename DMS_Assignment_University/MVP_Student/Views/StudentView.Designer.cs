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
            this.datagrid_list_sub = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_textbook_list = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lb_number_registered_subject = new System.Windows.Forms.Label();
            this.lb_number_credit_sum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_list_sub)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_list_sub
            // 
            this.datagrid_list_sub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_list_sub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_list_sub.Location = new System.Drawing.Point(26, 64);
            this.datagrid_list_sub.Name = "datagrid_list_sub";
            this.datagrid_list_sub.RowHeadersWidth = 62;
            this.datagrid_list_sub.RowTemplate.Height = 28;
            this.datagrid_list_sub.Size = new System.Drawing.Size(785, 307);
            this.datagrid_list_sub.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh Sách Các Môn Đã Đăng Ký";
            // 
            // btn_textbook_list
            // 
            this.btn_textbook_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_textbook_list.Location = new System.Drawing.Point(916, 259);
            this.btn_textbook_list.Name = "btn_textbook_list";
            this.btn_textbook_list.Size = new System.Drawing.Size(99, 41);
            this.btn_textbook_list.TabIndex = 3;
            this.btn_textbook_list.Text = "TextBook";
            this.btn_textbook_list.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.Location = new System.Drawing.Point(916, 64);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(99, 41);
            this.btn_register.TabIndex = 3;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(916, 156);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 41);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lb_number_registered_subject
            // 
            this.lb_number_registered_subject.AutoSize = true;
            this.lb_number_registered_subject.Location = new System.Drawing.Point(26, 399);
            this.lb_number_registered_subject.Name = "lb_number_registered_subject";
            this.lb_number_registered_subject.Size = new System.Drawing.Size(81, 20);
            this.lb_number_registered_subject.TabIndex = 5;
            this.lb_number_registered_subject.Text = "Số môn: 5";
            // 
            // lb_number_credit_sum
            // 
            this.lb_number_credit_sum.AutoSize = true;
            this.lb_number_credit_sum.Location = new System.Drawing.Point(200, 399);
            this.lb_number_credit_sum.Name = "lb_number_credit_sum";
            this.lb_number_credit_sum.Size = new System.Drawing.Size(100, 20);
            this.lb_number_credit_sum.TabIndex = 5;
            this.lb_number_credit_sum.Text = "Số tín chỉ: 12";
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.lb_number_credit_sum);
            this.Controls.Add(this.lb_number_registered_subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_textbook_list);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.datagrid_list_sub);
            this.Name = "StudentView";
            this.Text = "StudentView";
            this.Load += new System.EventHandler(this.StudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_list_sub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagrid_list_sub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_textbook_list;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lb_number_registered_subject;
        private System.Windows.Forms.Label lb_number_credit_sum;
    }
}