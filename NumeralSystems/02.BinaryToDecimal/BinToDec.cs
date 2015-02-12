using System;

class BinToDec
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string input = Console.ReadLine();

        Console.WriteLine("Converted to decimal: {0}", ConvertBinToDec(input));
    }

    static long ConvertBinToDec(string input)
    {
        int length = input.Length;
        long inputNumber = long.Parse(input);
        long numberToDec = 0;

        for (int i = 0; i < length; i++)
        {
            long lastDigit = inputNumber % 10;
            numberToDec += lastDigit * (long)(Math.Pow(2, i));
            inputNumber = inputNumber / 10;
        }
        return numberToDec;
    }
}

