using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Faculty.Views
{
    public partial class FacultyMainView : Form
    {
        public FacultyMainView(int faculty_ID, string faculty_name)
        {
            InitializeComponent();
            this.txtbox_faculty_ID.Text = faculty_ID.ToString();
            this.txtbox_faculty_name.Text = faculty_name;
        }
        public static FacultyMainView global_view;
    }
}
