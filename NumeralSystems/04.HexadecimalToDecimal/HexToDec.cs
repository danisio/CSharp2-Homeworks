using System;

class HexToDec
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string input = Console.ReadLine();
        Console.WriteLine("Converted to decimal: {0}", ConvertHexToDec(input));
    }

    static long ConvertHexToDec(string input)
    {
        input = input.ToUpper();

        long numberToDec = 0;
        int currentDigit = 0;
        int power = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            switch (input[i])
            {
                case 'A': currentDigit = 10;
                    break;
                case 'B': currentDigit = 11;
                    break;
                case 'C': currentDigit = 12;
                    break;
                case 'D': currentDigit = 13;
                    break;
                case 'E': currentDigit = 14;
                    break;
                case 'F': currentDigit = 15;
                    break;
                default: currentDigit = int.Parse(input[i].ToString());
                    break;
            }
            numberToDec += currentDigit * (int)Math.Pow(16, power);
            power++;
        }
        return numberToDec;
    }
}

 