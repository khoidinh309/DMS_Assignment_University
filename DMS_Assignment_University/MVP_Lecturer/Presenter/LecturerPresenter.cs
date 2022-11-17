using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Lecturer.Models;
using DMS_Assignment_University.MVP_Lecturer.Views;

namespace DMS_Assignment_University.MVP_Lecturer.Presenter
{
    public class LecturerPresenter
    {
        private ILecturerRepository lecturerRepository;
        private ILecturerView lecturerView;
        private BindingSource teaching_class_list;
        private IEnumerable<Class> class_list;
        LecturerMainView mainView;

        public LecturerPresenter(ILecturerRepository lecturerRepository, ILecturerView lecturerView, LecturerMainView mainView)
        {
            this.lecturerRepository = lecturerRepository;
            this.lecturerView = lecturerView;
            this.mainView = mainView;
            this.lecturerView.View_Student_List_Event += View_Student_List;
            this.lecturerView.Add_TextBook_Event += Add_TextBook;
            this.lecturerView.View_TextBook_Event += View_TextBook;
            this.lecturerView.Show();
            Load_teaching_class_list();
        }

        private void View_TextBook(object sender, EventArgs e)
        {
            var selected_subject = teaching_class_list.Current as Class;
            if (selected_subject != null) {
                TextBookView.Get_TextbookView_Instance(lecturerRepository, selected_subject.Subject_id);
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Lớp");
            }
        }

        private void Add_TextBook(object sender, EventArgs e)
        {
            var selected_subject = teaching_class_list.Current as Class;
            if (selected_subject != null)
            {
                AddTextBookView.Get_Add_Book_View_Instance(mainView, selected_subject.Subject_id, selected_subject.Subject_name, lecturerRepository);
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Lớp!");
            }
        }

        private void Load_teaching_class_list()
        {
            class_list = lecturerRepository.get_teaching_class();
            teaching_class_list.DataSource = class_list;
            lecturerView.SetListClass(teaching_class_list);
        }

        private void View_Student_List(object sender, EventArgs e)
        {
            var selected_class = teaching_class_list.Current as Class;
            if (selected_class != null)
                Member_List_View.Get_Instance_Member_List_View(lecturerRepository, mainView, selected_class.Subject_id, selected_class.Class_name);
            else
                MessageBox.Show("Vui Lòng Chọn Lớp!");
        }
    }
}
