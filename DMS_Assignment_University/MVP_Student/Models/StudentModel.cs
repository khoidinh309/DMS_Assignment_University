using System;
using System.Collections.Generic;
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
        private string date_of_birth;
        private string fac_name;
        IEnumerable<Subject> list_sub;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Date_of_birth { get => date_of_birth; set => date_of_birth = value; }
        public string Fac_name { get => fac_name; set => fac_name = value; }
        public IEnumerable<Subject> List_sub { get => list_sub; set => list_sub = value; }
    }
}
