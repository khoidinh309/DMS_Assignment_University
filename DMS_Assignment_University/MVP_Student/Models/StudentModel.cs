using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University;

namespace DMS_Assignment_University.MVP_Student.Models
{
    public class StudentModel
    {
        private int id;
        private string name;
        private string point;
        [DisplayName("Mã Số")]
        public int Id { get => id; set => id = value; }
        [DisplayName("Họ Và Tên")]
        public string Name { get => name; set => name = value; }
        [DisplayName("Điểm")]
        public string Point { get => point; set => point = value; }
    }
}
