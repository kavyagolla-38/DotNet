using System;
class FifthProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter num1: ");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter num2: ");
        int num2=Convert.ToInt32(Console.ReadLine());
        int pre=++num1;
        Console.WriteLine("\n After pre increment:");
        Console.WriteLine("num1: " + num1);
        Console.WriteLine("Assigned value: " + pre);
        Console.Write("\nEnter num1 Again: ");
        num1=Convert.ToInt32(Console.ReadLine());
        int post=num1++;
        Console.WriteLine("\n After post increment:");
        Console.WriteLine("num1: " + num1);
        Console.WriteLine("Assigned value: " + post);
        Console.WriteLine("\n Swapping values...");
        int temp=num1;
        num1=num2;
        num2=temp;
        Console.WriteLine("num1: " + num1);
        Console.WriteLine("num2: " + num2);
    }
}