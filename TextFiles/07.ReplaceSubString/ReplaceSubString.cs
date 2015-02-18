/* Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
 */
using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubString
{
    static void Main()
    {
        string path = @"..\..\test.txt";
        StreamReader reader = new StreamReader(path);

        Console.WriteLine("File before fixing:\n" + File.ReadAllText(path));

        path = @"..\..\testFixed.txt";
        StreamWriter writer = new StreamWriter(path);

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, "start", "finish", RegexOptions.IgnoreCase);

                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

        Console.WriteLine("\nFile is written!");

        Console.WriteLine("\nThe result:\n" + File.ReadAllText(path));
    }
}

