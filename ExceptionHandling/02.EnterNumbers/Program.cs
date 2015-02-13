/* Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;

class Program
{
    static int start = 1;
    static int end = 100;
    const int count = 10;

    static void Main()
    {
        try
        {
            for (int i = 1; i < count; i++)
            {
                start = ReadNumber(i, end);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range");
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect format");
        }
    }

    static int ReadNumber(int start, int end)
    {
        Console.Write("Enter number: ");
        int input = int.Parse(Console.ReadLine());

        if ((input < start) || (input > end))
        {
            throw new ArgumentOutOfRangeException();
        }

        return input;
    }
}

