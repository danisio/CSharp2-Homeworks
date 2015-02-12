/* Write a method that returns the last digit of given integer as an English word.
 */
using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit is {0}", EnglishWord(number));
    }

    static string EnglishWord(int number)
    {
        string[] words = {"ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE"};
        int lastDigit = number % 10;
       
        return words[lastDigit];
    }
}

