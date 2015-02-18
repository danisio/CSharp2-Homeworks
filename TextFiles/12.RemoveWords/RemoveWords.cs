/* Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Removstring
{
    static void Main()
    {
        string text = string.Empty;
        List<string> words = new List<string>();
        
        try
        {
            string path = @"..\..\words.txt";
            StreamReader reader = new StreamReader(path);

            using (reader)
            {
                text = reader.ReadToEnd();
            }

            Match wordMatch = Regex.Match(text, @"(?<word>\w+)", RegexOptions.IgnoreCase);
            while (wordMatch.Success)
            {
                words.Add(wordMatch.Groups["word"].Value);
                wordMatch = wordMatch.NextMatch();
            }

            path = @"..\..\test.txt";
            reader = new StreamReader(path);
            using (reader)
            {
                text = reader.ReadToEnd();
            }

            for (int i = 0; i < words.Count; i++)
            {
                text = text.Replace(words[i], "");
            }

            path = @"..\..\result.txt";
            StreamWriter writer = new StreamWriter(path);

            using (writer)
            {
                writer.Write(text);
            }
            Console.WriteLine("Complete task!");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FieldAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (OutOfMemoryException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


