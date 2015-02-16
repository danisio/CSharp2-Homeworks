/* Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */
using System;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter words: ");
        string input = Console.ReadLine();

        string[] inputToString = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(inputToString);

        Console.WriteLine(string.Join(", ", inputToString));
    }
}

