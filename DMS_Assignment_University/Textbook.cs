using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_Assignment_University
{
    public class Textbook
    {
        private int id;
        private string name;
        private string specialization;
        [DisplayName("Mã Sách")]
        public int Id { get => id; set => id = value; }
        [DisplayName("Tên sách")]
        public string Name { get => name; set => name = value; }
        [DisplayName("Chuyên Ngành")]
        public string Specialization { get => specialization; set => specialization = value; }
    }
}
