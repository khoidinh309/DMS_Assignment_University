using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University.MVP_Student.Models;

namespace DMS_Assignment_University.MVP_Lecturer.Models
{
    public interface ILecturerRepository
    {
        IEnumerable<Class> get_teaching_class();
        IEnumerable<StudentModel> get_student_list(string subID, string class_name);
        void Add_New_TextBook(string subID, string texbook_name, string specialization);
        Textbook Get_Existing_TextBook(string subID);
        void Modify_TextBook(Textbook textbook);
        IEnumerable<Textbook> Get_Textbook_List(string subID);
        void set_mark_to_student(string class_name, string subID, int student_ID, float mark);
    }
}
