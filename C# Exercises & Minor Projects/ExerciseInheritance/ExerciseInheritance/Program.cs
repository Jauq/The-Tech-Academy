using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { FirstName = "Sample", LastName = "Student"};
            emp1.SayName();
            Console.ReadLine();
        }
    }
}
