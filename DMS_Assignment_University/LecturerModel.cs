using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_Assignment_University
{
    public class LecturerModel
    {
        private int lecturer_ID;
        private string lecturer_Name;
        [DisplayName("Mã Số")]
        public int Lecturer_ID { get => lecturer_ID; set => lecturer_ID = value; }
        [DisplayName("Họ Và Tên")]
        public string Lecturer_Name { get => lecturer_Name; set => lecturer_Name = value; }
    }
}
