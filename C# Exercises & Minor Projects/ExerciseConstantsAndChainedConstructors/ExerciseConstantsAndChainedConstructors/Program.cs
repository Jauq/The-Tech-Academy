using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseConstantsAndChainedConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const float gravityOnEarth = 9.807f;

            ChainMe chain1 = new ChainMe(false, 17);
            ChainMe chain2 = new ChainMe(true);

            Console.WriteLine("What is the rate of gravity on earth? {0} m/s^2", gravityOnEarth);
            Console.WriteLine("Was chain1 sent through a chain? {0}, and what was variable Times set to? {1}", chain1.DoIt, chain1.Times);
            Console.WriteLine("Was chain2 sent through a chain? {0}, and what was variable Times set to? {1}", chain2.DoIt, chain2.Times);
            Console.ReadLine();
        }
    }
}
