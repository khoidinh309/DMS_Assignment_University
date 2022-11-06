namespace DMS_Assignment_University
{
    partial class Log_Lecturer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_lecturer_id = new System.Windows.Forms.TextBox();
            this.btn_log_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Số Giảng Viên";
            // 
            // txtbox_lecturer_id
            // 
            this.txtbox_lecturer_id.Location = new System.Drawing.Point(170, 162);
            this.txtbox_lecturer_id.Name = "txtbox_lecturer_id";
            this.txtbox_lecturer_id.Size = new System.Drawing.Size(330, 26);
            this.txtbox_lecturer_id.TabIndex = 1;
            // 
            // btn_log_in
            // 
            this.btn_log_in.Location = new System.Drawing.Point(593, 155);
            this.btn_log_in.Name = "btn_log_in";
            this.btn_log_in.Size = new System.Drawing.Size(92, 41);
            this.btn_log_in.TabIndex = 2;
            this.btn_log_in.Text = "Log in";
            this.btn_log_in.UseVisualStyleBackColor = true;
            this.btn_log_in.Click += new System.EventHandler(this.btn_log_in_Click);
            // 
            // Log_Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_log_in);
            this.Controls.Add(this.txtbox_lecturer_id);
            this.Controls.Add(this.label1);
            this.Name = "Log_Lecturer";
            this.Text = "Log_Lecturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_lecturer_id;
        private System.Windows.Forms.Button btn_log_in;
    }
}