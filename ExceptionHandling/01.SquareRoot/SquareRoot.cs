/* Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
 */

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer number: ");
            uint input = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(input));
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}

