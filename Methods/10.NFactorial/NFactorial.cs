/* Write a program to calculate n! for each n in the range [1..100].
 */ 
using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0}! = {1}", i, NFactorial(i));
        }
    }

    static BigInteger NFactorial(int number)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }


}

