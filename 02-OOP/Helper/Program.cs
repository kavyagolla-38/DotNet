using System;
class RandomHelper
{
    static Random r=new Random();
    public static int RanInt(int min,int max)
    {
        return r.Next(min,max+1);
    }
    public static double RanDouble(double min,double max)
    {
        return min + (r.NextDouble() * (max - min));
    }
}
class HelperProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Random Integer: "+RandomHelper.RanInt(1,10));
        Console.WriteLine("Random Double: "+RandomHelper.RanDouble(1.0,10.0));
    }
}