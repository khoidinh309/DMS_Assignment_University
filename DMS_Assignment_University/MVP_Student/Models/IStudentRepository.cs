using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University;

namespace DMS_Assignment_University.MVP_Student.Models
{
    public interface IStudentRepository
    {
        string Connection_string { get; set; }

        void Register_Method(string class_name, string subject_id,int semester);
        IEnumerable<Class> List_All_Subject();
        int Get_Num_Credits();
        int Get_Num_Subject();
        IEnumerable<Textbook> Get_Textbooks(string subject_id);
        IEnumerable<Class> Get_Released_Subject_List();
        bool check_registered_class(string class_name, string subID);
        void delete_registered_class(string subID);
        void cancel_registered_class(string class_name, string subID);
        IEnumerable<Class> get_class_by_ID(string input);
    }
}
