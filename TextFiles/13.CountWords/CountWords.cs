using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordOccurrences
{
    static Dictionary<string, int> wordOccurs = new Dictionary<string, int>();

    static void Main()
    {
        try
        {
            string pathText = @"..\..\test.txt";
            string pathWords = @"..\..\words.txt";
            string pathResult = @"..\..\result.txt";

            SplitWords(pathWords);
            GetWordOccurs(pathText, pathResult);
        }
        catch (DriveNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (EndOfStreamException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void SplitWords(string pathWords)
    {
        using (StreamReader reader = new StreamReader(pathWords))
        {
            while (!reader.EndOfStream)
            {
                string[] tokens = reader.ReadLine().Split(new char[] { ' ', ',', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tokens.Length; i++)
                    if (!wordOccurs.ContainsKey(tokens[i])) wordOccurs.Add(tokens[i], 0);
            }
        }
    }

    static void GetWordOccurs(string pathText, string pathResult)
    {
        string text = string.Empty;

        using (StreamWriter result = new StreamWriter(pathResult))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                text = reader.ReadToEnd();

                for (int i = 0; i < wordOccurs.Count; i++)
                {
                    KeyValuePair<string, int> word = wordOccurs.ElementAt(i);
                    int index = text.IndexOf(word.Key);

                    while (index != -1)
                    {
                        wordOccurs[word.Key]++;
                        index = text.IndexOf(word.Key, index + 1);
                    }
                }
            }

            foreach (KeyValuePair<string, int> word in wordOccurs.OrderByDescending(key => key.Value))
            {
                result.WriteLine(word.Key + " -> " + word.Value + " time(s).");
            }
            Console.WriteLine("The file is written!");
        }
    }
}