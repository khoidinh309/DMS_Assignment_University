using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    public partial class LecturerMainView : Form
    {
        public LecturerMainView(string lecturer_name, string fac_name)
        {
            InitializeComponent();
            txtbox_lecturer_name.Text = lecturer_name;
            txtbox_fac_name.Text = fac_name;
        }

        public static LecturerMainView global_view;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.instance.Show();
            this.Close();
        }
    }
}
