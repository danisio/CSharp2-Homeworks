/* Write a program that reverses the words in given sentence.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class ReverseSentence
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input2 = Console.ReadLine();

        Reverse(input2);

        string[] input = input2.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(input);
        Console.WriteLine(string.Join(" ", input));
        char[] punc = ".,?!".ToCharArray();
        //string str = Console.ReadLine();
        string str = "hi, dani!";
        string strrev = "";

        foreach (var word in str.Split(' '))
        {
            string temp = "";
            foreach (var ch in word.ToCharArray())
            {
                if (Array.IndexOf(punc, ch) == -1)
                    temp = temp+ch;
                else
                    temp = ch+temp;
            }
            strrev = strrev + temp + " ";
        }
        Console.WriteLine(strrev);
        Console.ReadLine();
    }

    static string Reverse(string input2)
    {
        string[] input = input2.Split(' ');
        List<char> punctuation = new List<char>();
        StringBuilder reverse = new StringBuilder();
        //foreach (Match str in Regex.Matches(inputString, inputSubString))
        //{

        //}

        for (int i = 0; i < input.Length; i++)
        {

        }

        return reverse.ToString();
    }
}

