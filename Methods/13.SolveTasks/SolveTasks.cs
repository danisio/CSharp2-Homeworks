/* Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods. Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data: The decimal number should be non-negative, the sequence should not be empty, a should not be equal to 0
 */
using System;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Please enter your choise:");
        Console.WriteLine("Reverse a number                        -->  press 1");
        Console.WriteLine("Calculates the average of a sequence    -->  press 2");
        Console.WriteLine("Solves a linear equation a * x + b = 0  -->  press 3");
        int choise = int.Parse(Console.ReadLine());
        while (choise < 1 || choise > 3)
        {
            Console.Write("Try again! ");
            choise = int.Parse(Console.ReadLine());
        }

        if (choise == 1)
        {
            ReverseNumber();
        }
        else if (choise == 2)
        {
            AverageOfSequence();
        }
        else
        {
            LinearEquation();
        }

    }

    private static void LinearEquation()
    {
        Console.Write("Enter A: ");
        int a = int.Parse(Console.ReadLine());
        while (a==0)
        {
            Console.WriteLine("\"A\" should be bigger than 0");
            a = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter B: ");
        int b = int.Parse(Console.ReadLine());

        double x = -b/(double)a;
        Console.WriteLine("The result --> x = {0}", x);

    }

    private static void AverageOfSequence()
    {
        Console.WriteLine("Enter some numbers, separated by comma: ");
        string input = Console.ReadLine();
        while (input == "")
        {
            Console.WriteLine("Please enter at least 1 number!");
            input = Console.ReadLine();
        }
        string[] inputNumbers = input.Split(',', ' ');

        double[] array = new double[inputNumbers.Length];
        double average = 0;
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            array[i] = int.Parse(inputNumbers[i]);
            average += array[i];
        }
        average /= array.Length;
        Console.WriteLine("The result --> {0}", average);
    }

    private static void ReverseNumber()
    {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        while (number[0]=='-')
        {
            Console.WriteLine("Please enter positive number!");
            number = Console.ReadLine();
        }
        char[] reversedNumber = number.ToCharArray();
        
        Array.Reverse(reversedNumber);

        Console.WriteLine("The result --> {0}", string.Join("", reversedNumber));
    }
}

