using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University;

namespace DMS_Assignment_University
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_log_student_Click(object sender, EventArgs e)
        {
            Log_Student log_Student = new Log_Student();
            log_Student.Show();
            this.Hide();
        }

        private void btn_log_lecturer_Click(object sender, EventArgs e)
        {
            Log_Lecturer log_lecturer = new Log_Lecturer();
            log_lecturer.Show();
            this.Hide();
        }

        private void btn_log_faculty_Click(object sender, EventArgs e)
        {
            Log_Faculty log_Faculty = new Log_Faculty();
            log_Faculty.Show();
            this.Hide();
        }

        public static Form1 instance = null;
        public static Form1 Get_instance_form1()
        {
            if (instance == null)
            {
                instance = new Form1();
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Aqua;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = ColorTranslator.FromHtml("#010615");
        }
    }
}
