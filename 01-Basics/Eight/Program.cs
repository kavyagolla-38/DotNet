using System;

class EightProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the array elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int count = 0;

        foreach (int item in arr)
        {
            count++;
        }

        Console.WriteLine("Number of elements = " + count);
    }
}