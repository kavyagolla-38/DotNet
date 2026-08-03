using System;
class MyProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string:");
        string str=Console.ReadLine() ?? "";
        int alphabetCount = 0;
        int digitCount = 0;
        if(str!=null)
        {
            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    alphabetCount++;
                }
                else if(char.IsDigit(ch))
                {
                    digitCount++;
                }
            }
        }
        Console.WriteLine("The number of alphabets in the string is: " + alphabetCount);
        Console.WriteLine("The number of digits in the string is: " + digitCount);
    }
}