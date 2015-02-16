/* Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
 */
using System;
using System.Text;


class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string input = Console.ReadLine().ToLower();

        Console.WriteLine("Palindromes = {0}", FindPalindromes(input));
    }

    static string FindPalindromes(string input)
    {
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder palindromes = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            string currentWord = words[i];
            if (IsPalindrome(currentWord))
            {
                palindromes.Append(currentWord+", ");
            }
        }

        return palindromes.ToString();
    }

    static bool IsPalindrome(string currentWord)
    {
        for (int i = 0; i < currentWord.Length / 2; i++)
        {
            if (currentWord[i] != currentWord[currentWord.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}

