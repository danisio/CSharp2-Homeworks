/* Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
 */

using System;

class StringLength
{
    static void Main()
    {
        Console.Write("Enter a string of maximum 20 characters: ");
        string input = Console.ReadLine();

        if (input.Length < 20)
        {
            input = input.PadRight(20, '*');
            Console.WriteLine(input);
        }
        else if (input.Length > 20)
        {
            Console.WriteLine("Invalid input");
        }
    }
}

