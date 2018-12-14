using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Moth firstMoth = new Moth();

            int giveMe = firstMoth.DoItMothy(32);
            Console.WriteLine(giveMe);

            Moth secondMoth = new Moth();

            int grieve = secondMoth.DoItMothy(99.0m);
            Console.WriteLine(grieve);

            Moth thirdMoth = new Moth();

            int sunny = thirdMoth.DoItMothy("77");
            Console.WriteLine(sunny);
            Console.ReadLine();
        }
    }
}
