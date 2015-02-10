/* Problem 8. Maximal sum
Write a program that finds the sequence of maximal sum in given array.
 */
using System;

class MaximalSum
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

        int sum = 0;
        int currentSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            currentSum += array[i];

            if (currentSum > sum)
            {
                sum = currentSum;
            }
            else if (currentSum < 0)
            {
                currentSum = 0;
            }
        }

        Console.WriteLine(sum);
    }
}

