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
            this.datagid_textbook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagid_textbook)).BeginInit();
            this.SuspendLayout();
            // 
            // datagid_textbook
            // 
            this.datagid_textbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagid_textbook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagid_textbook.Location = new System.Drawing.Point(0, 0);
            this.datagid_textbook.Name = "datagid_textbook";
            this.datagid_textbook.RowHeadersWidth = 62;
            this.datagid_textbook.RowTemplate.Height = 28;
            this.datagid_textbook.Size = new System.Drawing.Size(699, 411);
            this.datagid_textbook.TabIndex = 1;
            // 
            // Textbook_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 411);
            this.Controls.Add(this.datagid_textbook);
            this.Name = "Textbook_View";
            this.Text = "Textbook_View";
            ((System.ComponentModel.ISupportInitialize)(this.datagid_textbook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView datagid_textbook;
    }
}