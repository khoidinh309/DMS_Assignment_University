using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Faculty.Views
{
    public interface IFacultyView
    {
        event EventHandler Add_New_Class_Event;
        event EventHandler Add_New_Subject_Event;
        event EventHandler View_Lecturer_Event;
        event EventHandler View_TextBook_Event;
        void Set_Released_Subject_List(BindingSource subject_list);

        void Show();
        void Hide();
    }
}
