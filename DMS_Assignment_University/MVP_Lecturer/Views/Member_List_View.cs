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

        public void Load_Student_List()
        {
            student_list = new BindingSource();
            IEnumerable<StudentModel> student_list_data = this.lecturerRepository.get_student_list(subID, class_name);
            number_member = student_list_data.Count();
            student_list.DataSource = student_list_data;
            datagrid_student_list.DataSource = student_list;
            for (int i = 0; i < datagrid_student_list.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    datagrid_student_list.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0D324D");
                }
            }
            datagrid_student_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_student_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            datagrid_student_list.AllowUserToOrderColumns = true;
            datagrid_student_list.AllowUserToResizeColumns = true;
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

        private void btn_add_mark_Click(object sender, EventArgs e)
        {
            StudentModel selected_student = student_list.Current as StudentModel;
            Add_Mark_To_Student addMarkForm = new Add_Mark_To_Student(selected_student.Name,this.class_name, this.subID, selected_student.Id, this, this.lecturerRepository);
            addMarkForm.Show();
        }
    }
}
