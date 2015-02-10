/* Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K = ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // input matrix
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("matrix[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine()); ;
        }

        Array.Sort(array);
        int maxValue = 0;
        for (int i = 0; i < n; i++)
        {

            if (array[i] <= k)
            {
                maxValue = array[i];
            }
        }

        Array.BinarySearch(array, maxValue);
        if (array[0] > k)
        {
            Console.WriteLine("No such number.");
        }
        else
        {
            Console.WriteLine("Max number <=K is {0}", maxValue);
        }
    }
}