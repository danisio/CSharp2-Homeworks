/* Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */
using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter base S = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter base D = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter number = ");
        string inputNumber = Console.ReadLine();

        Console.WriteLine("The result = {0}", ConvertNumbericSystem(inputNumber, s, d));
    }

    static string ConvertNumbericSystem(string inputNumber, int base1, int base2)
    {
        ulong numberToDec = 0;
        inputNumber = inputNumber.ToUpper();
        
        for (int i = inputNumber.Length - 1; i >= 0; i--)
        {
            if (Char.IsDigit(inputNumber[i]))
            {
                numberToDec += (ulong)((inputNumber[i] - '0') * Math.Pow(base1, inputNumber.Length - i - 1));
            }
            else
            {
                int num = 0;
                switch (inputNumber[i])
                {
                    case 'A': num = 10; break;
                    case 'B': num = 11; break;
                    case 'C': num = 12; break;
                    case 'D': num = 13; break;
                    case 'E': num = 14; break;
                    case 'F': num = 15; break;
                }
                numberToDec += (ulong)(num * Math.Pow(base1, inputNumber.Length - i - 1));
            }
        }

        ulong remainder;
        string result = "";

        while (numberToDec > 0)
        {
            remainder = (ulong)(numberToDec % (ulong)base2);
            numberToDec /= (ulong)base2;

            if (remainder < 10)
            {
                result = remainder.ToString() + result;
            }
            else
            {
                switch (remainder)
                {
                    case 10: result = "A" + result; break;
                    case 11: result = "B" + result; break;
                    case 12: result = "C" + result; break;
                    case 13: result = "D" + result; break;
                    case 14: result = "E" + result; break;
                    case 15: result = "F" + result; break;
                }
            }
        }
        return result;
    }
}
