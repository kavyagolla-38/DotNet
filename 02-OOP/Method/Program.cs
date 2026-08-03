using System;

class MyMath
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Subtract(int a, int b, int c)
    {
        return a - b - c;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Divide(int a, int b, int c)
    {
        return a / b / c;
    }
}


class MethodProgram
{
    static void Main()
    {
        MyMath obj = new MyMath();

        Console.WriteLine(obj.Add(10, 20));
        Console.WriteLine(obj.Add(10, 20, 30));

        Console.WriteLine(obj.Subtract(30, 10));
        Console.WriteLine(obj.Subtract(50, 10, 5));

        Console.WriteLine(obj.Multiply(5, 4));
        Console.WriteLine(obj.Multiply(2, 3, 4));

        Console.WriteLine(obj.Divide(20, 5));
        Console.WriteLine(obj.Divide(100, 5, 2));
    }
}