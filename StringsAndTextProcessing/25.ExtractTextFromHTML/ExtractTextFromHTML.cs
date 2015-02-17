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

        StringBuilder my = new StringBuilder(input.Length);

        my.Append(input);
        my.Replace("<title>", "Title: ");
        my.Replace("<body>", "\nBody: ");

        for (int i = 0; i < my.Capacity; i++)
        {
            if (my[i] == '<')
            {
                insideTags = true;
            }
            else if (my[i] == '>' && insideTags == true)
            {
                insideTags = false;
            }
            else if (insideTags == false)
            {
                Console.Write(my[i]);
            }
        }
        Console.WriteLine();
    }
}

