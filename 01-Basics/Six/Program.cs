using System;
class Program
{
    static void Main(string[] args)
    {
        string username="admin";
        string password="admin123";
        for(int i=1;i<=3;i++)
        {
            Console.Write("Enter username: ");
            string User=Console.ReadLine() ?? "";
            Console.Write("Enter password: ");
            string Pass=Console.ReadLine() ?? "";
            if(User==username && Pass==password)
            {
                Console.WriteLine("Login successful!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
        }
                    Console.WriteLine("Maximum login attempts exceeded. Exiting program.");
            
    }
}