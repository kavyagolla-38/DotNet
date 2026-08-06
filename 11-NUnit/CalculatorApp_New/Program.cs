using System;

class Programs
{
    static void Main()
    {
        Calculator1 cal = new Calculator1();

        Console.Write("Enter First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition = " + cal.Add(a, b));
        Console.WriteLine("Subtraction = " + cal.Subtract(a, b));
        Console.WriteLine("Multiplication = " + cal.Multiply(a, b));

        try
        {
            Console.WriteLine("Division = " + cal.Divide(a, b));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}