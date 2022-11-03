using System;
using System.Collections.Generic;
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

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Specialization { get => specialization; set => specialization = value; }
    }
}
