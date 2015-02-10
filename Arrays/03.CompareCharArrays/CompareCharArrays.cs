/* Problem 3. Compare char arrays
Write a program that compares two `char` arrays lexicographically (letter by letter).
 */
using System;
using System.Text;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter length of Arrays 1: ");
        int n = int.Parse(Console.ReadLine());
        char[] array1 = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("element [{0}]: ", i);
            array1[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.Write("Enter length of Arrays 2: ");
        n = int.Parse(Console.ReadLine());
        char[] array2 = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("element [{0}]: ", i);
            array2[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        bool first = false;
        bool second = false;
        int lenght = Math.Min(array1.Length, array2.Length);

        for (int i = 0; i < lenght; i++)
        {
            if (array1[i] < array2[i])
            {
                first = true;
                break;
            }
            else if (array2[i] < array1[i])
            {
                second = true;
                break;
            }
            else
            {
                if (i == lenght - 1)
                {
                    if (array1.Length < array2.Length)
                    {
                        first = true;
                    }
                    else if (array2.Length < array1.Length)
                    {
                        second = true;
                    }

                }
            }
        }

        if (first)
        {
            Console.WriteLine("Array 1 is before Array 2");
        }
        else if (second)
        {
            Console.WriteLine("Array 2 is before Array 1");
        }
        else
        {
            Console.WriteLine("Arrays are equal");
        }
    }
}

