﻿using System;
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
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call released_new_subject(\'{ID}\')";
                commnand.ExecuteNonQuery();
            }
        }

        public void Add_New_Subject(string subID)
        {
            IEnumerable<Class> class_list = Get_Class_List(subID);
            List<string> class_name_list = new List<string>();

            foreach(var item in class_list)
            {
                class_name_list.Add(item.Class_name);
            }

            class_name_list.Sort();
            string last_class = class_name_list[class_name_list.Count - 1];
            char class_no = last_class[2];
            char new_class_no = (char)(class_no + 1);
            string new_class_name = "L0" + new_class_no;
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"insert into class values(\'{new_class_name}\',\'{subID}\',221)";
                commnand.ExecuteNonQuery();
            }
        }

        public IEnumerable<Class> Get_Class_List(string subID)
        {
            var result = new List<Class>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_class_list_by_id(\'{subID}\')";
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

        public IEnumerable<LecturerModel> Get_Lecturer_List()
        {
            var result = new List<LecturerModel>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"select lecturer_id,full_name from lecturer where facid = {facultyID}";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new LecturerModel
                        {
                            Lecturer_ID = Convert.ToInt32(reader[0]),
                            Lecturer_Name = reader[1].ToString()
                        });
                    }
                }
            }
            return result;
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
            var result = new List<Subject>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_released_subject_list({facultyID})";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Subject
                        {
                            Id = reader[0].ToString(),
                            Name = reader[1].ToString(),
                            Credits = Convert.ToInt32(reader[2]),
                            Semester = Convert.ToInt32(reader[3])
                        });
                    }
                }
            }
            return result;
        }

        public IEnumerable<Class> Get_Teaching_Class_List(int lecturer_ID)
        {
            var result = new List<Class>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_teaching_class({lecturer_ID})";
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
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> Get_Unreleased_Subject_List()
        {
            var result = new List<Subject>();
            using (var connection = new MySqlConnection(connection_string))
            using (var commnand = new MySqlCommand())
            {
                connection.Open();
                commnand.Connection = connection;
                commnand.CommandText = $"call get_unreleased_subject({facultyID})";
                using (var reader = commnand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Subject
                        {
                            Id = reader[0].ToString(),
                            Name = reader[1].ToString(),
                            Credits = Convert.ToInt32(reader[2]),
                            Semester = Convert.ToInt32(reader[3])
                        });
                    }
                }
            }
            return result;
        }

        public void Remove_Lecturer_From_Class(string class_name, string subID, int lecturer_ID)
        {
            throw new NotImplementedException();
        }
    }
}
