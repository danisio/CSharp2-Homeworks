/* Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
 */
using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine().ToLower();

        SortedDictionary<char, int> result = new SortedDictionary<char, int>();

        foreach (char letter in input)
        {
            if (result.ContainsKey(letter))
            {
                result[letter] += 1;

            }
            else if ('A' <= letter && letter <= 'z')
            {
                result[letter] = 1;
            }
        }

        foreach (var letter in result)
        {
            Console.WriteLine("letter {0} --> {1} times", letter.Key, letter.Value);
        }
    }
}