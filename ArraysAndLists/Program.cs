using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Page 133
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> stringList = new List<string>();
        stringList.Add("What is up!");

        Console.WriteLine(intList[0]);


        // Page 132
        // Arrays are for fixed quantities that will not change or for large amounts of data.
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        int[] numArray2 = { 5, 2, 10, 200, 5000 };

        Console.WriteLine("\n\n\n\n\n" + numArray2[3]);

        Console.ReadLine();
    }
}
