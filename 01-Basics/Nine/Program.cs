using System;
class NineProgram
{
    static void Main(string[] args)
    {
        int[] a=new int[10];
        Console.WriteLine("Enter 10 elements:");
        for(int i=0;i<10;i++)
        {
            a[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<9;i++)
        {
            for(int j=i+1;j<10;j++)
            {
                if(a[i]<a[j])
                {
                    int temp=a[i];
                    a[i]=a[j];
                    a[j]=temp;
                }
            }
        }
        Console.WriteLine("The elements in descending order are:");
        for(int i=0;i<10;i++)
        {
            Console.Write(a[i]+" ");
        }
        int max=a[0];
        int min=a[9];
        int sum=0;
        for(int i=0;i<10;i++)
        {
            if(a[i]>max)
            {
                max=a[i];
            }
            if(a[i]<min)
            {
                min=a[i];
            }
            sum+=a[i];
        }
        Console.WriteLine("\nMaximum element: " + max);
        Console.WriteLine("Minimum element: " + min);
        Console.WriteLine("Sum of all elements: " + sum);
    }
}