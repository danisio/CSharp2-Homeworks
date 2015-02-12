/* Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 */
using System;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        InputArray(array);

        Console.Write("Enter a position to check: ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Your array: " + string.Join(" ", array));

        if (position >= length || position < 0)
        {
            Console.WriteLine("No such position in the array");
        }
        else
        {
            bool isLarger = CheckNumber(array, position);
            Console.WriteLine("Larger? -- > {0}", isLarger);
        }
    }

    static bool CheckNumber(int[] array, int position)
    {
        bool result;
        if (position == 0)
        {
            result = array[position] > array[position + 1];
        }
        else if (position == array.Length - 1)
        {
            result = array[position] > array[position-1];
        }
        else
        {
            result = array[position] > array[position + 1] && array[position] > array[position - 1];
        }
        return result;
    }

    static int[] InputArray(int[] array)
    {
        Console.WriteLine("Enter the array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}

