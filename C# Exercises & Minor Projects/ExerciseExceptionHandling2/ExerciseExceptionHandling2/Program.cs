using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me your age: ");
            int age;
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new LessThanOrEqualToZeroException();
                }
            }
            catch (LessThanOrEqualToZeroException)
            {
                Console.WriteLine("Your age cannot be less than or equal to zero for this program to function properly.");
                Console.ReadLine();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("What you entered was in an incorrect format, try numbers only.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured, please try again.");
                Console.ReadLine();
                return;
            }



            Console.WriteLine($"I predict you were born in either the year {DateTime.Now.Year - age} or the year {DateTime.Now.Year - age - 1}.");
            Console.ReadLine();
        }
    }
}
