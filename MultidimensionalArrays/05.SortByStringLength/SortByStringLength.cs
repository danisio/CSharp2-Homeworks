/* You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
 */ 
using System;

class SortByStringLength
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine("Enter {0} strings:", n);
        
        string[] input = new string[n];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = Console.ReadLine();
           
        }

        Array.Sort(input, (x, y) => x.Length.CompareTo(y.Length));

        Console.WriteLine("Sorted array:");
        foreach (string element in input)
        {
            Console.WriteLine(element);
        }
    }
}

