/* Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
 */
using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter text");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        string converted;
        
        for (int i = 0; i < input.Length; i++)
        {
            converted = string.Format(@"\u{0:x4}", (int)input[i]);
            result.Append(converted);
        }

        Console.WriteLine(result);

    }
}

