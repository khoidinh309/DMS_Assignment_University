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
    }
}
