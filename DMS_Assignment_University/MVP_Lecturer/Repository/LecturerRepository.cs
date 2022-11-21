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

        public void Add_New_TextBook(string subID, string texbook_name, string specialization)
        {
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call add_new_textbook({this.lecturer_id},\'{subID}\',\'{texbook_name}\',\'{specialization}\')";
                commnand.ExecuteNonQuery();
            }
        }

        public Textbook Get_Existing_TextBook(string subID)
        {
            Textbook existing_textbook = new Textbook();
            existing_textbook.Id = -1;
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"select m.textbook_id, t.textbook_name, t.specialization from textbook as t, manage_subject as m" +
                                        $" where m.textbook_id = t.textbook_id and m.subid = \'{subID}\' and m.lecturer_id = {this.lecturer_id}";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        existing_textbook.Id = Convert.ToInt32(reader[0]);
                        existing_textbook.Name = reader[1].ToString();
                        existing_textbook.Specialization = reader[2].ToString();
                    }
                }
                return existing_textbook;
            }
        }

        public IEnumerable<StudentModel> get_student_list(string subID, string class_name)
        {
            var result = new List<StudentModel>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_student_list(\'{subID}\',\'{class_name}\')";
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

        public IEnumerable<Textbook> Get_Textbook_List(string subID)
        {
            var result = new List<Textbook>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_textbook_list(\'{subID}\')";
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

        public void Modify_TextBook(Textbook textbook)
        {
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"update textbook set textbook_name = \'{textbook.Name}\', specialization = \'{textbook.Specialization}\'" +
                                       $" where textbook_id = {textbook.Id}";
                commnand.ExecuteNonQuery();
            }
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
