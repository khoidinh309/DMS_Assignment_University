using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University.MVP_Faculty.Views;
using DMS_Assignment_University.MVP_Faculty.Repository;
using DMS_Assignment_University.MVP_Faculty.Models;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Faculty.Presenter
{
    public class FacultyPresenter
    {
        private IFacultyView facultyView;
        private IFacultyRepository facultyRepository;
        private BindingSource released_subject_list;
        IEnumerable<Subject> subject_list;
        public FacultyPresenter(IFacultyRepository facultyRepository, IFacultyView facultyView)
        {
            released_subject_list = new BindingSource();
            this.facultyRepository = facultyRepository;
            this.facultyView = facultyView;
            this.facultyView.Add_New_Class_Event += Add_New_Class;
            this.facultyView.Add_New_Subject_Event += Add_New_Subject;
            this.facultyView.View_Lecturer_Event += View_Lecturer;
            this.facultyView.View_TextBook_Event += View_TextBook;
            this.facultyView.Show();
            Load_Released_Subject_List();
        }

        public void Load_Released_Subject_List()
        {
            subject_list = facultyRepository.Get_Released_Subject_List();
            released_subject_list.DataSource = subject_list;
            this.facultyView.Set_Released_Subject_List(released_subject_list);
        }

        private void View_TextBook(object sender, EventArgs e)
        {
            var selected_subject = released_subject_list.Current as Subject;
            TextBookView textBookView = new TextBookView(facultyRepository, selected_subject.Id, selected_subject.Name);
            textBookView.Show();
        }

        private void View_Lecturer(object sender, EventArgs e)
        {
            LecuturerViewForm lecuturerViewForm = new LecuturerViewForm(facultyRepository);
            lecuturerViewForm.MdiParent = FacultyMainView.global_view;
            FacultyView.instance.Hide();
            lecuturerViewForm.FormBorderStyle = FormBorderStyle.None;
            lecuturerViewForm.Dock = DockStyle.Fill;
            lecuturerViewForm.Show();
        }

        private void Add_New_Subject(object sender, EventArgs e)
        {
            Add_Subject_Form add_subject_form = new Add_Subject_Form(facultyRepository, this);
            //add_subject_form.MdiParent = FacultyMainView.global_view;
            add_subject_form.Show();
        }

        private void Add_New_Class(object sender, EventArgs e)
        {
            Subject selected_subject = released_subject_list.Current as Subject;
            if (selected_subject != null)
            {
                ClassView classView = new ClassView(selected_subject.Id, facultyRepository);
                //classView.MdiParent = FacultyMainView.global_view;
                classView.Show();
            }
            else
            {
                MessageBox.Show("Vui long chon mon hoc!");
            }
        }
    }
}
