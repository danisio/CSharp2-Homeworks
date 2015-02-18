/* Write a program that concatenates two text files into another text file.
 */
using System;
using System.IO;
using System.Text;

class ConcTextFiles
{
    static void Main()
    {
        string path = @"..\..\test.txt";
        StreamReader reader = new StreamReader(path);
        path = @"..\..\mergedfiles.txt";
        StreamWriter writer = new StreamWriter(path);

        using (writer)
        {
            using (reader)
            {
                string fileContents = reader.ReadToEnd();
                writer.Write(fileContents, false);
            }

            path = @"..\..\test2.txt";
            reader = new StreamReader(path);

            using (reader)
            {
                string fileContents = reader.ReadToEnd();
                writer.Write(fileContents, true);
            }
        }
        Console.WriteLine("File is written!");
    }
}

