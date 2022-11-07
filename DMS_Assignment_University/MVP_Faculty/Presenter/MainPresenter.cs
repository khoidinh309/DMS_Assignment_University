using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University.MVP_Faculty.Views;
using DMS_Assignment_University.MVP_Faculty.Models;
using DMS_Assignment_University.MVP_Faculty.Repository;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Faculty.Presenter
{
    public class MainPresenter
    {
        public MainPresenter(FacultyMainView main_view, string connection, int facultyID)
        {
            IFacultyView facultyView = FacultyView.Get_Faculty_View_Instance((Form)main_view);
            IFacultyRepository facultyRepository = new FacultyRepository(connection,facultyID);
            new FacultyPresenter(facultyRepository, facultyView);
        }
    }
}
