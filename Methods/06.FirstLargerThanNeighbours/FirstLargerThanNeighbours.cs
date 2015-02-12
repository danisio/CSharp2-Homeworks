/* Write a method that returns the index of the first element in array that is larger than its neighbours, or `-1`, if there’s no such element.
Use the method from the previous exercise.
 */

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        InputArray(array);

        Console.WriteLine("Your array: ");
        PrintArray(array);

        for (int i = 0; i < array.Length; i++)
        {
            if (CheckNumber(array, i))
            {
                Console.WriteLine("The index = {0}", i);
                break;
            }
            else if (i==array.Length-1)
            {
                Console.WriteLine(-1);
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int arr in array)
        {
            Console.Write(arr + " ");
        }
        Console.WriteLine();
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

    static bool CheckNumber(int[] array, int position)
    {
        bool result;
        if (position == 0)
        {
            result = array[position] > array[position + 1];
        }
        else if (position == array.Length - 1)
        {
            result = array[position] > array[position - 1];
        }
        else
        {
            result = array[position] > array[position + 1] && array[position] > array[position - 1];
        }
        return result;
    }
}