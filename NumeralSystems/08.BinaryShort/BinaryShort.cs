/* Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/
using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter decimal number:");
        short input = short.Parse(Console.ReadLine());
        Console.WriteLine("Converted to binary = {0}", Convert.ToString(input, 2).PadLeft(16,'0'));
    }
}