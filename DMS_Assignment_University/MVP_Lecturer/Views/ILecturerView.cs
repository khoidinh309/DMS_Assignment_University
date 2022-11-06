using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    public interface ILecturerView
    {
        event EventHandler View_Student_List_Event;
        event EventHandler Add_TextBook_Event;
        event EventHandler View_TextBook_Event;
        void SetListClass(BindingSource list_subject);
        void Show();
        void Hide();
    }
}
