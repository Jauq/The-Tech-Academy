using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        //int[] numarray = new int[5];
        //numarray[0] = 5;
        //numarray[1] = 2;
        //numarray[2] = 10;
        //numarray[3] = 200;
        //numarray[4] = 5000;

        //int[] numarray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numarray2 = {5, 2, 10, 200, 5000, 600, 2300};

        //numarray2[5] = 650;

        //Console.WriteLine(numarray[3]);
        //Console.ReadLine();
    }
}
