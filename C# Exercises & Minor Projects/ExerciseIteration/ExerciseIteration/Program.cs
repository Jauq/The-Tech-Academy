using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //  1
        string[] oneD = {"One", "Two", "Red", "Blue"};

        Console.Write("Give me a word (preferably a noun that is also nautical): ");
        string hopeNoun = Console.ReadLine();
        
        for (int i = 0; i < oneD.Length; i++)
        {
            oneD[i] = oneD[i] + " " + hopeNoun;
            Console.WriteLine(oneD[i]);
        }
        Console.WriteLine("\nNext");
        Console.ReadLine();

        //  2
        //This here be an infinite loop, I've commented it out so that way it doesn't interupt
        //the code. The set of code right after that is the one I fixed, where I switched the
        //i++ to an i-- so that way it only runs 5 times instead of infinite

        //for (int i = 5; i > 0; i++)
        //{
        //    Console.Write("It seems I have suddenly filled your screen up with endless lines. Whoops. ");
        //}

        //  3
        for (int i = 5; i > 0; i--)
        {
            Console.Write("It seems I have suddenly filled your screen up with endless lines. Whoops. ");
        }
        Console.WriteLine("Now I'm done. \nNext");
        Console.ReadLine();

        //  4 & 5
        for (int q = 0; q < 5; q++)
        {
            Console.WriteLine("This code has iterated " + (q + 1) + " times.");
        }
        for (int t = 0; t <= 5; t++)
        {
            Console.WriteLine("This code has iterated " + (t + 1) + " times.");
        }
        Console.WriteLine("Next");
        Console.ReadLine();

        // 6-8
        List<string> shapes = new List<string>() {"circle", "triangle", "square", "pentagon", "hexagon", "septagon", "octagon", "nonagon", "decagon", "rhombus", "kite", "diamond", "trapezoid"};
        Console.Write("\nWhat's your favorite geometrical shape, I'll see if I have it in my database: ");
        string shapePick = Console.ReadLine().ToLower();
        int wrongCounter = 0;
        int counter1 = 0;
        foreach (string shape in shapes)
        {
            if (shapePick != shape)
            {
                wrongCounter++;
            }
            else if (shapePick == shape)
            {
                Console.WriteLine("Your favorite geometrical shape, the " + shapePick + ", is in the database!\nIt is at index " + counter1 + ".");
                break;
            }
            counter1++;
        }
        if (wrongCounter == shapes.Count)
        {
            Console.WriteLine("Sorry. The " + shapePick + " is not in our database.");
        }
        Console.WriteLine("Next");
        Console.ReadLine();

        // 9 & 10
        List<string> colors = new List<string>() {"red", "blue", "green", "violet", "indigo", "yellow", "orange", "purple", "red", "green"};
        Console.Write("Pick one of the main colors of the rainbow, I'll see where I have it in my database: ");
        string colorPick = Console.ReadLine().ToLower();
        int missingCounter = 0;
        int counter2 = 0;
        foreach (string color in colors)
        {
            if (colorPick == color)
            {
                Console.WriteLine("Your color was found at index " + counter2 + ".");
            }
            else
            {
                missingCounter++;
            }
            counter2++;
        }
        if (missingCounter == colors.Count)
        {
            Console.WriteLine("Sorry. The color " + colorPick + " never appears in our database.");
        }
        Console.WriteLine("Next");
        Console.ReadLine();

        // 11
        List<string> bills = new List<string>() {"One", "Five", "Ten", "Twenty-Five", "Fifty", "One", "Ten", "Ten", "Fifty", "One", "Five", "Hundred"};
        List<string> checkBills = new List<string>();
        foreach (string bill in bills)
        {
            int checkCount = 0;
            foreach (string check in checkBills)
            {
                if (bill == check)
                {
                    checkCount++;
                }
            }
            if (checkCount >= 1)
            {
                Console.WriteLine("I've found a " + bill.ToLower() + " dollar bill, I already found one of these.");
            }
            else
            {
                Console.WriteLine("I've found a " + bill.ToLower() + " dollar bill.");
                checkBills.Add(bill);
            }
        }
        Console.WriteLine("Fin");
        Console.ReadLine();
    }
}
