using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBooleanWhile
{
    class Program
    {
        static void Main()
        {
            string guessLet = "";
            do
            {
                Console.Write("Can you guess the letter I am thinking of? ");
                guessLet = Console.ReadLine().ToLower();
                switch (guessLet)
                {
                    case "j":
                        Console.WriteLine("That is correct. Onto the next game.");
                        break;
                    default:
                        Console.WriteLine("That wasn't it. Try again");
                        break;
                }
            }
            while (guessLet != "j");
            Console.ReadLine();
            int count = 0;
            while (count < 8)
            {
                if (count == 1)
                {
                    Console.Write("You've pressed enter " + count + " time.");
                }
                else
                {
                    Console.Write("You've pressed enter " + count + " times.");
                }
                count++;
                Console.ReadLine();
            }
            Console.WriteLine("Congratulations you've pressed enter 8 times.");
            Console.ReadLine();
        }
    }
}
