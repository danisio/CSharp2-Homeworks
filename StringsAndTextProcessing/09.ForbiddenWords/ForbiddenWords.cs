/* We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
 */

using System;
using System.Text.RegularExpressions;

class SubString
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        Console.Write("Enter forbidden words: ");
        string words = Console.ReadLine();

        string[] forbiddenWords = words.Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            input = input.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        Console.WriteLine(input);

       //Console.WriteLine(Regex.Replace(input, words.Replace(", ", "|"), m => new String('*', m.Length)));
    }
}

