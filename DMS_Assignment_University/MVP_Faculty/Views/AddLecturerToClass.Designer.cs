namespace DMS_Assignment_University.MVP_Faculty.Views
{
    partial class AddLecturerToClass
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
            this.datatgrid_class_list = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbox_searching_subject = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datatgrid_class_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datatgrid_class_list
            // 
            this.datatgrid_class_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatgrid_class_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.datatgrid_class_list.Location = new System.Drawing.Point(0, 0);
            this.datatgrid_class_list.Name = "datatgrid_class_list";
            this.datatgrid_class_list.RowHeadersWidth = 62;
            this.datatgrid_class_list.RowTemplate.Height = 28;
            this.datatgrid_class_list.Size = new System.Drawing.Size(549, 450);
            this.datatgrid_class_list.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(606, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtbox_searching_subject
            // 
            this.txtbox_searching_subject.Location = new System.Drawing.Point(567, 75);
            this.txtbox_searching_subject.Name = "txtbox_searching_subject";
            this.txtbox_searching_subject.Size = new System.Drawing.Size(221, 26);
            this.txtbox_searching_subject.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(606, 123);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(150, 41);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.close_icon;
            this.pictureBox1.Location = new System.Drawing.Point(742, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddLecturerToClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtbox_searching_subject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datatgrid_class_list);
            this.Name = "AddLecturerToClass";
            this.Text = "AddLecturerToClass";
            ((System.ComponentModel.ISupportInitialize)(this.datatgrid_class_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datatgrid_class_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbox_searching_subject;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}