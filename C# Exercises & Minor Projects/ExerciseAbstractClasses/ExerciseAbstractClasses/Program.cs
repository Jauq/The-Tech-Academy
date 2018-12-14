using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<String>() { FirstName = "Sample", LastName = "Student", ID = 0};
            emp1.SayName();
            Console.ReadLine();

            //This has been updated for the interface exercise
            IQuittable quiting = new Employee<int>() { FirstName = "Mister", LastName = "Man", ID = 1};
            quiting.Quit();
            Console.ReadLine();

            //This has been updated for the operator overloading exercise
            Employee<string> sam = new Employee<string>() { FirstName = "Sam", LastName = "ple Student", ID = 0 };
            Employee<string> notSam = new Employee<string>() { FirstName = "Not", LastName = "Sam", ID = 2 };
            Console.WriteLine("Are {0} and {1} the same? {2}", sam.FullName(), notSam.FullName(), sam == notSam);
            Console.WriteLine("Are {0} and {1} the same? {2}", emp1.FullName(), sam.FullName(), emp1 == sam);
            Console.ReadLine();

            //This has been updated for the generic parameter exercise
            Employee<int> intMan = new Employee<int>() { FirstName = "Int", LastName = "Man", ID = 3};
            emp1.Things = new List<string>() { "Spoon", "Pen", "Fan", "Cereal", "Cheese", "Asteroid"};
            intMan.Things = new List<int>() { 39, 58, 63, 9002, 830, 7};
            foreach (string thing in emp1.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in intMan.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
