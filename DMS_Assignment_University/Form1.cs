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

        }

        private void btn_log_faculty_Click(object sender, EventArgs e)
        {

        }
    }
}
