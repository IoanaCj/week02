using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentApplication.Models;

namespace StudentApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var students = GetList();
            return View(students);
        }
        private List<Student> GetList()
        {
            var s1 = new Student { StudentId = 1, StudentName = "Popescu", Age = 25 };
            var s2 = new Student { StudentId = 2, StudentName = "Ionescu", Age = 23 };
            var s3 = new Student { StudentId = 3, StudentName = "Ibanescu", Age = 24};

            return new List<Student> { s1, s2, s3 };
        }
    }
}