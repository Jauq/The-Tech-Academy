using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseVariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string onCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pgNumStr = Console.ReadLine();
            int pgNum = Convert.ToInt32(pgNumStr);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string needHelpStr = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(needHelpStr);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursTodayStr = Console.ReadLine();
            int hoursToday = Convert.ToInt16(hoursTodayStr);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
