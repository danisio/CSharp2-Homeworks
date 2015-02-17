/* You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        //Console.WriteLine("Enter text:");
        //string inputString = Console.ReadLine();
        string inputString = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(UpperSubString(inputString));
    }

    static string UpperSubString(string inputString)
    {
        string[] splittext = inputString.Split('<', '>');
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < splittext.Length; i++)
        {
            if (splittext[i] != "upcase" && splittext[i] != "/upcase")
            {
                result.Append(splittext[i]);
            }
            else if (splittext[i] == "upcase")
            {
                result.Append((splittext[i + 1].ToString().ToUpper()));
                i++;
            }
        }

        return result.ToString();
    }
}

