using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_Assignment_University
{
    public class Subject
    {
        private string id;
        private string name;
        private int credits;
        private int semester;
        [DisplayName("Mã Môn")]
        public string Id { get => id; set => id = value; }
        [DisplayName("Tên Môn")]
        public string Name { get => name; set => name = value; }
        [DisplayName("Số t/c")]
        public int Credits { get => credits; set => credits = value; }
        [DisplayName("Học kỳ")]
        public int Semester { get => semester; set => semester = value; }
    }
}
