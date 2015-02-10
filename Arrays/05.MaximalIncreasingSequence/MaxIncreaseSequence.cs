/* Problem 5. Write a program that finds the maximal increasing sequence in an array
 */

using System;

class MaxIncreaseSequence
{
    static void Main()
    {
        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        Console.WriteLine("Enter the array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentCount = 1;
        int bestCount = 0;
        int start = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }
            if (currentCount > bestCount)
            {
                bestCount = currentCount;
                start = i + 1 - bestCount;
            }
        }    

        if (bestCount == 1)
        {
            start = 0;
        }

        Console.WriteLine();
        Console.WriteLine("The maximal sequence is: {0}", bestCount);
        for (int i = start; i < start + bestCount; i++)
        {
            if (i == start+bestCount-1)
            {
                Console.Write("{0}", array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }
        Console.WriteLine();
        //Main();
    }
}

