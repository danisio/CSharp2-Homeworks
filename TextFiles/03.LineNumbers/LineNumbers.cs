/* Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
 */
using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main()
    {
        string path = @"..\..\test.txt";
        StreamReader reader = new StreamReader(path);

        path = @"..\..\newFile.txt";
        StreamWriter writer = new StreamWriter(path);

        using (writer)
        {
            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("\nLine {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
        Console.WriteLine("File is written!");

        Console.WriteLine("The result:\n" + File.ReadAllText(path));
    }
}

