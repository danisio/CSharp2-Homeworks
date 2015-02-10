/* Write a program that finds in given array of integers a sequence of given sum S (if present).
 */
using System;

class FindSumnInArray
{
    static void Main()
    {
        Console.WriteLine("Enter some numbers, separated by comma: ");
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(',', ' ');

        int[] array = new int[inputNumbers.Length];

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            array[i] = int.Parse(inputNumbers[i]);
        }

        Console.Write("Enter Sum to be found: ");
        int S = int.Parse(Console.ReadLine());

        int currentSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            currentSum = 0;
            for (int j = i; j >= 0; j--)
            {
                currentSum += array[j];
                if (currentSum == S)
                {
                    PrintArray(j, i, array);
                    return;
                }
            }
        }
        Console.WriteLine("No sequence");
    }

    static void PrintArray(int startIndex, int endIndex, int[] array)
    {
        Console.WriteLine("The result:");

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }

}

