/* Write a program that finds the most frequent number in an array.
 */
using System;

class FrequentNumber
{
    static void Main()
    {
        int N = 5;
        Console.WriteLine("Enter array with {0} elements: ", N);

        int[]array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int currentNumber = 0;
        int count = 0;
        int currentCount = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentCount++;

                if (currentCount > count)
                {
                    currentNumber = array[i];
                    count = currentCount;
                }
            }
            else
            {
                currentCount = 1;
            }


        }

        if (count == 0)
        {
            Console.WriteLine("All numbers are found only once");
        }
        else
        {
            Console.WriteLine("The result: ");
            Console.WriteLine("{0} ({1} times)", currentNumber, count);
        }
    }
}

