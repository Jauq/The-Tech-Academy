using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number snumber = new Number() { Amount = 30.2m};
            Console.WriteLine(snumber.Amount);
            Console.ReadLine();
        }
    }
}
