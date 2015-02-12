/* Write a method that reverses the digits of given decimal number.
 */ 
using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        Console.WriteLine("Reversed number: {0}", string.Join("",ReverseNumber(number)));
    }

    static char[] ReverseNumber(string number)
    {
        char[] reversedNumber = number.ToCharArray();
       
        Array.Reverse(reversedNumber);

        return reversedNumber;
        //for (int i = reversedNumber.Length-1; i >= 0; i--)
        //{
        //    Console.Write(reversedNumber[i]);
        //}
    }
}

