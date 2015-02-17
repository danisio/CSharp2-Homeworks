/* Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
 */
using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine("{1,15:D} --> {0}", "Decimal number", number);
        Console.WriteLine("{1,15:X} --> {0}", "Hexadecimal number", number);
        Console.WriteLine("{1,15:P} --> {0}", "Percentage", number);
        Console.WriteLine("{1,15:E} --> {0}", "Scientific notation", number); 
    }
}

