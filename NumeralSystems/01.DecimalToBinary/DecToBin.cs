using System;
using System.Collections.Generic;

class DecToBin
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("Converted to binary = {0}", string.Join("", ConvertDecToBin(input)));
    }

    static List<int> ConvertDecToBin(int input)
    {
        List<int> numberToBin = new List<int>();
        while (input > 0)
        {
            numberToBin.Add(input % 2);
            input /= 2;
        }
        numberToBin.Reverse();
        return numberToBin;
    }
}

