using System;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Pick a Number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pick another Number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " / " + numberTwo + " = " + numberThree);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}
