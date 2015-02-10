using System;

class LongestSequenceOfEqualStringInMatrix
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());
        
        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("array[{0},{1}]: ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }
        int maxSequenceXIndex = 0;
        int maxSequenceYIndex = 0;
        int maxSequenceLength = 1;
        
        string direction = "none";
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                string elementToCheck = matrix[i, j];
                int currentLength = 1;
                int rowSequence = i + 1;
                while (rowSequence < n)
                {
                    if (elementToCheck == matrix[rowSequence, j])
                    {
                        currentLength++;
                        rowSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxSequenceLength)
                {
                    maxSequenceXIndex = i;
                    maxSequenceYIndex = j;
                    direction = "row";
                    maxSequenceLength = currentLength;
                }

                currentLength = 1;
                int lineSequence = j + 1;
                while (lineSequence < m)
                {
                    if (elementToCheck == matrix[i, lineSequence])
                    {
                        currentLength++;
                        lineSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxSequenceLength)
                {
                    maxSequenceXIndex = i;
                    maxSequenceYIndex = j;
                    direction = "line";
                    maxSequenceLength = currentLength;
                }

                currentLength = 1;
                int diagonalX = i + 1;
                int diagonalY = j + 1;
                while (diagonalX < n && diagonalY < m)
                {
                    if (elementToCheck == matrix[diagonalX, diagonalY])
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
                if (currentLength > maxSequenceLength)
                {
                    maxSequenceXIndex = i;
                    maxSequenceYIndex = j;
                    direction = "diagonal";
                    maxSequenceLength = currentLength;
                }
            }
        }
        if (direction == "none")
        {
            Console.WriteLine("No sequences");
        }
        else
        {
            for (int i = 0; i < maxSequenceLength; i++)
            {
                Console.Write(matrix[maxSequenceXIndex, maxSequenceYIndex] + " ");
            }
        }
    }
}
