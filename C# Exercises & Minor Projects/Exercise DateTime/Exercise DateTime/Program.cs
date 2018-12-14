using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is {0}.", DateTime.Now);
            Console.Write("Give me a number, I will tell you what the time is after that many hours have passed: ");
            int hoursPassed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hour(s) it will be {1}.", hoursPassed, DateTime.Now.AddHours(hoursPassed));
            Console.ReadLine();
        }
    }
}
