/* Write a program that reads a string, reverses it and prints the result at the console.
 */
using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        StringBuilder reversedInput = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedInput.Append(input[i]);
        }

        Console.WriteLine("The reversed string = {0}", reversedInput.ToString());
    }
}