namespace DMS_Assignment_University.MVP_Faculty.Views
{
    partial class TextBookView
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
            this.lb_subject_ID = new System.Windows.Forms.Label();
            this.lb_subject_name = new System.Windows.Forms.Label();
            this.datagrid_textbook_list = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_textbook_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_subject_ID
            // 
            this.lb_subject_ID.AutoSize = true;
            this.lb_subject_ID.Location = new System.Drawing.Point(52, 31);
            this.lb_subject_ID.Name = "lb_subject_ID";
            this.lb_subject_ID.Size = new System.Drawing.Size(133, 20);
            this.lb_subject_ID.TabIndex = 0;
            this.lb_subject_ID.Text = "Mã môn: CO2014";
            // 
            // lb_subject_name
            // 
            this.lb_subject_name.AutoSize = true;
            this.lb_subject_name.Location = new System.Drawing.Point(52, 65);
            this.lb_subject_name.Name = "lb_subject_name";
            this.lb_subject_name.Size = new System.Drawing.Size(137, 20);
            this.lb_subject_name.TabIndex = 0;
            this.lb_subject_name.Text = "Hệ Cơ Sở Dữ Liệu";
            // 
            // datagrid_textbook_list
            // 
            this.datagrid_textbook_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_textbook_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_textbook_list.Location = new System.Drawing.Point(3, 115);
            this.datagrid_textbook_list.Name = "datagrid_textbook_list";
            this.datagrid_textbook_list.RowHeadersWidth = 62;
            this.datagrid_textbook_list.RowTemplate.Height = 28;
            this.datagrid_textbook_list.Size = new System.Drawing.Size(634, 331);
            this.datagrid_textbook_list.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(708, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TextBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datagrid_textbook_list);
            this.Controls.Add(this.lb_subject_name);
            this.Controls.Add(this.lb_subject_ID);
            this.Name = "TextBookView";
            this.Text = "TextBookView";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_textbook_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_subject_ID;
        private System.Windows.Forms.Label lb_subject_name;
        private System.Windows.Forms.DataGridView datagrid_textbook_list;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}