using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseStringStuff
{
    class Program
    {
        static void Main()
        {
            string one = "Time fo";
            string two = "r ACTI";
            string three = "ON!!!";
            Console.WriteLine(one + two + three + "!");
            //          CONCATENATED!

            string meh = "A Megalodon is a VERY big shark.";
            string upperMeh = meh.ToUpper();
            Console.WriteLine("\n" + upperMeh);
            //          UPPERCASED!

            StringBuilder yuh = new StringBuilder();
            yuh.Append("\nThere once was a lad named \"Chimney\".");
            yuh.Append("\nHelpful tools, he would often lend me.");
            yuh.Append("\nBut during one moonlit night,");
            yuh.Append("\nChimney screamed with much fright,");
            yuh.Append("\nAs his tools vanished quite quickly.");
            Console.WriteLine(yuh);
            //          STRINGBUILT!
            Console.Read();
        }
    }
}
