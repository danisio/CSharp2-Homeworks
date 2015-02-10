/* Problem 6. Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        Console.WriteLine("Enter {0} elements: ", N);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());

        if (N < K)
        {
            Console.WriteLine("Sorry, but N<K! ");
            return;
        }

        int sum = 0;

        Array.Sort(array);
        Array.Reverse(array);

        for (int i = 0; i < K; i++)
        {
            sum += array[i];
        }
        Console.Write("The sum is: " + sum);
        Console.WriteLine();
    }
}

