/* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
 */
using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter file name along with its full path:"); //C:\WINDOWS\win.ini
        try
        {
            string file = File.ReadAllText(Console.ReadLine());
            Console.WriteLine(file);
        }
        catch (ArgumentException ex3)
        {
            Console.WriteLine(ex3.Message);
        }
        catch (FileNotFoundException ex1)
        {
            Console.WriteLine(ex1.Message);
        }
        catch (DirectoryNotFoundException ex2)
        {
            Console.WriteLine(ex2.Message);
        }
        catch (FileLoadException ex4)
        {
            Console.WriteLine(ex4.Message);
        }
        catch (PathTooLongException ex5)
        {
            Console.WriteLine(ex5.Message);
        }
        catch (IOException ex6)
        {
            Console.WriteLine(ex6.Message);
        }
        catch (UnauthorizedAccessException ex7)
        {
            Console.WriteLine(ex7.Message);
        }
        catch (NotSupportedException ex8)
        {
            Console.WriteLine(ex8.Message);
        }
    }
}

