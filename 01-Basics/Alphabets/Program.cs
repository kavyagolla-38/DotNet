
using System;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        List<char> AlphaList = new List<char>();
        List<char> DigitList = new List<char>();

        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? " ";

        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
            {
                AlphaList.Add(ch);
            }
            else if (char.IsDigit(ch))
            {
                DigitList.Add(ch);
            }
        }

        AlphaList.Sort();
        DigitList.Sort();

        Console.WriteLine("\nSorted Alphabets:");
        foreach (char ch in AlphaList)
        {
            Console.Write(ch + " ");
        }

        Console.WriteLine("\n\nSorted Digits:");
        foreach (char ch in DigitList)
        {
            Console.Write(ch + " ");
        }
    }
}