using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string:");
        string str=Console.ReadLine() ?? "";
        string res="";
            foreach (char ch in str)
            {
                char newChar = (char)(ch + 1);
                if (char.IsUpper(newChar))
                {
                    newChar=char.ToLower(newChar);
                }
                else if(char.IsLower(newChar))
                {
                    newChar=char.ToUpper(newChar);
                }
                res += newChar;
            }
        
        Console.WriteLine("The transformed string is: " + res);
    }
}