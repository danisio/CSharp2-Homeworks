/* Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */
using System;
using System.Globalization;
using System.Threading;

class DateInBulgarian
{
    static void Main()
    {
        Console.Write("Enter date in format DD.MM.YYYY hh:mm:ss -->");
        string inputDate = Console.ReadLine();
        DateTime formattedDate = DateTime.ParseExact(inputDate, "d.M.yyyy H:m:s", CultureInfo.InvariantCulture);

        formattedDate = formattedDate.AddHours(6).AddMinutes(30);

        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.WriteLine(formattedDate.ToString("dd.MM.yyyy (dddd) H:mm:ss"));
    }
}

