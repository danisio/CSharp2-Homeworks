using System;
using System.Collections.Generic;

class HexToBin
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string input = Console.ReadLine();
        Console.WriteLine("Converted to binary: {0}", string.Join("", ConvertHexToBin(input)));
    }

    static List<string> ConvertHexToBin(string input)
    {
        List<string> numberToBin = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case '0': numberToBin.Add(" 0000"); break;
                case '1': numberToBin.Add(" 0001"); break;
                case '2': numberToBin.Add(" 0010"); break;
                case '3': numberToBin.Add(" 0011"); break;
                case '4': numberToBin.Add(" 0100"); break;
                case '5': numberToBin.Add(" 0101"); break;
                case '6': numberToBin.Add(" 0110"); break;
                case '7': numberToBin.Add(" 0111"); break;
                case '8': numberToBin.Add(" 1000"); break;
                case '9': numberToBin.Add(" 1001"); break;
                case 'A': numberToBin.Add(" 1010"); break;
                case 'B': numberToBin.Add(" 1011"); break;
                case 'C': numberToBin.Add(" 1100"); break;
                case 'D': numberToBin.Add(" 1101"); break;
                case 'E': numberToBin.Add(" 1110"); break;
                case 'F': numberToBin.Add(" 1111"); break;
            }
        }
        return numberToBin;
    }
}

