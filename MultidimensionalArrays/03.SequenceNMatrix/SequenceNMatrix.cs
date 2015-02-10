/* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
 */
using System;

class SequenceMatrix
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M = ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // input matrix
        string[,] matrix = new string[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                string element = Console.ReadLine();
                matrix[row, col] = element;
            }
        }

        int maxLength = 1;
        string direction = "none";
        string foundElement = "";

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                string currentElement = matrix[i, j];
                int currentRow = i + 1;

                // check vertically
                int currentLength = 1;
                while (currentRow < matrix.GetLength(0))
                {
                    if (currentElement == matrix[currentRow, j])
                    {
                        currentLength++;
                        currentRow++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxLength)
                {
                    foundElement = matrix[i, j];
                    direction = "vertical";
                    maxLength = currentLength;
                }

                //check horizontally
                currentLength = 1;
                int colSequence = j + 1;
                while (colSequence < matrix.GetLength(1))
                {
                    if (currentElement == matrix[i, colSequence])
                    {
                        currentLength++;
                        colSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxLength)
                {
                    foundElement = matrix[i, j];
                    direction = "horizontal";
                    maxLength = currentLength;
                }

                //check diagonally
                currentLength = 1;
                int diagonalX = i + 1;
                int diagonalY = j + 1;
                while (diagonalX < matrix.GetLength(0) && diagonalY < matrix.GetLength(1))
                {
                    if (currentElement == matrix[diagonalX, diagonalY])
                    {
                        currentLength++;
                        diagonalX++;
                        diagonalY++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxLength)
                {
                    foundElement = matrix[i, j];
                    direction = "diagonal";
                    maxLength = currentLength;
                }

                currentLength = 1;
                diagonalX = i + 1;
                diagonalY = j - 1;
                while (diagonalX < matrix.GetLength(0) && diagonalY >= 0)
                {
                    if (currentElement == matrix[diagonalX, diagonalY])
                    {
                        currentLength++;
                        diagonalX++;
                        diagonalY--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxLength)
                {
                    foundElement = matrix[i, j];
                    direction = "diagonal";
                    maxLength = currentLength;
                }
            }
        }

        //output matrix
        Console.WriteLine("\nMatrix:");
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }

        if (direction == "none")
        {
            Console.WriteLine("No sequences");
        }
        else
        {
            Console.WriteLine("\nThe longest sequence:\n{0} times \n{1} \nstring = {2}", maxLength, direction, foundElement);
        }
    }
}
