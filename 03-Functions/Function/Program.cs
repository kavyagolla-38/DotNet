using System;

class Area
{
    public double CalculateArea(double radius)
    {
        return 3.14 * radius * radius;
    }
    public int CalculateArea(int length, int breadth)
    {
        return length * breadth;
    }
    public double CalculateArea(double b, double h)
    {
        return 0.5 * b * h;
    }
}

class Program
{
    static void Main()
    {
        Area obj = new Area();

        Console.Write("Enter Radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Length: ");
        int l = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Breadth: ");
        int br = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Base: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Area of Circle = " + obj.CalculateArea(r));
        Console.WriteLine("Area of Rectangle = " + obj.CalculateArea(l, br));
        Console.WriteLine("Area of Triangle = " + obj.CalculateArea(b, h));
    }
}