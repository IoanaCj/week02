using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentApplication.Models;
using System.Data;
using System.Data.SqlClient;

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

        public ActionResult Details(int id)
        {
            var students = GetList();
            var student = FindById(students, id);
            return View(student);
        }

        private Student FindById(List<Student> students, int id)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var std = GetList().Where(s => s.Id == id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
                var id = std.Id;
                var name = std.StudentName;
                var age = std.Age;
                return RedirectToAction("Index");
        }

        private List<Student> GetList()
        {
            var s1 = new Student { Id = 1, StudentName = "Ionescu", Age = 24};
            var s2 = new Student { Id = 2, StudentName = "Popescu", Age = 22};
            var s3 = new Student { Id = 3, StudentName = "Ibanescu", Age = 25};

            return new List<Student> { s1, s2, s3 };
        }

        //SQL connection
        private static SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=.;Initial Catalog=StudentApplication;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        //GET
        public ActionResult AddStudent()
        {
            return View();
        }

        //POST
        //To Add Student details
        public bool AddStudent(Student student)
        {
            SqlConnection insertConnection = CreateConnection();

            if (insertConnection.State == ConnectionState.Closed)
            {
                insertConnection.Open();
            }
            var cmd = insertConnection.CreateCommand();
            cmd.Parameters.AddWithValue("@Id", student.Id);
            cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
            cmd.Parameters.AddWithValue("@Age", student.Age);
            int i = cmd.ExecuteNonQuery();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }
        }
    }
}