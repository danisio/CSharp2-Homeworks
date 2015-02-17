/* Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:
Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
 */
using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter first date in format DD.MM.YYYY: ");
        string firstDate = Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(firstDate, "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.Write("Enter second date in format DD.MM.YYYY: ");
        string secondDate = Console.ReadLine();
        DateTime endDate = DateTime.ParseExact(secondDate, "d.M.yyyy", CultureInfo.InvariantCulture);
        
        int counter = (endDate - startDate).Days;
        Console.WriteLine("Distance = {0}", Math.Abs(counter));
    }
}

