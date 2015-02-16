/* Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:
 */
    
using System;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Enter a HTML document:");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        result.Append(input);
  
        result.Replace("<a href=\"", "[URL=");
        result.Replace("\">", "]");
        result.Replace("</a>", "[/URL]");

        Console.WriteLine(result);
    }
}

