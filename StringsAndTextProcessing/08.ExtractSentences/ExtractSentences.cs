/* Write a program that extracts from a given text all sentences containing given word.
 */
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

using System;
using System.Collections.Generic;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        Console.WriteLine("Found sentences: \n{0}", string.Join("\n", ExtractWrod(input, word)));
    }

    static string[] ExtractWrod(string input, string word)
    {
        string[] splittext = input.Split('.');

        List<string> result = new List<string>();

        foreach (var sentence in splittext)
        {
            if (sentence.Contains(String.Format(" {0} ", word)))
            {
                result.Add(sentence.Trim() + '.');
            }
        }

        return result.ToArray();
    }
}