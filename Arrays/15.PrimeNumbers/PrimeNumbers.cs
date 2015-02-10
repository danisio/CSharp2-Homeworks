/* Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */
using System;
using System.Text;

class PrimeNumbers
{
    static void Main()
    {
        int max = 10000000;
        StringBuilder primeNumbers = new StringBuilder();

        bool[] is_prime = new bool[max + 1];

        for (int i = 2; i <= max; i++)
        {
            is_prime[i] = true;
        }

        for (int i = 2; i <= max; i++)
        {
            if (is_prime[i])
            {
                for (int j = i * 2; j <= max; j += i)
                {
                    is_prime[j] = false;
                }
            }
        }

        for (int i = 2; i <= max; i++)
        {
            if (is_prime[i])
            {
                primeNumbers.Append(i).Append(" ");
            }
        }
       
        Console.WriteLine(primeNumbers);
    }
}