/* Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
 */
using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string file1 = @"..\..\test1.txt";
        string file2 = @"..\..\test2.txt";

        StreamReader readerFirstFile = new StreamReader(file1);
        StreamReader readerSecFile = new StreamReader(file2);

        int counterSame = 0;
        int counterDiff = 0;

        using (readerFirstFile)
        {
            using (readerSecFile)
            {
                string lineFirstFile = readerFirstFile.ReadLine();
                while (lineFirstFile != null)
                {
                    string lineSecFile = readerSecFile.ReadLine();
                    if (lineFirstFile.CompareTo(lineSecFile) == 0)
                    {
                        counterSame++;
                    }
                    else
                    {
                        counterDiff++;
                    }

                    lineFirstFile = readerFirstFile.ReadLine();
                }
            }
        }
        Console.WriteLine("The Result:");
        Console.WriteLine("Same lines = {0}", counterSame);
        Console.WriteLine("Different = {0}", counterDiff);
    }
}

