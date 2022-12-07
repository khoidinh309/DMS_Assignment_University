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
using DMS_Assignment_University.MVP_Faculty.Presenter;

namespace DMS_Assignment_University.MVP_Faculty.Views
{
    public partial class Add_Subject_Form : Form
    {
        private IFacultyRepository _facultyRepository;
        private BindingSource unreleased_subject_list_data;
        private IEnumerable<Subject> unreleased_subject_list;
        private FacultyPresenter faculty_presenter;
        public Add_Subject_Form(IFacultyRepository facultyRepository, FacultyPresenter facultyPresenter)
        {
            InitializeComponent();
            this._facultyRepository = facultyRepository;
            unreleased_subject_list_data = new BindingSource();
            Load_Unreleased_Subject_List();
            btn_add_subject.Click += Btn_add_subject_Click;
            this.faculty_presenter = facultyPresenter;
            lb_error.Visible = false;
            lb_error_1.Visible = false;
            lb_error_2.Visible = false;
        }

        private void Btn_add_subject_Click(object sender, EventArgs e)
        {
            Subject selected_subject = unreleased_subject_list_data.Current as Subject;
            if (selected_subject != null)
            {
                this._facultyRepository.Add_New_Subject(selected_subject.Id);
                MessageBox.Show("Thêm Thành Công");
                Load_Unreleased_Subject_List();
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
            for (int i = 0; i < datagrid_unreleased_subject.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    datagrid_unreleased_subject.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0D324D");
                }
            }
            datagrid_unreleased_subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_unreleased_subject.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            datagrid_unreleased_subject.AllowUserToOrderColumns = true;
            datagrid_unreleased_subject.AllowUserToResizeColumns = true;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FacultyView.instance.MdiParent = FacultyMainView.global_view;
            FacultyView.instance.Show();
            faculty_presenter.Load_Released_Subject_List();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subID = txtbox_subject_ID.Text;
            string subName = txtbox_subject_name.Text;
            string numCredit = txtbox_num_credit.Text;
            int num_credit = 0;
            try
            {
                num_credit = Convert.ToInt32(numCredit);
            }
            catch
            {
                MessageBox.Show("Tín Chỉ Phải Là Số Tự Nhiên");
            }
            if(subID.Length != 6) { lb_error.Visible = true; return; }
            if(num_credit <= 0 || num_credit > 4) { lb_error_2.Visible = true; return;}
            try
            {
                _facultyRepository.AddNewSubject(subID, subName, num_credit);
                Load_Unreleased_Subject_List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
