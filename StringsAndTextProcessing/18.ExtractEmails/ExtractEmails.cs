/* Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        //Console.WriteLine("Insert text: ");
        //string input = Console.ReadLine();
        string input = "Testing test@gmail.com and test2@gmail and тест3@gmail.com";
        string RegexPattern = @"\b[A-Z0-9._-]+@[A-Z0-9][A-Z0-9.-]{0,61}[A-Z0-9]\.[A-Z.]{2,6}\b";

        MatchCollection matches = Regex.Matches(input, RegexPattern, RegexOptions.IgnoreCase);

        string[] MatchList = new string[matches.Count];
        
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

