/* Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
 */
using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string input = Console.ReadLine().ToLower();

        string[] inputToArray = input.Split(new char[] { ' ', ',', '.', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
       
        SortedDictionary<string, int> result = new SortedDictionary<string, int>();

        foreach (var word in inputToArray)
        {
            if (result.ContainsKey(word))
            {
                result[word] += 1;
            }
            else
            {
                result[word] = 1;
            }
        }

        foreach (var word in result)
        {
            Console.WriteLine("word {0, -15} --> {1} times", word.Key.ToUpper(), word.Value);
        }
    }
}

