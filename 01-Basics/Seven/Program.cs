using System;
class SevenProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 % 10 == num2)
        {
            Console.WriteLine("The second number is in unit place");
        }
        else if((num1/10) % 10 == num2)
        {
            Console.WriteLine("The second number is in tens place");
        }
        else if((num1/100) % 10 == num2)
        {
            Console.WriteLine("The second number is in hundreds place");
        }
        else if((num1/1000) % 10 == num2)
        {
            Console.WriteLine("The second number is in thousands place");
        }
        else
        {
            Console.WriteLine("Number not found ");
        }
    }
}