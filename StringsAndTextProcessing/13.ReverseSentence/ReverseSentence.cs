/* Write a program that reverses the words in given sentence.
 */
using System;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string[] inputToArr = input.Split(' ');
        string[] inputToArrWithoutPunct = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(inputToArrWithoutPunct);

        string firstWord = String.Empty;
        string secondWord = String.Empty;

        for (int i = 0; i < inputToArr.Length; i++)
        {
            if (String.Equals(inputToArr[i], inputToArrWithoutPunct[inputToArr.Length - i - 1])) //both words don't have punct.
            { 
                Console.Write(inputToArrWithoutPunct[i] + " ");
            }
            else
            {
                firstWord = inputToArrWithoutPunct[inputToArr.Length - i - 1];
                secondWord = inputToArr[i];
                Console.Write(inputToArrWithoutPunct[i] + secondWord.Replace(firstWord, "") + " ");
            }
        }
        Console.WriteLine();
    }
}
