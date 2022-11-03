using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Student.Views
{
    public interface IStudentView
    {
        event EventHandler Register_Method_Event;
        event EventHandler View_textbook_Event;
        event EventHandler Cancel_Class_Event;

        void SetListSubject(BindingSource list_subject);
        void Show();
        void Hide();
    }
}
