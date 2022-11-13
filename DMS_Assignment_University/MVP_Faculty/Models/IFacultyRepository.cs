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
        void Add_New_Class(string subID);                               // Add new class 
        int Get_Number_Member(string subID, string class_name);
        IEnumerable<Subject> Get_Unreleased_Subject_List();
        void Add_New_Subject(string subID);                 // Release new subject
        IEnumerable<LecturerModel> Get_Lecturer_List();
        IEnumerable<Class> Get_Teaching_Class_List(int lecturer_ID);
        void Remove_Lecturer_From_Class(string class_name, string subID, int lecturer_ID);
        IEnumerable<Textbook> Get_Textbook_List(string subID);
    }
}
