/* Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
 */
using System;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        //Console.WriteLine("Enter text: ");
        //string input = Console.ReadLine();
        string input = @"<html><head profile=http://telerikacademy.com lang=”bg-BG”><title>TEST TITLE</title></head><body>SOME TEXT</body></html>";

        bool insideTags = false;

        StringBuilder result = new StringBuilder(input.Length);

        result.Append(input);
        result.Replace("<title>", "Title: ");
        result.Replace("<body>", "\nBody: ");

        for (int i = 0; i < result.Capacity; i++)
        {
            if (result[i] == '<')
            {
                insideTags = true;
            }
            else if (result[i] == '>' && insideTags == true)
            {
                insideTags = false;
            }
            else if (insideTags == false)
            {
                Console.Write(result[i]);
            }
        }
        Console.WriteLine();
    }
}

