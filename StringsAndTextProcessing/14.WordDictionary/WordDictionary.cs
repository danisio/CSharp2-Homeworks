/* A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input	output
.NET	platform for applications from Microsoft
CLR	managed execution environment for .NET
namespace	hierarchical organization of classes
 */
using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> mydict = new Dictionary<string, string>();
        mydict.Add(".net", "platform for applications from Microsoft");
        mydict.Add("clr", "managed execution environment for .NET");
        mydict.Add("namespace", "hierarchical organization of classes");

        Console.Write("Enter a word: ");
        string input = Console.ReadLine().ToLower();
        
        if (mydict.ContainsKey(input))
        {
            Console.WriteLine("Translation: {0}", mydict[input]);
        }
        else
        {
            Console.WriteLine("Word not found!");
        }
    }
}
