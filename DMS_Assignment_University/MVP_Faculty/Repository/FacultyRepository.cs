﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS_Assignment_University.MVP_Faculty.Models;

namespace DMS_Assignment_University.MVP_Faculty.Repository
{
    public class FacultyRepository : IFacultyRepository
    {
        private readonly string connection;
        private int facultyID;
        public FacultyRepository(string connection, int facultyID)
        {
            this.connection = connection;
            this.facultyID = facultyID;
        }

        public void Add_New_Class()
        {
            throw new NotImplementedException();
        }

        public void Add_New_Subject(string subID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> Get_Class_List(string subID)
        {
            throw new NotImplementedException();
        }

        public int Get_Number_Member(string subID, string class_name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> Get_Released_Subject_List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> Get_Unreleased_Subject_List()
        {
            throw new NotImplementedException();
        }
    }
}
