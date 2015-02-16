/* Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
 */
using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string inputString = Console.ReadLine();
        Console.Write("Enter cipher: ");
        string cipher = Console.ReadLine();

        string encoded = Encode_Decode(inputString, cipher);
        string decoded = Encode_Decode(encoded, cipher);

        Console.WriteLine(encoded + Environment.NewLine + decoded);
    }

    static string Encode_Decode(string input, string cipher)
    {
        StringBuilder encoded = new StringBuilder();
       
        int firstInputLetter;
        int firstCipherLetter;
        
        for (int i = 0; i < input.Length; i++)
        {
            firstInputLetter = input[i];
            firstCipherLetter = cipher[i % cipher.Length];
            encoded.Append((char)(firstInputLetter ^ firstCipherLetter));
        }
        return encoded.ToString();
    }
}