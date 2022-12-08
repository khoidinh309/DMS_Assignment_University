using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Lecturer.Models;

namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    public partial class Add_Mark_To_Student : Form
    {
        private string class_name;
        private string subID;
        private int student_ID;
        ILecturerRepository lecturerRepository;
        Member_List_View member_list_view;
        public Add_Mark_To_Student(string full_name_student, string class_name, string subID, int student_ID, Member_List_View _member_List_View, ILecturerRepository lecturerRepository)
        {
            InitializeComponent();
            lb_student_id.Text = "ID: "+ student_ID.ToString();
            lb_full_name.Text = "Ho Va Ten: " + full_name_student;
            this.class_name = class_name;
            this.subID = subID;
            this.student_ID = student_ID;
            this.member_list_view = _member_List_View;
            this.lecturerRepository = lecturerRepository;
        }

        private void btn_add_mark_Click(object sender, EventArgs e)
        {
            string mark = txtbox_mark.Text;
            try
            {
                float added_mark = float.Parse(mark, CultureInfo.InvariantCulture.NumberFormat);
                if(added_mark < 0 || added_mark > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng [0,10], Vui Lòng Nhập Lại!");
                    return;
                }
                try
                {
                    lecturerRepository.set_mark_to_student(this.class_name, this.subID, this.student_ID, added_mark);
                    MessageBox.Show("Them Thanh Cong");
                }
                catch
                {
                    MessageBox.Show("Loi He Thong");
                }
            }
            catch
            {
                MessageBox.Show("Vui Long Nhap Chuan Theo Mau!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            member_list_view.Load_Student_List();
        }
    }
}
