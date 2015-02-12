/* Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
 */
using System;

class SortingArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        Console.WriteLine("Enter the array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter index: ");
        int start = int.Parse(Console.ReadLine());

        int indexOfMaxElement = FindGreatestNumber(start, array.Length - 1, array);

        int greatest = array[indexOfMaxElement];
        Console.WriteLine("The greatest number after index {0} is = {1}", start, greatest);

        Console.WriteLine("Ascending order: {0}", string.Join(", ", AscendingOrder(array)));
        Console.WriteLine("Descending order: {0}", string.Join(", ", DescendingOrder(array)));
    }

    static int FindGreatestNumber(int start, int end, int[] array)
    {
        int result = array[start];
        int indexOfMaxElement = start;
        for (int i = start; i <= end; i++)
        {
            if (result < array[i])
            {
                result = array[i];
                indexOfMaxElement = i;
            }
        }
        return indexOfMaxElement;
    }

    static int[] AscendingOrder(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int indexOfMaxElement = FindGreatestNumber(0, i, array);
            Swap(i, indexOfMaxElement, array);
        }
        return array;
    }

    static int[] DescendingOrder(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int indexOfMaxElement = FindGreatestNumber(i, array.Length - 1, array);
            Swap(i, indexOfMaxElement, array);
        }
        return array;
    }

    static void Swap(int i, int j, int[] array)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

