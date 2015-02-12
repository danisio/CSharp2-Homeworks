/* Extend the previous program to support also subtraction and multiplication of polynomials.
 */
using System;

class SubtractingPolynomials
{
    static void Main()
    {
        Console.WriteLine("Enter two polynomials on the next 2 lines:");
        string firstPol = Console.ReadLine();
        string secondPol = Console.ReadLine();

        Console.WriteLine(@"Enter your choise:
Add polynomials           --> 1
Subtract polynomials      --> 2
Multiplicate polynomials  --> 3
");
        int choise = int.Parse(Console.ReadLine());

        if (choise == 1)
        {
            AddPolynoms(firstPol, secondPol);
        }
        else if (choise == 2)
        {
            SubtractPolynoms(firstPol, secondPol);
        }
        else
        {
            MultiplicatePolynoms(firstPol, secondPol);
        }
    }

    static void MultiplicatePolynoms(string firstPol, string secondPol)
    {
        int[] mult = new int[(firstPol.Length) * (secondPol.Length) + 1];
        int pow = 0;
        for (int i = 0; i < firstPol.Length; i++)
        {
            for (int j = 0; j < secondPol.Length; j++)
            {
                pow = i + j;
                mult[pow] += (firstPol[i] - '0') * (secondPol[j] - '0');
            }
        }

        PrintResult(mult);
    }


    static void SubtractPolynoms(string firstPol, string secondPol)
    {
        int resultLength;
        int indexOut;
        string temp;
        if (firstPol.Length >= secondPol.Length)
        {
            resultLength = firstPol.Length;
            indexOut = secondPol.Length;
            temp = firstPol;
        }
        else
        {
            resultLength = secondPol.Length;
            indexOut = firstPol.Length;
            temp = secondPol;
        }

        int[] result = new int[resultLength];

        for (int i = 0; i < indexOut; i++)
        {
            result[i] = (firstPol[i] - '0') - (secondPol[i] - '0');
        }

        for (int j = indexOut; j < result.Length; j++)
        {
            result[j] = (temp[j] - '0');
        }
        PrintResult(result);
    }

    static void AddPolynoms(string firstPol, string secondPol)
    {
        int resultLength;
        int indexOut;
        string temp;
        if (firstPol.Length >= secondPol.Length)
        {
            resultLength = firstPol.Length;
            indexOut = secondPol.Length;
            temp = firstPol;
        }
        else
        {
            resultLength = secondPol.Length;
            indexOut = firstPol.Length;
            temp = secondPol;
        }

        int[] result = new int[resultLength];

        for (int i = 0; i < indexOut; i++)
        {
            result[i] = (firstPol[i] - '0') + (secondPol[i] - '0');
        }

        for (int j = indexOut; j < result.Length; j++)
        {
            result[j] = (temp[j] - '0');
        }
        PrintResult(result);
    }

    static void PrintResult(int[] pol)
    {
        for (int i = pol.Length - 1; i > 0; i--)
        {
            if (pol[i] != 0)
                Console.Write("{0}*x^{1} + ", pol[i], i);
        }
        Console.WriteLine(pol[0]);
    }
}

