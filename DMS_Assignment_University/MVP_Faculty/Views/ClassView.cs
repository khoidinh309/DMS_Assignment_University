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
    public partial class ClassView : Form
    {
        private string subID;
        private IFacultyRepository facultyRepository;
        private BindingSource class_list_data;
        private IEnumerable<Class> class_list;

        public ClassView(string subID, IFacultyRepository facultyRepository)
        {
            InitializeComponent();
            class_list_data = new BindingSource();
            this.subID = subID;
            this.facultyRepository = facultyRepository;
            Load_Class_List();
        }

        private void Load_Class_List()
        {
            class_list = this.facultyRepository.Get_Class_List(subID);
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

        private void btn_add_new_class_Click(object sender, EventArgs e)
        {
            var selected_class = class_list_data.Current as Class;
            try
            {
                this.facultyRepository.Add_New_Class(selected_class.Subject_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi He Thong!");
            }
        }

        private void btn_view_number_member_Click(object sender, EventArgs e)
        {
            Class selected_class = class_list_data.Current as Class;
            int number_member = this.facultyRepository.Get_Number_Member(subID, selected_class.Class_name);
            MessageBox.Show("Lop co " + number_member.ToString()+ " sinh vien dang ky");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FacultyView.instance.MdiParent = FacultyMainView.global_view;
            FacultyView.instance.Show();
            this.Close();
        }
    }
}
