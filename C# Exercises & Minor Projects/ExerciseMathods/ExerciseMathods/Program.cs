using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMathods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number, I will add 7 to it, subtract 7 from it, and multiply it by 7: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num + " plus 7 is " + Mathod.PlusSeven(num));
            Console.WriteLine(num + " minus 7 is " + Mathod.MinusSeven(num));
            Console.WriteLine(num + " multiplied by 7 is " + Mathod.MultiplyBySeven(num));
            Console.ReadLine();
        }
    }
}
