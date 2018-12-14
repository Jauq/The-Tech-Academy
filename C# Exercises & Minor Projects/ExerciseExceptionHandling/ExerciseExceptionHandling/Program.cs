using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int>() {3, 6, 9, 11, 13, 80, 502, 832};
        Console.WriteLine("I have a list of " + intList.Count + " integers.");
        try
        {
            Console.Write("Give me a number to divide them all by (results are rounded down): ");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            foreach (int num in intList)
            {
                Console.WriteLine(num + " divided by " + givenNumber + " equals " + (num/givenNumber) + " ----- with a remainder of " + (num%givenNumber));
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type in an integer, no decimals or letters.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by 0");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("\nWe have emerged from the Try/Catch block.");
        Console.ReadLine();
    }
}
