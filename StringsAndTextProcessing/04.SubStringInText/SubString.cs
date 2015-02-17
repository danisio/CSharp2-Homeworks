/* Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example: The target sub-string is "in". The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
The result is: 9
 */
        //string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

using System;
using System.Text.RegularExpressions;

class SubString
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string inputString = Console.ReadLine();
        Console.Write("Enter substring: ");
        string inputSubString = Console.ReadLine();

        inputString = inputString.ToLower();
        inputSubString = inputSubString.ToLower();

        Console.WriteLine("The result = {0}", CountSubStrings(inputString, inputSubString));
    }

    static int CountSubStrings(string inputString, string inputSubString)
    {
        int counter = 0;
        foreach (Match str in Regex.Matches(inputString, inputSubString))
        {
            counter++;
        }

        return counter;
    }
}

