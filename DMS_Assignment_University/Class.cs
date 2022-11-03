using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University;

namespace DMS_Assignment_University
{
    public class Class
    {
        private string class_name;
        private string subject_id;
        private string subject_name;
        private int num_credit;
        private int semester;
        private int current_number_member;
        private string day;
        private string started_time;
        public string Class_name { get => class_name; set => class_name = value; }
        public string Subject_id { get => subject_id; set => subject_id = value; }
        public string Subject_name { get => subject_name; set => subject_name = value; }
        public int Semester { get => semester; set => semester = value; }
        public int Num_credit { get => num_credit; set => num_credit = value; }
        public int Current_number_member { get => current_number_member; set => current_number_member = value; }
        public string Day { get => day; set => day = value; }
        public string Started_time { get => started_time; set => started_time = value; }
    }
}
