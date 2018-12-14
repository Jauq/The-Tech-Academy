using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            Classy classy = new Classy();

            Classy.Mathings(4, 8);
            Classy.Mathings(num1: 81, num2: 55);
            Console.ReadLine();
        }
    }
}
