using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University.MVP_Student.Models;
using MySql.Data.MySqlClient;

namespace DMS_Assignment_University.MVP_Student.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string connection_string;
        private int student_id;
        public StudentRepository(string connection, int student_id)
        {
            this.connection_string = connection;
            this.student_id = student_id;
        }

        public string Connection_string { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Get_Num_Credits()
        {
            throw new NotImplementedException();
        }

        public int Get_Num_Subject()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> Get_Released_Subject_List()
        {
            var result = new List<Class>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = "call get_class_list()";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Class
                        {
                            Class_name = reader[0].ToString(),
                            Subject_id = reader[1].ToString(),
                            Subject_name = reader[2].ToString(),
                            Num_credit = Convert.ToInt32(reader[3]),
                            Semester = Convert.ToInt32(reader[4]),
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

        public IEnumerable<Textbook> Get_Textbooks(string subject_id)
        {
            var result = new List<Textbook>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_textbook_list(\'{subject_id}\')";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Textbook
                        {
                            Id = Convert.ToInt32(reader[0]),
                            Name = reader[1].ToString(),
                            Specialization = reader[2].ToString()
                        });
                    }
                }
            }
            return result;
        }

        public IEnumerable<Class> List_All_Subject()
        {
            var result = new List<Class>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_registered_class({student_id})";
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
                            Lecturer_name = get_lecturer_name(reader[1].ToString(), reader[0].ToString()),
                            Current_number_member = Get_number_member(reader[1].ToString(), reader[0].ToString())
                        });
                    }
                }
            }
            return result;
        }

        public void Register_Method(string class_name, string subject_id, int semester)
        {
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call add_new_student_of_class(\'{class_name}\',{semester},\'{subject_id}\',{this.student_id})";
                commnand.ExecuteNonQuery();
            }
        }

        public bool check_registered_class(string class_name, string subID)
        {
            int count = 0;
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"select * from manage_point where student_id = {student_id} and class_name = \'{class_name}\' and subID = \'{subID}\'";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        count++;
                    }
                }
            }

            return count != 0;
        }

        public void delete_registered_class(string subID)
        {
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"delete from manage_point where student_ID = {student_id} and subID = \'{subID}\'";
                commnand.ExecuteNonQuery();
            }
        }

        public void cancel_registered_class(string class_name, string subID)
        {
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call canncel_registered_class({student_id},\'{subID}\',\'{class_name}\', 221)";
                commnand.ExecuteNonQuery();
            }
        }

        public IEnumerable<Class> get_class_by_ID(string input)
        {
            var result = new List<Class>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_class_list_by_id(\'{input}\')";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Class
                        {
                            Class_name = reader[0].ToString(),
                            Subject_id = reader[1].ToString(),
                            Subject_name = reader[2].ToString(),
                            Num_credit = Convert.ToInt32(reader[3]),
                            Semester = Convert.ToInt32(reader[4]),
                            Current_number_member = Get_number_member(reader[1].ToString(), reader[0].ToString()),
                            Lecturer_name = get_lecturer_name(reader[1].ToString(), reader[0].ToString())
                        });
                    }
                }
            }
            return result;
        }

        public string get_lecturer_name(string subID, string class_name)
        {
            string lecturer_name = "Chưa phân công";
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"select l.full_name from teach as t, lecturer as l " +
                    $"where t.class_name = \'{class_name}\' and t.subID = \'{subID}\' and l.lecturer_Id = t.lecturer_Id";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecturer_name = reader[0].ToString();
                    }
                }
            }
            return lecturer_name;
        }
    }
}
