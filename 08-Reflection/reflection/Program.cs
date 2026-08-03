using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.Write("Enter Assembly Path: ");
        string path = Console.ReadLine() ??" ";

        Assembly asm = Assembly.LoadFrom(path);

        Console.WriteLine("Assembly Name : " + asm.FullName);

        foreach (Module module in asm.GetModules())
        {
            Console.WriteLine("\nModule : " + module.Name);

            foreach (Type type in module.GetTypes())
            {
                Console.WriteLine("\nClass : " + type.Name);

                Console.WriteLine("Constructors");
                foreach (ConstructorInfo c in type.GetConstructors())
                {
                    Console.WriteLine(c);
                }

                Console.WriteLine("\nProperties");
                foreach (PropertyInfo p in type.GetProperties())
                {
                    Console.WriteLine(p.PropertyType.Name + " " + p.Name);
                }

                Console.WriteLine("\nMethods");
                foreach (MethodInfo m in type.GetMethods())
                {
                    Console.WriteLine(m.Name);

                    foreach (ParameterInfo par in m.GetParameters())
                    {
                        Console.WriteLine("   Parameter : " + par.Name + " : " + par.ParameterType.Name);
                    }
                }
            }
        }
    }
}