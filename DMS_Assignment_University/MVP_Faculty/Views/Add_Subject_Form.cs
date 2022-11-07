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
    public partial class Add_Subject_Form : Form
    {
        private IFacultyRepository _facultyRepository;
        private BindingSource unreleased_subject_list_data;
        private IEnumerable<Subject> unreleased_subject_list;
        public Add_Subject_Form(IFacultyRepository facultyRepository)
        {
            InitializeComponent();
            this._facultyRepository = facultyRepository;
            unreleased_subject_list_data = new BindingSource();
            Load_Unreleased_Subject_List();
            btn_add_subject.Click += Btn_add_subject_Click;
        }

        private void Btn_add_subject_Click(object sender, EventArgs e)
        {
            Subject selected_subject = unreleased_subject_list_data.Current as Subject;
            if (selected_subject != null)
            {
                this._facultyRepository.Add_New_Subject(selected_subject.Id);
            }
            else
            {
                MessageBox.Show("Vui Long Chon Mon Hoc!");
            }
        }

        private void Load_Unreleased_Subject_List()
        {
            unreleased_subject_list = _facultyRepository.Get_Unreleased_Subject_List();
            unreleased_subject_list_data.DataSource = unreleased_subject_list;
            datagrid_unreleased_subject.DataSource = unreleased_subject_list;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string subject_info = txtbox_search_info.Text;
            if (subject_info == "")
            {
                Load_Unreleased_Subject_List();
            }
            else
            {
                var list = unreleased_subject_list_data.List.OfType<Subject>();
                var query = from subject in list where (subject.Name == subject_info || subject.Id == subject_info) select subject;
                if (query.Count() > 0)
                {
                    unreleased_subject_list_data.DataSource= query;
                    datagrid_unreleased_subject.DataSource = unreleased_subject_list_data;
                }
                else
                {
                    MessageBox.Show("Mon Hoc Khong Ton Tai!");
                    Load_Unreleased_Subject_List();
                }
            }
        }
    }
}
