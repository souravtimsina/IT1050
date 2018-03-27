using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
        public String FirstName;
        public String LastName;
        public int Age;
        public Person Spouse;

        public static int count;
        public static int SumOfAllAges;
        public static double AverageAge()
        {
            return (double)Person.SumOfAllAges / (double)Person.Count;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);
        }

        public void AskUserForNameAndAge()
        {
            System.Console.Write("First Name             : ");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("Last Name              : ");
            this.LastName = System.Console.ReadLine();

            System.Console.Write("Age                    : ");
            this.Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += this.Age;
        }

        public void CreateSpouseIfMarried()
        {
            System.Console.Write("Are you married? (y/n) : ");

            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                this.Spouse.AskUserForNameAndAge();
                this.Spouse.Spouse = this;
            }
        }
    }
}
    }
}
