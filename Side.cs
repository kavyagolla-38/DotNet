using System;
class Side
{
    static void Main(String[] args)
    {
        double side,area;
        Console.Write("Enter the side of the square: ");
        side = Convert.ToDouble(Console.ReadLine());
        area = side * side;
        Console.WriteLine("The area of the square is: " + area);
        Console.ReadLine();
    }
}