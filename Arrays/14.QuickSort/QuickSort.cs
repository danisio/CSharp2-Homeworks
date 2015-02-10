/* Write a program that sorts an array of strings using the Quick sort algorithm.
 */
using System;

class QuickSort
{
    static void Main()
    {
        Console.Write("Enter length: ");
        int n = int.Parse(Console.ReadLine());

        string[] input = new string[n];

        Console.WriteLine("Enter strings: ");

        for (int i = 0; i < input.Length; i++)
        {
            input[i] = Console.ReadLine();
        }

        Console.WriteLine("Your array: {0}", string.Join(", ", input));

        MyQuickSort(input, 0, input.Length - 1);

        Console.WriteLine("After sorting: {0}", string.Join(", ", input));
    }

    static void MyQuickSort(string[] array, int left, int right)
    {
        if (left >= right)
        {
            return; 
        }

        int i = left;
        int j = right;

        string pivot = array[(left + right) / 2];

        while (i <= j)
        {
            while (array[i].CompareTo(pivot) < 0)
            {
                i++;
            }
            while (array[j].CompareTo(pivot) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                string swap = array[i];
                array[i] = array[j];
                array[j] = swap;

                i++; j--;
            }
        }

        if (left < j)
        {
            MyQuickSort(array, left, j);
        }
        if (i < right)
        {
            MyQuickSort(array, i, right);
        }
    }
}

