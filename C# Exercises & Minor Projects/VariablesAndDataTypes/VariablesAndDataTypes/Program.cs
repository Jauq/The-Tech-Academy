using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.writeline("what is your name?");
            //string yourname = Console.readline();
            //Console.writeline("your name is: " + yourname);
            //Console.readline();

            //Console.WriteLine("What is your favorite Number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite numberplus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.235236;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "Tim";

            int currentAge = 18;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
