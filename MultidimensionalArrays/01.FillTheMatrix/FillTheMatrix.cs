/* Write a program that fills and prints a matrix of size (n, n) as shown below:
 */
using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.WriteLine("Matrix A");
        MatrixA(matrix, n);
        PrintArray(matrix, n);
        
        Console.WriteLine("Matrix B");
        MatrixB(matrix, n);
        PrintArray(matrix, n);
        
        Console.WriteLine("Matrix C");
        MatrixC(matrix, n);
        PrintArray(matrix, n);

    }

    static int[,] MatrixC(int[,] matrix, int n)
    {
        int rows = 0;
        int cols = 0;
        int value = 1;

        //under the main diagonal
        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = value++;
            }
        }

        //over the main diagonal
        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = value++;
            }
        }
        return matrix;
    }

    static int[,] MatrixB(int[,] matrix, int n)
    {
        int index = 1;
        for (int rows = 0; rows < n; rows++)
        {
            if (rows % 2 == 0)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[cols, rows] = index++;
                }
            }
            else
            {
                for (int cols = n - 1; cols >= 0; cols--)
                {
                    matrix[cols, rows] = index++;
                }
            }
        }
        return matrix;
    }


    static int[,] MatrixA(int[,] matrix, int n)
    {
        int index = 1;
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                matrix[cols, rows] = index++;
            }
        }
        return matrix;
    }

    static void PrintArray(int[,] matrix, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}


