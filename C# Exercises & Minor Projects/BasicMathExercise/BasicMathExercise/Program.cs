using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathExercise
{
    class Program
    {
        static void Main()
        {
            Console.Write("Give me a number, I will multiply it by 50: ");
            string numStr1 = Console.ReadLine();
            int num1 = Convert.ToInt32(numStr1);
            Console.WriteLine(numStr1 + " times 50 is " + (num1 * 50));

            Console.Write("Now give me a number, I will add 25 to it: ");
            string numStr2 = Console.ReadLine();
            int num2 = Convert.ToInt32(numStr2);
            Console.WriteLine(numStr2 + " plus 25 is " + (num2 + 25));

            Console.Write("Now give me another number, I will divide it by 12.5: ");
            string numStr3 = Console.ReadLine();
            int num3 = Convert.ToInt32(numStr3);
            Console.WriteLine(numStr3 + " divided by 12.5 is " + (num3 / 12.5));

            Console.Write("Now give me a number again, I will see if it is more than 50: ");
            string numStr4 = Console.ReadLine();
            int num4 = Convert.ToInt32(numStr4);
            Console.WriteLine((num4 > 50));

            Console.Write("Now give me a final number, I will divide it by 7 and give you a remainder: ");
            string numStr5 = Console.ReadLine();
            int num5 = Convert.ToInt32(numStr5);
            Console.WriteLine("The remainder of " + numStr5 + ", when divided by 7, is: " + (num5 % 7));
            Console.ReadLine();
        }
    }
}
