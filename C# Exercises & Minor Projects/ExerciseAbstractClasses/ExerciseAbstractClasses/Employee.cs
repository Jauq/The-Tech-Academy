using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractClasses
{
    public class Employee<T> : Person, IQuittable
    {
        public int ID { get; set; }
        public List<T> Things { get; set; }
        public override void SayName()
        {
            Console.WriteLine("My name is {0} {1}.", FirstName, LastName);
        }
        public void Quit()
        {
            Console.WriteLine("I, {0} {1}, quit.", FirstName, LastName);
        }
        public static bool operator== (Employee<T> emp1, Employee<T> emp2)
        {
            return emp1.ID == emp2.ID;
        }
        public static bool operator !=(Employee<T> emp1, Employee<T> emp2)
        {
            return emp1.ID != emp2.ID;
        }
    }
}
