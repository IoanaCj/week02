using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApplication.Models
{
    public class Student
    {
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int Id { get; internal set; }
    }
}