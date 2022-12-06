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
    public partial class ClassListViewByLecturer : Form
    {
        BindingSource class_list_data;
        IEnumerable<Class> class_list;
        private int lecturer_ID;
        IFacultyRepository facultyRepository;
        public ClassListViewByLecturer(int lecturer_ID, string lecturer_Name, IFacultyRepository facultyRepository)
        {
            InitializeComponent();
            class_list_data = new BindingSource();
            this.lecturer_ID = lecturer_ID;
            this.lb_lecturer_ID.Text = "ID :" + lecturer_ID.ToString();
            this.lb_Lecturer_Name.Text = lecturer_Name;
            this.facultyRepository = facultyRepository;
            Load_Class_List();
        }

        private void Load_Class_List()
        {
            class_list = facultyRepository.Get_Teaching_Class_List(lecturer_ID);
            class_list_data.DataSource = class_list;
            datagrid_class_list.DataSource = class_list_data;
            for (int i = 0; i < datagrid_class_list.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    datagrid_class_list.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0D324D");
                }
            }
            datagrid_class_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_class_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            datagrid_class_list.AllowUserToOrderColumns = true;
            datagrid_class_list.AllowUserToResizeColumns = true;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Class selected_Class = class_list_data.Current as Class;
            MessageBox.Show(selected_Class.Class_name);
            try
            {
                this.facultyRepository.Remove_Lecturer_From_Class(selected_Class.Class_name, selected_Class.Subject_id, lecturer_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void datagrid_class_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
