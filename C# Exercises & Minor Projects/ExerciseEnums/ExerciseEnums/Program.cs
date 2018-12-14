using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (! done)
            {
                try
                {
                    Console.Write("Please enter the current day of the week: ");
                    string currentDay = Console.ReadLine();
                    int day = 0;
                    day = (int)Enum.Parse(typeof(DaysOfTheWeek), currentDay, true);
                    Console.WriteLine(day);
                    Console.ReadLine();
                    done = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occured. Please enter an actualy day of the week.");
                }
            }
        }
    }
    public enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
