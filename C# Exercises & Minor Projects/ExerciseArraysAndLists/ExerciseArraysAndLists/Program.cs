using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = {"Apple", "Coconut", "Elderberry", "Grape", "Kiwi", "Durian"};
            Console.Write("Pick a number from 1 to 6 and I will pick a fruit for you: ");
            int choise1 = Convert.ToInt32(Console.ReadLine());
            if (choise1 >= 1 && choise1 <= 6)
            {
                if (stringArray[choise1 - 1].StartsWith("A") || stringArray[choise1 - 1].StartsWith("E"))
                {
                    Console.WriteLine("You were given an " + stringArray[choise1 - 1] + "!");
                }
                else
                {
                    Console.WriteLine("You were given a " + stringArray[choise1 - 1] + "!");
                }
            }
            else if (choise1 < 1 || choise1 > 6)
            {
                Console.WriteLine("You picked a number outside of the range, no fruit for you.");
            }
            else
            {
                Console.WriteLine("An error occured when determining you answer, perhaps you did not give me a number.");
            }
            Console.Write("Next");
            Console.ReadLine();

            int[] intArray = {0, 0, 0, 1, 0, 0, 3, 1, 1, 0, 0, 5, 3, 0, 0, 1, 1, 25, 0, 0, 0, 5, 3, 0, 1, 0, 3, 1, 1, 0, 0};
            Console.Write("Pick a number between 1 and " + intArray.Length + " and I will pick a prize for you: ");
            int choise2 = Convert.ToInt32(Console.ReadLine());
            if (choise2 >= 1 && choise2 <= intArray.Length)
            {
                Console.WriteLine("Congratulations you win $" + intArray[choise2 - 1] + "! Happy Lucky Win.");
            }
            else if (choise2 < 1 || choise2 > intArray.Length)
            {
                Console.WriteLine("You picked a number outside of the range, no winnings for you.");
            }
            else
            {
                Console.WriteLine("An error occured when determining you answer, perhaps you did not give me a number.");
            }
            Console.Write("Next");
            Console.ReadLine();

            List<string> stringList = new List<string>();
            stringList.Add("Trombone");
            stringList.Add("Harmonica");
            stringList.Add("Triangle");
            stringList.Add("Bassoon");
            stringList.Add("Bagpipes");
            stringList.Add("Violin");
            stringList.Add("Acoustic Guitar");
            stringList.Add("Maracas and Tamborine");
            Console.Write("Pick a number between 1 and " + stringList.Count + " to determine your fate: ");
            int choise3 = Convert.ToInt32(Console.ReadLine());
            if(choise3 >= 1 && choise3 <= stringList.Count)
            {
                Console.WriteLine("You decided to attend a concert of your favorite musician: " + stringList[choise3 - 1] + "-y Man.");
            }
            else if (choise3 < 1 || choise3 > stringList.Count)
            {
                Console.WriteLine("You picked a number outside of the range, your day is boring.");
            }
            else
            {
                Console.WriteLine("An error occured when determining you answer, perhaps you did not give me a number.");
            }
            Console.Write("Fin");
            Console.ReadLine();
        }
    }
}
