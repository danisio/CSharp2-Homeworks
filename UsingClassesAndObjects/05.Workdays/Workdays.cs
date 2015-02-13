/* Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */
using System;
using System.Globalization;
using System.Linq;

class WorkDays
{
    static void Main()
    {
        Console.Write("Enter date in format DD.MM.YYYY: ");
        string inputDate = Console.ReadLine();
        DateTime endDate = DateTime.ParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Number of workdays is = {0}", CalculateWorkDays(endDate));
    }

    static int CalculateWorkDays(DateTime endDate)
    {
        DateTime today = DateTime.Now.Date;
        int workdays = 0;
        while (today.Date < endDate)
        {
            if (today.DayOfWeek != DayOfWeek.Saturday &&
                today.DayOfWeek != DayOfWeek.Sunday &&
                !holidays.Contains(today))
            {
                workdays++;
            }
            today = today.AddDays(1);
        }
        return workdays;
    }

    static DateTime[] holidays = 
    { 
          new DateTime(2015, 3, 3),
          new DateTime(2015, 4, 10),
          new DateTime(2015, 4, 13),
          new DateTime(2015, 5, 1),
          new DateTime(2015, 5, 6),
          new DateTime(2015, 9, 22),
          new DateTime(2015, 12, 24),
          new DateTime(2015, 12, 25),
          new DateTime(2015, 12, 31)
    };
}

