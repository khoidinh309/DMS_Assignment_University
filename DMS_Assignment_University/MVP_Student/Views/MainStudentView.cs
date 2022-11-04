using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Student.Views
{
    public partial class MainStudentView : Form
    {
        public MainStudentView(string student_name, string fac_name)
        {
            InitializeComponent();
            txtbox_name.Text = student_name;
            txtbox_faculty_name.Text = fac_name;
        }
        public static MainStudentView global_view;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1.instance.Show();
            this.Close();
        }
    }
}
