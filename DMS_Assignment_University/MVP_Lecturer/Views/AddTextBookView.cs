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

namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    public partial class AddTextBookView : Form
    {
        private string subID;
        private string subject_name;
        private ILecturerRepository lecturerRepository;
        private bool Is_Textbook_Existing;
        private Textbook existing_textbook;
        public AddTextBookView(ILecturerRepository lecturerRepository, string subID, string subject_name)
        {
            InitializeComponent();
            this.subID = subID;
            this.subject_name = subject_name;
            this.lb_subject_id.Text = "Mã Môn: " + subID;
            this.lb_subject_name.Text = subject_name;
            this.lecturerRepository = lecturerRepository;
            Is_Textbook_Existing = false;
            show_saved_textbook();
        }

        private void show_saved_textbook()
        {
            existing_textbook = lecturerRepository.Get_Existing_TextBook(this.subID);
            if(existing_textbook.Id != -1)
            {
                txtbox_TextBook_Name.Text = existing_textbook.Name;
                txtbox_specialization.Text = existing_textbook.Specialization;
                Is_Textbook_Existing = true;
            }
        }

        public static AddTextBookView instance;
        public static void Get_Add_Book_View_Instance(Form Parent_Form, string subID,string subject_name, ILecturerRepository lecturerRepository)
        {
            if(instance == null)
            {
                instance = new AddTextBookView(lecturerRepository,subID, subject_name);
                instance.MdiParent = Parent_Form;
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            string textbook_name = txtbox_TextBook_Name.Text;
            string specialization = txtbox_specialization.Text;
            if (specialization == "" | specialization == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                if (Is_Textbook_Existing == false)
                {
                    try
                    {
                        lecturerRepository.Add_New_TextBook(subID, textbook_name, specialization);
                        MessageBox.Show("Thêm Thành Công!");
                    }
                    catch
                    {
                        MessageBox.Show("Loi He Thong, Vui Long Thu Lai");
                    }
                }
                else
                {
                    try
                    {
                        lecturerRepository.Modify_TextBook(existing_textbook);
                        MessageBox.Show("Sửa Thành Công");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi Hệ Thống!");
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LecturerView.instance.MdiParent = LecturerMainView.global_view;
            LecturerView.instance.Show();
            Member_List_View.instance = null;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb_subject_name_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
