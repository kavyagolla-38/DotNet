using System;

class FProgram
{
    static void Main()
    {S
        try
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter Mark1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Mark2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Mark3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total = " + (m1 + m2 + m3));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input! Please enter only integer values.");
        }
    }
}