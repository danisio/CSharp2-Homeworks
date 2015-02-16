/* Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 */
using System;
using System.Net;

class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL: ");      //http://telerikacademy.com/Courses/Courses/Details/212
        string inputURL = Console.ReadLine();

        try
        {
            Uri uri = new Uri(inputURL);
            string protocol = uri.Scheme;
            string server = uri.Host;
            string resource = uri.AbsolutePath;

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server]   = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }

        catch(UriFormatException)
        {
            Console.WriteLine("Invalid Path!");
        }
        catch (ArgumentNullException ex1)
        {
            Console.WriteLine(ex1.Message);
        }
        catch (NotSupportedException ex2)
        {
            Console.WriteLine(ex2.Message);
        }

    }
}