using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMemory
{
    partial class Student : ICloneable, IComparable<Student>
    {
      

        public Student (string firstName, string middleName, string lastName, int sSN, string address, int phone, string email, ESpeciality speciality, EFaculty faculty, EUniversity university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = sSN;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Speciality = speciality;
            this.Faculty = faculty;
            this.University = university;
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public ESpeciality Speciality { get; set; }
        public EFaculty Faculty { get; set; }
        public EUniversity University { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public static string GetFacultyName(EFaculty faculty)
        {
            switch (faculty)
            {
                case EFaculty.ScienceFaculty:
                    return "Science";
                   
                case EFaculty.LawFaculty:

                    return "Law";
                case EFaculty.NaturalScienceFaculty:

                    return "NaturalScience";
                    
                default:
                    throw new ArgumentException("faculty not set!");
            }

        }
        public void PrintStudentDetails()
        {
            Console.WriteLine($" Student {FirstName} {LastName} with {SSN} is attending {GetFacultyName(Faculty)} faculty ");
        }
        //public int CompareTo(Student student)
        //{
        //    return this.FirstName.CompareTo(student.FirstName);
        //}

        public int CompareTo(Student student)
        {
            var firstNameCompare = FirstName.CompareTo(student.FirstName);
            if (firstNameCompare != 0)
            {
                return firstNameCompare;
            }
            else
            {
                return SSN.CompareTo(student.SSN);
            }
        }
    }
}