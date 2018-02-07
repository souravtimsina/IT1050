using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle Name: ");
            string middleName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + middleName + " " + lastName;

            Console.Write("Height in Feet: ");
            int heightFeet = int.Parse(Console.ReadLine());
            Console.Write("Height in Inches: ");
            int heightinches = int.Parse(Console.ReadLine());

            double heightCentimeters = (heightFeet * 12 + heightinches) * 2.54;

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Citizen? (Y/N): ");
            bool isCitizen = Console.ReadLine().ToLower().StartsWith("y");

            bool canVote = isCitizen && age >= 18;

            Console.WriteLine(fullName);
            Console.WriteLine(heightCentimeters);
            Console.WriteLine(canVote);

            Console.Write("Press any key to continue: ");
            Console.ReadKey();










        }
    }
}
