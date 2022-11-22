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
    public partial class AddLecturerToClass : Form
    {
        private int lecturer_id;
        private BindingSource class_list_data;
        private IEnumerable<Class> class_list;
        IFacultyRepository facultyRepository;
        
        public AddLecturerToClass(IFacultyRepository facultyRepository, int lecturer_id)
        {
            InitializeComponent();
            class_list_data = new BindingSource();
            this.facultyRepository = facultyRepository;
            this.lecturer_id = lecturer_id;
            Load_Class_List();
        }

        private void Load_Class_List()
        {
            class_list = facultyRepository.Get_Not_Managed_Class();
            class_list_data.DataSource = class_list;
            datatgrid_class_list.DataSource = class_list_data;
            for (int i = 0; i < datatgrid_class_list.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    datatgrid_class_list.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0D324D");
                }
            }
            datatgrid_class_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datatgrid_class_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            datatgrid_class_list.AllowUserToOrderColumns = true;
            datatgrid_class_list.AllowUserToResizeColumns = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searching_subject = txtbox_searching_subject.Text;
            if(searching_subject == "")
            {
                Load_Class_List();
            }
            else
            {
                var searching_result = from c in class_list
                                       where c.Subject_id == searching_subject | c.Subject_name == searching_subject
                                       select c;
                class_list_data.DataSource = searching_result;
                datatgrid_class_list.DataSource = class_list_data;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_set_work_Click(object sender, EventArgs e)
        {
            var selected_class = class_list_data.Current as Class;
            if(selected_class != null)
            {
                try
                {
                    this.facultyRepository.Add_Lecturer_To_Class(selected_class.Class_name, selected_class.Subject_id, selected_class.Semester, this.lecturer_id);
                    MessageBox.Show("Them Thanh Cong");
                }
                catch
                {
                    MessageBox.Show("Loi He Thong!");
                }
            }
            else
            {
                MessageBox.Show("Vui Long Chon Lop!");
            }
        }
    }
}
