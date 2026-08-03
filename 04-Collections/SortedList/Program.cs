using System;
using System.Collections.Generic;

class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeID { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        EmployeeName = name;
        EmployeeID = id;
        Salary = salary;
    }
}

class EmployeeDAL
{
    SortedList<int, Employee> employees = new SortedList<int, Employee>();

    public bool AddEmployee(Employee e)
    {
        if (!employees.ContainsKey(e.EmployeeID))
        {
            employees.Add(e.EmployeeID, e);
            return true;
        }
        return false;
    }

    public bool DeleteEmployee(int id)
    {
        return employees.Remove(id);
    }

    public string SearchEmployee(int id)
    {
        if (employees.ContainsKey(id))
            return employees[id].EmployeeName;

        return null ?? " ";  
    }

    public Employee[] GetAllEmployees()
    {
        Employee[] arr = new Employee[employees.Count];
        employees.Values.CopyTo(arr, 0);
        return arr;
    }
}

class Program
{
    static void Main()
    {
        EmployeeDAL obj = new EmployeeDAL();

        obj.AddEmployee(new Employee("Kavya",101,50000));
        obj.AddEmployee(new Employee("Rahul",103,60000));
        obj.AddEmployee(new Employee("Priya",102,55000));

        Console.WriteLine("Search Employee ID 102");
        Console.WriteLine(obj.SearchEmployee(102));

        Console.WriteLine("\nEmployee List");

        foreach(Employee e in obj.GetAllEmployees())
        {
            Console.WriteLine($"{e.EmployeeID} {e.EmployeeName} {e.Salary}");
        }

        Console.WriteLine("\nDelete Employee ID 101");
        Console.WriteLine(obj.DeleteEmployee(101));

        Console.WriteLine("\nEmployees After Deletion");

        foreach(Employee e in obj.GetAllEmployees())
        {
            Console.WriteLine($"{e.EmployeeID} {e.EmployeeName} {e.Salary}");
        }
    }
}