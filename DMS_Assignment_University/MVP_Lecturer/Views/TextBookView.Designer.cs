namespace DMS_Assignment_University.MVP_Lecturer.Views
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
            this.datagrid_textbook_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_textbook_list)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_textbook_list
            // 
            this.datagrid_textbook_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_textbook_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_textbook_list.Location = new System.Drawing.Point(0, 0);
            this.datagrid_textbook_list.Name = "datagrid_textbook_list";
            this.datagrid_textbook_list.RowHeadersWidth = 62;
            this.datagrid_textbook_list.RowTemplate.Height = 28;
            this.datagrid_textbook_list.Size = new System.Drawing.Size(800, 450);
            this.datagrid_textbook_list.TabIndex = 0;
            // 
            // TextBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagrid_textbook_list);
            this.Name = "TextBookView";
            this.Text = "TextBookView";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_textbook_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_textbook_list;
    }
}