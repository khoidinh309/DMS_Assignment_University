using System;
using System.Collections.Generic;
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

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Credits { get => credits; set => credits = value; }
        public int Semester { get => semester; set => semester = value; }
    }
}
