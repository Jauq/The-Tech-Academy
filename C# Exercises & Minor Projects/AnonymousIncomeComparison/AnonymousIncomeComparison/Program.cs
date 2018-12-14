using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: ");
            Console.Write("Hourly Rate: ");
            string per1amount = Console.ReadLine();
            Console.Write("Hours Worked this week: ");
            string per1hours = Console.ReadLine();
            int p1amount = Convert.ToInt32(per1amount);
            int p1hours = Convert.ToInt32(per1hours);

            Console.WriteLine("Person 2: ");
            Console.Write("Hourly Rate: ");
            string per2amount = Console.ReadLine();
            Console.Write("Hours Worked this week: ");
            string per2hours = Console.ReadLine();
            int p2amount = Convert.ToInt32(per2amount);
            int p2hours = Convert.ToInt32(per2hours);

            Console.WriteLine("Weekly Salary of Person 1: $" + (p1amount * p1hours));
            Console.WriteLine("Weekly Salary of Person 2: $" + (p2amount * p2hours));
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine((p1amount * p1hours) > (p2amount * p2hours));
            Console.ReadLine();
        }
    }
}
