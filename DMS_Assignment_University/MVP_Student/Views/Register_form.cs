using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Student.Models;
using DMS_Assignment_University.MVP_Student.Repository;

namespace DMS_Assignment_University.MVP_Student.Views
{
    public partial class Register_form : Form
    {
        private IStudentRepository studentRepository;
        BindingSource class_list;
        public Register_form(IStudentRepository student_repository)
        {
            InitializeComponent();
            this.studentRepository = student_repository;
            Load_Released_Subject_List();
        }

        private void Load_Released_Subject_List()
        {
            class_list = new BindingSource();
            IEnumerable<Class> released_subject_list = studentRepository.Get_Released_Subject_List();
            class_list.DataSource = released_subject_list;
            datagrid_subject.DataSource = class_list;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StudentView.instance.MdiParent = MainStudentView.global_view;
            StudentView.instance.Show();
            instance_register_form = null;
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Class selected_class = class_list.Current as Class;
            if (studentRepository.check_registered_class(selected_class.Class_name, selected_class.Subject_id))
            {
                MessageBox.Show("Ban da dang ky lop o lan truoc do!");
                return;
            }
            if (selected_class.Current_number_member > 50)
            {
                MessageBox.Show("Lop hoc da du thanh vien, vui long chon lop khac");
            }
            else
            {
                if (selected_class != null)
                {
                    try
                    {
                        studentRepository.delete_registered_class(selected_class.Subject_id);
                        studentRepository.Register_Method(selected_class.Class_name, selected_class.Subject_id, selected_class.Semester);
                        MessageBox.Show("Them thanh cong");
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Loi he thong, vui long thu lai!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a class you want to join");
                }
            }
        }

        public static Register_form instance_register_form = null;
        public static void Get_instance_register_form(IStudentRepository student_repository, Form main_view)
        {
            if (instance_register_form == null || instance_register_form.IsDisposed)
            {
                instance_register_form = new Register_form(student_repository);
                instance_register_form.MdiParent = main_view;
                instance_register_form.Show();
                instance_register_form.FormBorderStyle = FormBorderStyle.None;
                instance_register_form.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance_register_form.WindowState == FormWindowState.Minimized)
                    instance_register_form.WindowState = FormWindowState.Normal;
                instance_register_form.BringToFront();
            }
        }
    }
}
