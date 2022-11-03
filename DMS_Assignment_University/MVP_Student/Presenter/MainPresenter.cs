using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Student.Views;
using DMS_Assignment_University.MVP_Student.Models;
using DMS_Assignment_University.MVP_Student.Repository;

namespace DMS_Assignment_University.MVP_Student.Presenter
{
    public class MainPresenter
    {
        public MainPresenter(MainStudentView main_view, string Connection, int student_id)
        {
            IStudentView studentView = StudentView.get_instance((Form)main_view);
            IStudentRepository studentRepository = new StudentRepository(Connection,student_id);
            new StudentPresenter(studentView, studentRepository, main_view);
        }
    }
}
