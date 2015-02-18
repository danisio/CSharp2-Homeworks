/* Write a program that deletes from given text file all odd lines.
The result should be in the same file.
 */
using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        string path = @"..\..\test.txt";
        StreamReader reader = new StreamReader(path);
        StringBuilder temp = new StringBuilder();

        using (reader)
        {
            int lineNumber = 1;
            string nextline = reader.ReadLine();

            while (nextline != null)
            {
                if (lineNumber % 2 == 0)
                {
                    temp.AppendLine(nextline);
                }
                nextline = reader.ReadLine();
                lineNumber++;
            }
        }
        StreamWriter writer = new StreamWriter(path, true);
        using (writer)
        {
            writer.Write(Environment.NewLine + DateTime.Now + Environment.NewLine);
            writer.Write(temp.ToString());
            Console.WriteLine("File is written!");
        }
    }
}

