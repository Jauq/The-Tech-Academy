using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMoreClassStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int outInt = 0;
            Mathy mathy = new Mathy();
            Console.Write("Give me a number. I will divide it by two: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            mathy.DivideBy2(num1, out outInt);
            Console.WriteLine("The result rounded down is {0}", outInt);
            Console.ReadLine();

            StaticClass.Hello();
            StaticClass.Hello("Jimmothy");
            Console.ReadLine();
        }
    }
}
