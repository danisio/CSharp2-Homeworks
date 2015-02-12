using System;
using System.Collections.Generic;

class BinToHex
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string input = Console.ReadLine();
        Console.WriteLine("Converted to hexadecimal: {0}", ConvertBinToHex(input));
    }

    static string ConvertBinToHex(string input)
    {
        for (int i = 0; i < (input.Length % 4); i++)
        {
            input = "0" + input;
        }
        string numberToHex = "";

        for (int i = 0; i < input.Length; i += 4)
        {
            switch (input.Substring(i, 4))
            {
                case "1010": numberToHex += "A"; break;
                case "1011": numberToHex += "B"; break;
                case "1100": numberToHex += "C"; break;
                case "1101": numberToHex += "D"; break;
                case "1110": numberToHex += "E"; break;
                case "1111": numberToHex += "F"; break;
                case "0000": numberToHex += "0"; break;
                case "0001": numberToHex += "1"; break;
                case "0010": numberToHex += "2"; break;
                case "0011": numberToHex += "3"; break;
                case "0100": numberToHex += "4"; break;
                case "0101": numberToHex += "5"; break;
                case "0110": numberToHex += "6"; break;
                case "0111": numberToHex += "7"; break;
                case "1000": numberToHex += "8"; break;
                case "1001": numberToHex += "9"; break;
            }
        }
        return numberToHex;
    }
}

