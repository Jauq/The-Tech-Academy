using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Options optionClass = new Options();
            Console.Write("Give me a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("(OPTIONAL) Give me a second number: ");
            string strNum2 = Console.ReadLine();
            bool choose = (strNum2 != "");
            int answer = 0;
            if (choose)
            {
                int num2 = Convert.ToInt32(strNum2);
                answer = optionClass.MultTwo(num1, num2);
                Console.WriteLine("{0} * {1} = {2}", num1, num2, answer);
            }
            else
            {
                answer = optionClass.MultTwo(num1);
                Console.WriteLine("{0} * 5 = {1}", num1, answer);
            }
            Console.ReadLine();
        }
    }
}
