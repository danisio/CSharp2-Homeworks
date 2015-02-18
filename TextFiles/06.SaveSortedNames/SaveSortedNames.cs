/* Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
 */
using System;
using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    static void Main()
    {
        string inputFile = @"..\..\input.txt";
        StreamReader reader = new StreamReader(inputFile);

        SortedSet<string> myList = new SortedSet<string>();

        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                myList.Add(line);
                line = reader.ReadLine();
            }
        }
        Console.WriteLine(string.Join("\n", myList));
       
        string outputFile = @"..\..\output.txt";
        StreamWriter writer = new StreamWriter(outputFile);

        using (writer)
        {
            foreach (var name in myList)
            {
                writer.WriteLine(name);
            }
        }
        Console.WriteLine("File is written!");
    }
}

