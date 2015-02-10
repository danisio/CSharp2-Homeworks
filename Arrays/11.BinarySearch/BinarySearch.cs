/* Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */
using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements: ");
        int[] inputArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("element [{0}]: ", i);
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number to find: ");
        int number = int.Parse(Console.ReadLine());

        Array.Sort(inputArray);


        Console.WriteLine("Array after sorting: {0}", string.Join(",", inputArray));

        int result = BinSearch(inputArray, number, 0, inputArray.Length);
        if (result == -1)
        {
            Console.WriteLine("Number not found");
        }
        else
        {
            Console.WriteLine("Your number is at index {0}", result);
        }
    }

    private static int BinSearch(int[] inputArray, int number, int min, int max)
    {
        while (min <= max)
        {
            int middle = (min + max) / 2;
            if (number == inputArray[middle])
            {
                return middle;
            }
            else if (number < inputArray[middle])
            {
                max = middle - 1;
            }
            else
            {
                min = middle + 1;
            }
        }
        return -1;
    }
}


