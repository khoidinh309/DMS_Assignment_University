using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University.MVP_Faculty.Models;
using MySql.Data.MySqlClient;

namespace DMS_Assignment_University.MVP_Faculty.Repository
{
    public class FacultyRepository : IFacultyRepository
    {
        private readonly string connection_string;
        private int facultyID;
        public FacultyRepository(string connection, int facultyID)
        {
            this.connection_string = connection;
            this.facultyID = facultyID;
        }

        public void Add_New_Class(string ID)
        {
            throw new NotImplementedException();
        }

        public void Add_New_Subject(string subID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> Get_Class_List(string subID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LecturerModel> Get_Lecturer_List()
        {
            throw new NotImplementedException();
        }

        public int Get_Number_Member(string subID, string class_name)
        {
            int number_of_member = 0;
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_number_member(\'{subID}\',\'{class_name}\')";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        number_of_member = Convert.ToInt32(reader[0].ToString());
                    }
                }
            }

            return number_of_member;
        }

        public IEnumerable<Subject> Get_Released_Subject_List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> Get_Teaching_Class_List(int lecturer_ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Textbook> Get_Textbook_List(string subID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> Get_Unreleased_Subject_List()
        {
            throw new NotImplementedException();
        }

        public void Remove_Lecturer_From_Class(string class_name, string subID, int lecturer_ID)
        {
            throw new NotImplementedException();
        }
    }
}
