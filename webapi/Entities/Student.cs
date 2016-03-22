using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Entities
{
    public class Student
    {
        public Student() { }

        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual StudentAddress StudentAddress { get; set; }
    }
}