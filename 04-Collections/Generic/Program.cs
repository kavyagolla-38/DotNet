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
    List<Employee> employees = new List<Employee>();

    public bool AddEmployee(Employee e)
    {
        employees.Add(e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeID == id)
            {
                employees.Remove(emp);
                return true;
            }
        }
        return false;
    }

    public string SearchEmployee(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeID == id)
                return emp.EmployeeName;
        }
        return null ?? " ";  
    }

    public Employee[] GetAllEmployees()
    {
        return employees.ToArray();
    }
}

class Program
{
    static void Main()
    {
        EmployeeDAL obj = new EmployeeDAL();

        obj.AddEmployee(new Employee("Kavya",101,50000));
        obj.AddEmployee(new Employee("Rahul",102,60000));
        obj.AddEmployee(new Employee("Priya",103,55000));

        Console.WriteLine("Search Employee 102");
        Console.WriteLine(obj.SearchEmployee(102));

        Console.WriteLine("\nEmployee List");

        foreach(Employee e in obj.GetAllEmployees())
        {
            Console.WriteLine($"{e.EmployeeID} {e.EmployeeName} {e.Salary}");
        }

        Console.WriteLine("\nDelete Employee 101");
        Console.WriteLine(obj.DeleteEmployee(101));

        Console.WriteLine("\nEmployees After Deletion");

        foreach(Employee e in obj.GetAllEmployees())
        {
            Console.WriteLine($"{e.EmployeeID} {e.EmployeeName} {e.Salary}");
        }
    }
}