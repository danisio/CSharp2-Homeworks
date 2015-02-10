/* Problem 4. Write a program that finds the maximal sequence of equal elements in an array.
 */ 
using System;

class MaxSequence
{
    static void Main()
    {
        Console.WriteLine("Enter some symbols separated by comma");
        string input = Console.ReadLine();
        string[] array = input.Split(',', ' ');
        
        int currentCount = 1;
        int bestCount = 1;
        string currentSymbol = "";

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentCount++;
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    currentSymbol = array[i];
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        if (bestCount == 1)
        {
            currentSymbol = array[0];
        }

        Console.WriteLine();
        Console.WriteLine("The maximal sequence is: {0}", bestCount);
        for (int i = 0; i < bestCount; i++)
        {
            if (i == bestCount-1)
            {
                Console.Write("{0}", currentSymbol);
            }
            else
            {
                Console.Write("{0}, ", currentSymbol);
            }
        }
        Console.WriteLine();
    }
}