using System;
class FourthProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string:");
        string str=Console.ReadLine() ?? "";
        char[] ch=str.ToCharArray();
        Array.Reverse(ch);
        Console.WriteLine("The reversed string is: " + new string(ch));
        Console.Write("Enter starting position:");
        int start=Convert.ToInt32(Console.ReadLine());
        if(start>=0 && start<str.Length)
        {
            Console.WriteLine("Substring: " + str.Substring(start));
        }
        else
        {
            Console.WriteLine("Invalid starting position.");
        }
        Console.Write("Enter character to replace:");
        char oldChar=Convert.ToChar(Console.ReadLine()??"");
        string newStr=str.Replace(oldChar,'*');
        Console.WriteLine("After replacement:"+ newStr);
        string copyStr=str;
        copyStr=copyStr.ToUpper();
        Console.WriteLine("Original string :"+ str);
        Console.WriteLine("Modified Copied string :"+ copyStr);
    }
        
}