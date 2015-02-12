/* Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
 */
using System;

class AppearanceCount
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

        Console.Write("Enter number to check: ");
        int number = int.Parse(Console.ReadLine());
        
        int counter = CountNumbers(array, number);
        Console.WriteLine("Number {0} --> {1} times", number, counter);

    }

    static int CountNumbers(int[] array, int number)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num == number)
            {
                count++;
            }
        }
        return count;
    }
}





