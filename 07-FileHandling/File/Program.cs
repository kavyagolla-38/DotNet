using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "Student.txt";

        StreamWriter sw = new StreamWriter(path);

        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter Roll Number: ");
        string roll = Console.ReadLine() ?? "";

        sw.WriteLine("Name : " + name);
        sw.WriteLine("Roll No : " + roll);

        sw.Close();

        Console.WriteLine("File Created Successfully.");
    }
}