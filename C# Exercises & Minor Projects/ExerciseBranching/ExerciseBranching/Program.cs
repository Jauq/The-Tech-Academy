using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBranching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.Write("Package Weight: ");
            int wt = Convert.ToInt32(Console.ReadLine());
            if (wt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Package Width: ");
                int wd = Convert.ToInt32(Console.ReadLine());
                Console.Write("Package Height: ");
                int ht = Convert.ToInt32(Console.ReadLine());
                Console.Write("Package Length: ");
                int lt = Convert.ToInt32(Console.ReadLine());

                if (wt < 0 || wd < 0 || ht < 0 || lt < 0)
                {
                    Console.WriteLine("One or more of your dimensions was an impossible number, process failed. Have a good day.");
                    Console.ReadLine();
                }
                else if (wd + ht + lt > 50) //instructions say sum, so I am checking sum.
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    float total = (((wd + ht + lt) * wt) / 100.0f);
                    string sTotal = Convert.ToString(total);
                    if (sTotal.Length == 3)
                    {
                        sTotal += "0";
                    }
                    else if (sTotal.Length < 3)
                    {
                        sTotal += ".00";
                    }

                    Console.WriteLine("Your estimated total for shipping this package is: $" + sTotal);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
            }
        }
    }
}
