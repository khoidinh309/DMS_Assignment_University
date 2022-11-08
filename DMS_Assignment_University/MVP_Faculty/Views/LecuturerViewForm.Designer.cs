namespace DMS_Assignment_University.MVP_Faculty.Views
{
    partial class LecuturerViewForm
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
            this.datagrid_lecturer_list = new System.Windows.Forms.DataGridView();
            this.btn_view_class_list = new System.Windows.Forms.Button();
            this.btn_add_lecturer_to_class = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_lecturer_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_lecturer_list
            // 
            this.datagrid_lecturer_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_lecturer_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.datagrid_lecturer_list.Location = new System.Drawing.Point(0, 0);
            this.datagrid_lecturer_list.Name = "datagrid_lecturer_list";
            this.datagrid_lecturer_list.RowHeadersWidth = 62;
            this.datagrid_lecturer_list.RowTemplate.Height = 28;
            this.datagrid_lecturer_list.Size = new System.Drawing.Size(596, 450);
            this.datagrid_lecturer_list.TabIndex = 0;
            // 
            // btn_view_class_list
            // 
            this.btn_view_class_list.Location = new System.Drawing.Point(657, 103);
            this.btn_view_class_list.Name = "btn_view_class_list";
            this.btn_view_class_list.Size = new System.Drawing.Size(103, 48);
            this.btn_view_class_list.TabIndex = 1;
            this.btn_view_class_list.Text = "Danh Sách Lớp";
            this.btn_view_class_list.UseVisualStyleBackColor = true;
            this.btn_view_class_list.Click += new System.EventHandler(this.btn_view_class_list_Click);
            // 
            // btn_add_lecturer_to_class
            // 
            this.btn_add_lecturer_to_class.Location = new System.Drawing.Point(657, 214);
            this.btn_add_lecturer_to_class.Name = "btn_add_lecturer_to_class";
            this.btn_add_lecturer_to_class.Size = new System.Drawing.Size(103, 48);
            this.btn_add_lecturer_to_class.TabIndex = 1;
            this.btn_add_lecturer_to_class.Text = "Phân Công";
            this.btn_add_lecturer_to_class.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DMS_Assignment_University.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(715, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LecuturerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_add_lecturer_to_class);
            this.Controls.Add(this.btn_view_class_list);
            this.Controls.Add(this.datagrid_lecturer_list);
            this.Name = "LecuturerViewForm";
            this.Text = "LecuturerViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_lecturer_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_lecturer_list;
        private System.Windows.Forms.Button btn_view_class_list;
        private System.Windows.Forms.Button btn_add_lecturer_to_class;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}