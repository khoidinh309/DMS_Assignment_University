using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Faculty.Models;

namespace DMS_Assignment_University.MVP_Faculty.Views
{
    public partial class LecuturerViewForm : Form
    {
        BindingSource lecturer_list_data;
        IEnumerable<LecturerModel> lecturer_list;
        IFacultyRepository facultyRepository;
        
        public LecuturerViewForm(IFacultyRepository facultyRepository)
        {
            InitializeComponent();
            this.facultyRepository = facultyRepository;
            lecturer_list_data = new BindingSource();
            Load_Lecturer_List();
        }

        private void Load_Lecturer_List()
        {
            lecturer_list = this.facultyRepository.Get_Lecturer_List();
            lecturer_list_data.DataSource = lecturer_list;
            datagrid_lecturer_list.DataSource = lecturer_list_data;
            for (int i = 0; i < datagrid_lecturer_list.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    datagrid_lecturer_list.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0D324D");
                }
            }
            datagrid_lecturer_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_lecturer_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            datagrid_lecturer_list.AllowUserToOrderColumns = true;
            datagrid_lecturer_list.AllowUserToResizeColumns = true;
        }

        private void btn_view_class_list_Click(object sender, EventArgs e)
        {
            LecturerModel selected_lecturer = lecturer_list_data.Current as LecturerModel;
            if(selected_lecturer != null)
            {
                ClassListViewByLecturer classListViewByLecturer = new ClassListViewByLecturer(selected_lecturer.Lecturer_ID, selected_lecturer.Lecturer_Name, facultyRepository);
                classListViewByLecturer.Show();
            }
            else
            {
                MessageBox.Show("Vui long chon lop");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FacultyView.instance.MdiParent = FacultyMainView.global_view;
            FacultyView.instance.Show();
            this.Close();
        }

        private void btn_add_lecturer_to_class_Click(object sender, EventArgs e)
        {

        }
    }
}
