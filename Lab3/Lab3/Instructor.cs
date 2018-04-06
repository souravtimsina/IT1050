using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Instructor
    {
        public string Name;
        public string CourseName;

        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void Print()
        {
            System.Console.WriteLine("I am a teacher named " + this.Name + ".");
            System.Console.WriteLine("I teach the course " + this.CourseName + ".");
        }
    }
}
  
