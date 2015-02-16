/* Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:
input - aaaaabbbbbcdddeeeedssaa	
output - abcdedsa
 */
using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        
        Console.WriteLine("Identical letters: {0}", IdenticalLetters(input));
    }

    static string IdenticalLetters(string input)
    {
        StringBuilder result = new StringBuilder();
        
        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0)
            {
                result.Append(input[i]);
            }
            else if (input[i - 1] != input[i])
            {
                result.Append(input[i]);
            }
        }
        return result.ToString();
    }

}