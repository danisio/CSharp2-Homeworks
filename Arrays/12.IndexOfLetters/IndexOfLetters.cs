/* Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */
using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = Convert.ToChar(i + 65);
        }

        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        int length = word.Length;

        for (int i = 0; i < length; i++)
        {
            PrintWord(alphabet, word, i);
        }
    }

    static void PrintWord(char[] alphabet, string word, int index)
    {
        word = word.ToUpper();

        for (int i = 0; i < 26; i++) 
        {
            if (word[index]==alphabet[i])
            {
                Console.WriteLine("letter {0} --> index {1}", word[index], i);
                return;
            }
        }
    }
}
