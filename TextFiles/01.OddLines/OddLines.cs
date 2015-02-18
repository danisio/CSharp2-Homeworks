/* Write a program that reads a text file and prints on the console its odd lines.
 */
using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        string path = @"..\..\test.txt";
        StreamReader reader = new StreamReader(path);

        using (reader)
        {
            int lineNumber = 1;
            string nextline = reader.ReadLine();
          
            while (nextline != null)
            {
                if (lineNumber%2 != 0)
                {
                    Console.WriteLine("line {0} --> {1}", lineNumber, nextline);
                }
                nextline = reader.ReadLine();
                lineNumber++;
            }
        }
    }
}

