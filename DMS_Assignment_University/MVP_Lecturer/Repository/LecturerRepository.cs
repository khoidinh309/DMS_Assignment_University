using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University.MVP_Lecturer.Models;
using DMS_Assignment_University.MVP_Student.Models;
using MySql.Data.MySqlClient;

namespace DMS_Assignment_University.MVP_Lecturer.Repository
{
    public class LecturerRepository: ILecturerRepository
    {
        private readonly string connection_string;
        private int lecturer_id;
        public LecturerRepository(string connection, int lecturer_id)
        {
            this.connection_string = connection;
            this.lecturer_id = lecturer_id;
        }

        public IEnumerable<StudentModel> get_student_list(string subID, string class_name)
        {
            var result = new List<StudentModel>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_registered_class(\'{subID})\',\'{class_name}\'";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new StudentModel
                        {
                            Id = Convert.ToInt32(reader[0]),
                            Name = reader[1].ToString(),
                            Point = reader[2].ToString() == "null"?"Chưa nhập điểm" : reader[2].ToString()
                        });
                    }
                }
            }
            return result;
        }

        public IEnumerable<Class> get_teaching_class()
        {
            var result = new List<Class>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_teaching_class({lecturer_id})";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Class
                        {
                            Class_name = reader[0].ToString(),
                            Subject_id = reader[1].ToString(),
                            Subject_name = reader[2].ToString(),
                            Semester = Convert.ToInt32(reader[3]),
                            Num_credit = Convert.ToInt32(reader[4]),
                            //Lecturer_name = get_lecturer_name(reader[1].ToString(), reader[0].ToString()),
                            Current_number_member = Get_number_member(reader[1].ToString(), reader[0].ToString())
                        });
                    }
                }
            }
            return result;
        }

        private int Get_number_member(string subID, string class_name)
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
    }
}
