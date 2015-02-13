/* Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
 */
using System;
using System.Net;

class Program
{
    static void Main()
    {
        try
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("https://telerikacademy.com/Content/Images/news-img01.png", "Ninja.png");
                Console.WriteLine("The picture is saved in the current directory!");
            }
        }
        catch (ArgumentNullException ex1)
        {
            Console.WriteLine(ex1.Message);
        }
        catch (WebException ex2)
        {
            Console.WriteLine(ex2.Message);
        }
        catch (NotSupportedException ex3)
        {
            Console.WriteLine(ex3.Message);
        }
    }
}

