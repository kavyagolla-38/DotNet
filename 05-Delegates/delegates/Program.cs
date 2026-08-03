using System;

public delegate void MathOperation(int a, int b);

class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    public void Divide(int a, int b)
    {
        if (b == 0)
            Console.WriteLine("Cannot divide by zero");
        else
            Console.WriteLine("Division = " + (a / b));
    }
}

class Program
{
    static void Main()
    {
        Calculator obj = new Calculator();

        MathOperation del;

        del = obj.Add;
        del(20,10);

        del = obj.Subtract;
        del(20,10);

        del = obj.Multiply;
        del(20,10);

        del = obj.Divide;
        del(20,10);
    }
}