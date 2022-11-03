namespace DMS_Assignment_University.MVP_Student.Views
{
    partial class Textbook_View
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
            this.txtbox_name_subject = new System.Windows.Forms.TextBox();
            this.datagid_textbook = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagid_textbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_name_subject
            // 
            this.txtbox_name_subject.Location = new System.Drawing.Point(60, 31);
            this.txtbox_name_subject.Name = "txtbox_name_subject";
            this.txtbox_name_subject.Size = new System.Drawing.Size(294, 26);
            this.txtbox_name_subject.TabIndex = 0;
            // 
            // datagid_textbook
            // 
            this.datagid_textbook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagid_textbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagid_textbook.Location = new System.Drawing.Point(60, 100);
            this.datagid_textbook.Name = "datagid_textbook";
            this.datagid_textbook.RowHeadersWidth = 62;
            this.datagid_textbook.RowTemplate.Height = 28;
            this.datagid_textbook.Size = new System.Drawing.Size(534, 302);
            this.datagid_textbook.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(672, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Textbook_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datagid_textbook);
            this.Controls.Add(this.txtbox_name_subject);
            this.Name = "Textbook_View";
            this.Text = "Textbook_View";
            ((System.ComponentModel.ISupportInitialize)(this.datagid_textbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_name_subject;
        private System.Windows.Forms.DataGridView datagid_textbook;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}