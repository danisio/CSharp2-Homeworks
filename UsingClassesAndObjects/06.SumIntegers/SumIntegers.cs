/* You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
 */ 

using System;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter some numbers separated by space: ");
        string[] input = Console.ReadLine().TrimEnd().Split(' ');
        int sum = 0;
        
        foreach (string num in input)
        {
            sum += int.Parse(num);
        }
        Console.WriteLine("The sum = {0}", sum);
    }
}

