/* Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
 */
using System;
using System.IO;

class MaxAreaSum
{
    static void Main()
    {
        string file = @"..\..\test.txt";
        StreamReader reader = new StreamReader(file);

        using (reader)
        {
            string line = reader.ReadLine();
            int size = int.Parse(line);
            int[,] matrix = new int[size, size];

            line = reader.ReadLine();
            while (line != null)
            {
                string[] numbers;
                for (int row = 0; row < size; row++)
                {
                    numbers = line.Split(' ');
                    for (int col = 0; col < size; col++)
                    {
                        matrix[row, col] = int.Parse(numbers[col]);
                    }

                    line = reader.ReadLine();
                }
            }

            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] +
                               matrix[row + 1, col] + matrix[row + 1, col + 1];
                    
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }

            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            using (writer)
            {
                writer.WriteLine(bestSum.ToString());
            }
            Console.WriteLine("The file is written!");
        }
    }
}

