/* Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:
x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
 */
using System;

class AddingPolynomials
{
    static void Main()
    {
        Console.WriteLine("Enter two polynomials on the next 2 lines:");
        string firstPol = Console.ReadLine();
        string secondPol = Console.ReadLine();

        AddPolynoms(firstPol, secondPol);
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

