using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.AskUserForNameAndAge();
            person1.CreateSpouseIfMarried();

            Person person2 = new Person();
            person2.AskUserForNameAndAge();
            person2.CreateSpouseIfMarried();

            Person person3 = new Person();
            person3.AskUserForNameAndAge();
            person3.CreateSpouseIfMarried();

            System.Console.WriteLine("Average Age: " + Person.AverageAge());
            System.Console.ReadKey();
        }
    }
}
