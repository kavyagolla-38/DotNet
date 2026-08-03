using System;

class Person
{
    public string FirstName = "";
    public string LastName = "";
    public int Age;
}

class Program
{
    static void Main()
    {
        try
        {
            Person p = new Person();

            Console.Write("Enter First Name: ");
            p.FirstName = Console.ReadLine() ?? "";

            Console.Write("Enter Last Name: ");
            p.LastName = Console.ReadLine() ?? "";

            Console.Write("Enter Age: ");
            p.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Person Details");
            Console.WriteLine("--------------");
            Console.WriteLine("Name : " + p.FirstName + " " + p.LastName);
            Console.WriteLine("Age  : " + p.Age);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Age. Please enter an integer.");
        }
    }
}