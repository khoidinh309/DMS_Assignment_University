namespace DMS_Assignment_University.MVP_Faculty.Views
{
    partial class Add_Subject_Form
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
            this.datagrid_unreleased_subject = new System.Windows.Forms.DataGridView();
            this.txtbox_search_info = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add_subject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_unreleased_subject)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_unreleased_subject
            // 
            this.datagrid_unreleased_subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_unreleased_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_unreleased_subject.Location = new System.Drawing.Point(13, 98);
            this.datagrid_unreleased_subject.Name = "datagrid_unreleased_subject";
            this.datagrid_unreleased_subject.RowHeadersWidth = 62;
            this.datagrid_unreleased_subject.RowTemplate.Height = 28;
            this.datagrid_unreleased_subject.Size = new System.Drawing.Size(610, 340);
            this.datagrid_unreleased_subject.TabIndex = 0;
            // 
            // txtbox_search_info
            // 
            this.txtbox_search_info.Location = new System.Drawing.Point(13, 37);
            this.txtbox_search_info.Name = "txtbox_search_info";
            this.txtbox_search_info.Size = new System.Drawing.Size(326, 26);
            this.txtbox_search_info.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(444, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 34);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add_subject
            // 
            this.btn_add_subject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_subject.Location = new System.Drawing.Point(671, 200);
            this.btn_add_subject.Name = "btn_add_subject";
            this.btn_add_subject.Size = new System.Drawing.Size(99, 34);
            this.btn_add_subject.TabIndex = 2;
            this.btn_add_subject.Text = "Thêm";
            this.btn_add_subject.UseVisualStyleBackColor = true;
            // 
            // Add_Subject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add_subject);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtbox_search_info);
            this.Controls.Add(this.datagrid_unreleased_subject);
            this.Name = "Add_Subject_Form";
            this.Text = "Add_Subject_Form";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_unreleased_subject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_unreleased_subject;
        private System.Windows.Forms.TextBox txtbox_search_info;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add_subject;
    }
}