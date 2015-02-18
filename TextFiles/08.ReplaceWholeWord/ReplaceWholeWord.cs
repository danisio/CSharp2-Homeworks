/* Modify the solution of the previous problem to replace only whole words (not strings).
 */
using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
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
                string line = reader.ReadToEnd();
                line = Regex.Replace(line, @"\bstart\b", "finish", RegexOptions.IgnoreCase);

                writer.WriteLine(line);
            }
        }

        Console.WriteLine("\nFile is written!");
        Console.WriteLine("\nThe result:\n" + File.ReadAllText(path));
    }
}

