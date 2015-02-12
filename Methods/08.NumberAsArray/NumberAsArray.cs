/* Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
 */
using System;
using System.Collections.Generic;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        string num1 = Console.ReadLine();
        Console.Write("Enter number 2: ");
        string num2 = Console.ReadLine();
        
        int[] num1ToArray = new int[num1.Length];
        int[] num2ToArray = new int[num2.Length];
        
        ReverseNumber(num1, num1ToArray);
        ReverseNumber(num2, num2ToArray);
        
        int[] sum = new int[Math.Max(num1.Length, num2.Length) + 1];

        if (num1ToArray.Length > num2ToArray.Length)
        {
            Array.Copy(num2ToArray, sum, num2ToArray.Length);
            AddNumbers(sum, num1ToArray);
        }
        else
        {
            Array.Copy(num1ToArray, sum, num1ToArray.Length);
            AddNumbers(sum, num2ToArray);
        }

        Array.Reverse(sum);
        Console.Write("The result = ");
        for (int i=0; i < sum.Length; i++)
        {
            if (sum[0] == 0) i++;
            Console.Write(sum[i]);
        }
        Console.WriteLine();
    }

    static void AddNumbers(int[] sum, int[] numToArray)
    {
        int remainder = 0;

        for (int i = 0; i < numToArray.Length; i++)
        {
            if (sum[i] + numToArray[i] + remainder > 9)
            {
                sum[i] = ((sum[i] + numToArray[i] + remainder) % 10);
                remainder = 1;
            }
            else
            {
                sum[i] = ((sum[i] + numToArray[i] + remainder) % 10);
                remainder = 0;
            }
        }
        if (remainder == 1) sum[sum.Length - 1] = 1; 
    }

    static int[] ReverseNumber(string number, int[]array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(number[i] - '0');
        }

        Array.Reverse(array);
        return array;
    }
}

