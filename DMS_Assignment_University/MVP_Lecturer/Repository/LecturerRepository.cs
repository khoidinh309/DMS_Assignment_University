using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University.MVP_Lecturer.Models;
using DMS_Assignment_University.MVP_Student.Models;

namespace DMS_Assignment_University.MVP_Lecturer.Repository
{
    public class LecturerRepository: ILecturerRepository
    {
        private readonly string connection;
        private int lecturer_id;
        public LecturerRepository(string connection, int lecturer_id)
        {
            this.connection = connection;
            this.lecturer_id = lecturer_id;
        }

        public IEnumerable<StudentModel> get_student_list(string subID, string class_name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> get_teaching_class()
        {
            throw new NotImplementedException();
        }
    }
}
