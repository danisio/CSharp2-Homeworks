/* Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
 */

using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

class DatesCanada
{
    static void Main()
    {
        //Console.WriteLine("Enter text: ");
        //string input = Console.ReadLine();
        string input = "This year The Academy started at 5.1.2015. Not 5/1/2015 or 5/1/2015";

        Regex dateRegex = new Regex(@"(0?[1-9]|[12][0-9]|3[01])[.](0?[1-9]|1[012])[.]\d{4}");

        MatchCollection dates = dateRegex.Matches(input);

        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        StringBuilder output = new StringBuilder();
        foreach (var date in dates)
        {
            output.AppendLine(date.ToString());
        }

        Console.WriteLine(output);
    }
}