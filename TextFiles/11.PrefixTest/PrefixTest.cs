/* Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
 */
using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        string path = @"..\..\test.txt";
        StreamReader reader = new StreamReader(path);

        Console.WriteLine("File before fixing:\n" + File.ReadAllText(path));

        path = @"..\..\result.txt";
        StreamWriter writer = new StreamWriter(path);

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, @"\btest\S*", String.Empty).Trim();
                    writer.Write(line);
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("File is written!");
        Console.WriteLine("\nThe result:\n" + File.ReadAllText(path));
    }
}

