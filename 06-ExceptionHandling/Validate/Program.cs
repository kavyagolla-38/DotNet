using System;

class VProgram
{
    static void Main()
    {
        Console.Write("Enter First Name: ");
        string first = Console.ReadLine() ?? "";

        Console.Write("Enter Last Name: ");
        string last = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last))
        {
            Console.WriteLine("FirstName and LastName should not be empty.");
        }
        else if (!IsAlphabet(first) || !IsAlphabet(last))
        {
            Console.WriteLine("Only alphabets are allowed.");
        }
        else
        {
            Console.WriteLine("Valid Name");
        }
    }

    static bool IsAlphabet(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLetter(c))
                return false;
        }
        return true;
    }
}