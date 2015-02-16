/* Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b))
 */

using System;
using System.IO;

class CorrectBrackects
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string input = Console.ReadLine();

        Console.WriteLine("The brackets are put correctly --> {0}", CheckBrackets(input));
    }

    private static bool CheckBrackets(string input)
    {
        char a = '(';
        char b = ')';
        int counter = 0;

        foreach (var letter in input)
        {
            if (letter == a)
            {
                counter++;
            }
            else if (letter == b)
            {
                counter--;
            }
            if (counter < 0)
                return false;
        }

        if (counter == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}