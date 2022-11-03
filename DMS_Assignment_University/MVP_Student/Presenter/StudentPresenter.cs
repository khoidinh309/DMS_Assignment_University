using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Student.Models;
using DMS_Assignment_University.MVP_Student.Views;
using DMS_Assignment_University;
using System.Threading;

namespace DMS_Assignment_University.MVP_Student.Presenter
{
    public class StudentPresenter
    {
        private IStudentView studentView;
        private IStudentRepository studentRepository;
        private BindingSource _bindingsource_subject;
        private IEnumerable<Class> _subject_list;
        MainStudentView main_view;

        public StudentPresenter(IStudentView view, IStudentRepository repository, MainStudentView main_view)
        {
            this._bindingsource_subject = new BindingSource();
            this.studentView = view;
            this.studentRepository = repository;
            this.studentView.Register_Method_Event += Register_Method;
            this.studentView.View_textbook_Event += View_Textbook;
            this.studentView.Cancel_Class_Event += Cancel_Class_Method;
            this.studentView.Show();
            this.main_view = main_view;
            Load_Subject_List();
        }

        private void Cancel_Class_Method(object sender, EventArgs e)
        {
            Class selected_class = _bindingsource_subject.Current as Class;
            if (selected_class != null)
            {
                try
                {
                    studentRepository.cancel_registered_class(selected_class.Class_name, selected_class.Subject_id);
                    Load_Subject_List();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi he thong");
                }
            }
            else
            {
                MessageBox.Show("Vui long chon lop!");
            }
        }

        private void View_Textbook(object sender, EventArgs e)
        {
            var subject = (Subject)_bindingsource_subject.Current;
            IEnumerable<Textbook> textbook_list = studentRepository.Get_Textbooks(subject.Id);
            Textbook_View textbook_View = new Textbook_View(textbook_list, subject.Name);
            studentView.Hide();
            textbook_View.MdiParent = main_view;
            textbook_View.Show();
            textbook_View.FormBorderStyle = FormBorderStyle.None;
            textbook_View.Dock = DockStyle.Fill;
        }

        private void Load_Subject_List()
        {
            _subject_list = studentRepository.List_All_Subject();
            _bindingsource_subject.DataSource = _subject_list;
            this.studentView.SetListSubject(_bindingsource_subject);
        }

        private void Register_Method(object sender, EventArgs e)
        {
            Register_form.Get_instance_register_form(studentRepository, main_view);
            new Thread(() => {
                while (Register_form.instance_register_form != null) ;
                _subject_list = studentRepository.List_All_Subject();
                _bindingsource_subject.DataSource = _subject_list;
                this.studentView.SetListSubject(_bindingsource_subject);
            }).Start();
        }
    }
}
