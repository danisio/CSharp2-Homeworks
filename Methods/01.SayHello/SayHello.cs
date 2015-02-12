/* Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
 */ 
using System;

class SayHello
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        PrintName(name);
    }

    static void PrintName(string name)
    {
       
        Console.WriteLine("Hello {0}!", name);
    }
}

