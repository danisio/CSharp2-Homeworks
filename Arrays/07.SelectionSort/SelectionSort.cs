/* Problem 7. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */ 

using System;

class SelectionSort
{
    static void Main()
    {
        int N = 5;
        Console.WriteLine("Enter array with {0} elements: ", N);

        //input array
        int[]array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int length = array.Length;
        
        //Output before sorting
        Console.WriteLine("Before sorting");
        foreach (int item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
        
        // Sorting
        int temp = 0;

        for (int i = 0; i < length-1; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];

                    array[i] = array[j];

                    array[j] = temp;
                }
            }
        }
   
        //output after sorting
        Console.WriteLine("After sorting");
        foreach (int item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}

