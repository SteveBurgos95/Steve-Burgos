﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class modelClass
    {

    }
    public class Student
    {
        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public int StandardID { get; set; }
        public int Age { get; set; }
    }
    public class Standard
    {
        public int StandardID { get; set; }
        public string? StandardName { get; set; }
    }
}
