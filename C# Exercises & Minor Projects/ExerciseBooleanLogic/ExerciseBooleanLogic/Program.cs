using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.Write("What is your age? ");
            string sAge = Console.ReadLine();
            int age = Convert.ToInt32(sAge);
            Console.Write("Have you ever had a DUI? (write 'true' or 'false') ");
            string sDUI = Console.ReadLine();
            bool dUI = Convert.ToBoolean(sDUI);
            Console.Write("How many speeding tickets do you have? ");
            string sTik = Console.ReadLine();
            int tik = Convert.ToInt32(sTik);
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dUI == false && tik <= 3);
            Console.Read();
        }
    }
}
