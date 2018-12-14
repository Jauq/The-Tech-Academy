using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number to add to the number log: ");
            using (StreamWriter file = new StreamWriter(@"..\..\Log\log.txt", true))
            {
                file.WriteLine(Console.ReadLine());
            }
            Console.WriteLine("Your number has ben sent to the number log, here is the current number log:\n" + File.ReadAllText(@"..\..\Log\log.txt"));
            Console.ReadLine();
        }
    }
}
