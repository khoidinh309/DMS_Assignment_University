using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

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
        private string lecturer_name;
        private string day;
        private string started_time;
        [DisplayName("Tên Lớp")]
        public string Class_name { get => class_name; set => class_name = value; }
        [DisplayName("Mã Môn Học")]
        public string Subject_id { get => subject_id; set => subject_id = value; }
        [DisplayName("Tên Môn Học")]
        public string Subject_name { get => subject_name; set => subject_name = value; }
        [DisplayName("Học Kỳ")]
        public int Semester { get => semester; set => semester = value; }
        [DisplayName("Số Tín Chỉ")]
        public int Num_credit { get => num_credit; set => num_credit = value; }
        [DisplayName("S/L Thành Viên")]
        public int Current_number_member { get => current_number_member; set => current_number_member = value; }
        [DisplayName("Tên G/V")]
        public string Lecturer_name { get => lecturer_name; set => lecturer_name = value; }
        [DisplayName("Tuần Học")]
        public string Day { get => day; set => day = value; }
        [DisplayName("Giờ Học")]
        public string Started_time { get => started_time; set => started_time = value; }
    }
}
