using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterviewQuestionSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = new int[5]{18, 37, 60, 89, 53};
            AddOdd(numbers1);

            long[] numbers2 = new long[5] { 18, 91919191919191919, 60, 89, 53 };
            AddLarge(numbers1);
            AddLarge(numbers2);

            string string1 = "Hello there!";
            Console.WriteLine(Reverse(string1));
            Console.WriteLine(RemRep(string1));

            FizzBuzz(3, 5);

            Console.ReadKey();
        }

        public static void AddOdd(int[] array)
        {
            int total = 0;

            foreach (int i in array)
            {
                if (i % 2 == 1)
                {
                    total += i;
                }
            }

            Console.WriteLine(total);
        }

        public static void AddLarge(long[] array)
        {
            long total = 0;

            foreach (long i in array) { total += i; }

            Console.WriteLine(total);
        }
        public static void AddLarge(int[] array)
        {
            int total = 0;

            foreach (int i in array) { total += i; }

            Console.WriteLine(total);
        }

        public static string Reverse(string s) //https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string RemRep(string s) //Removes repeating characters
        {
            var off = new List<char>();
            char[] word = s.ToCharArray();
            var all = new List<string>();

            foreach (char c in word)
            {
                if (!off.Contains(c))
                {
                    off.Add(c);
                    all.Add(c.ToString());
                }
            }

            return string.Join("", all.ToArray());
        }

        public static void FizzBuzz(int fizz, int buzz) //https://www.c-sharpcorner.com/blogs/fizzbuzz-in-c-sharp I added variable functionality
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % fizz == 0 && i % buzz == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % fizz == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % buzz == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
