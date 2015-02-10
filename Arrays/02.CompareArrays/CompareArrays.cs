/* Problem 2. Compare arrays
Write a program that reads two `integer` arrays from the console and compares them element by element.
 */
using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter length of Arrays: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Array 1: ");
        int[] array1 = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("element [{0}]: ", i);
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Enter Array 2: ");
        int[] array2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("element [{0}]: ", i);
            array2[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Elements in position [{0}] ", i);
            Console.WriteLine("are equal: {0}", array1[i].Equals(array2[i]));
        }

        Console.WriteLine();
    }
}

