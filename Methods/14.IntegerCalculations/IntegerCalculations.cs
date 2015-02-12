/* Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
 */
using System;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter some numbers separated by comma:");
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(',', ' ');

        int[] array = new int[inputNumbers.Length];
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            array[i] = int.Parse(inputNumbers[i]);
        }

        Console.WriteLine("The minimum --> {0}", Minimum(array));
        Console.WriteLine("The maximum --> {0}", Maximum(array));
        Console.WriteLine("The sum     --> {0}", Sum(array));
        Console.WriteLine("The average --> {0}", Average(array));
        Console.WriteLine("The product --> {0}", Product(array));
    }

    static int Minimum(int[] array)
    {
        Array.Sort(array);
        return array[0];
    }

    static int Maximum(int[] array)
    {
        Array.Sort(array);
        return array[array.Length - 1];
    }

    static int Product(int[] array)
    {
        int product = 1;
        foreach (int num in array)
        {
            product *= num;
        }
        return product;
    }

    static double Average(int[] array)
    {
        return (double)Sum(array) / array.Length;
    }

    static int Sum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }
}

