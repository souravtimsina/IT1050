using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var donnie = new Instructor("Donnie", "IT1050");

            var medani = new Student("Medani", donnie);

            donnie.SetStudentGrade(medani, 100);

            medani.Print();

            System.Threading.Thread.Sleep(5000);
        }
    }
}
