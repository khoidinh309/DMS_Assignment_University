using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Lecturer.Views;
using DMS_Assignment_University.MVP_Lecturer.Models;
using DMS_Assignment_University.MVP_Lecturer.Repository;

namespace DMS_Assignment_University.MVP_Lecturer.Presenter
{
    public class MainPresenter
    {
        public MainPresenter(LecturerMainView mainView, string connection, int lecturer_id)
        {
            ILecturerView lecturerView = LecturerView.Get_Instance_Lecturer_View(mainView);
            ILecturerRepository lecturerRepository = new LecturerRepository(connection, lecturer_id);
            new LecturerPresenter(lecturerRepository, lecturerView, mainView);
        }
    }
}
