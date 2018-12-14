using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMoreClassStuff
{
    public static class StaticClass
    {
        public static void Hello(string name)
        {
            Console.WriteLine("Hello {0}, This class is static", name);
        }
        public static void Hello()
        {
            Console.WriteLine("This class is static");
        }
    }
}
