using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Lecturer.Models;
using DMS_Assignment_University.MVP_Student.Models;

namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    public partial class Member_List_View : Form
    {
        BindingSource student_list;
        ILecturerRepository lecturerRepository;
        private string subID;
        private string class_name;
        private int number_member;
        public Member_List_View(ILecturerRepository lecturerRepository,string subID, string class_name)
        {
            this.lecturerRepository = lecturerRepository;
            this.subID = subID;
            this.class_name = class_name;
            InitializeComponent();
            Load_Student_List();
            lb_number_member.Text = $"Sĩ Số: {number_member}";
        }

        private void Load_Student_List()
        {
            student_list = new BindingSource();
            IEnumerable<StudentModel> student_list_data = this.lecturerRepository.get_student_list(subID, class_name);
            number_member = student_list_data.Count();
            student_list.DataSource = student_list_data;
            datagrid_student_list.DataSource = student_list;
        }

        static public Member_List_View instance;
        public static void Get_Instance_Member_List_View(ILecturerRepository lecturerRepository, Form main_view, string subID, string class_name)
        {
            if(instance == null)
            {
                instance = new Member_List_View(lecturerRepository, subID, class_name);
                instance.MdiParent = main_view;
                instance.Show();
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LecturerView.instance.MdiParent = LecturerMainView.global_view;
            LecturerView.instance.Show();
            Member_List_View.instance = null;
            this.Close();
        }
    }
}
