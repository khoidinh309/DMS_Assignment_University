using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Faculty.Models
{
    public interface IFacultyRepository
    {
        IEnumerable<Subject> Get_Released_Subject_List();   // Get subject list released by faculty
        IEnumerable<Class> Get_Class_List(string subID);    // Get class list
        void Add_New_Class();                               // Add new class 
        int Get_Number_Member(string subID, string class_name);
        IEnumerable<Subject> Get_Unreleased_Subject_List();
        void Add_New_Subject(string subID);                 // Release new subject
    }
}
