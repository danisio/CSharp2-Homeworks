using System;
using System.Collections.Generic;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long input = int.Parse(Console.ReadLine());

        Console.WriteLine("Converted to hexadecimal: {0}", string.Join("", ConvertDecToHex(input)));
    }

    static List<string> ConvertDecToHex(long input)
    {
        List<string> numberToHex = new List<string>();

        while (input > 0)
        {
            if (input % 16 > 9)
            {
                switch (input % 16)
                {
                    case 10: numberToHex.Add("A");
                        break;
                    case 11: numberToHex.Add("B");
                        break;
                    case 12: numberToHex.Add("C");
                        break;
                    case 13: numberToHex.Add("D");
                        break;
                    case 14: numberToHex.Add("E");
                        break;
                    case 15: numberToHex.Add("F");
                        break;
                }
            }
            else
            {
                numberToHex.Add((input % 16).ToString());
            }
            input /= 16;
        }
        numberToHex.Reverse();
        return numberToHex;
    }
}


