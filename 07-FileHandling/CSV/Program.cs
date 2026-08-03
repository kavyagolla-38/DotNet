using System;
using System.Collections.Generic;
using System.IO;

class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string Designation { get; set; }
    public DateTime JoiningDate { get; set; }
    public string DepartmentName { get; set; }
}

class EmployeeData
{
    public List<Employee> EmployeeInfo = new List<Employee>();

    public void AddEmployee(Employee emp)
    {
        EmployeeInfo.Add(emp);

        // Append employee details to CSV file
        using (StreamWriter sw = new StreamWriter("Employee.csv", true))
        {
            sw.WriteLine($"{emp.EmployeeID},{emp.EmployeeName},{emp.Designation},{emp.JoiningDate.ToShortDateString()},{emp.DepartmentName}");
        }
    }

    public void DisplayEmployees()
    {
        Console.WriteLine("\nEmployee Details");

        foreach (Employee emp in EmployeeInfo)
        {
            Console.WriteLine($"{emp.EmployeeID}  {emp.EmployeeName}  {emp.Designation}  {emp.JoiningDate.ToShortDateString()}  {emp.DepartmentName}");
        }
    }
}

class Program
{
    static void Main()
    {
        EmployeeData obj = new EmployeeData();

        Console.Write("Enter number of employees: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Employee emp = new Employee();

            Console.Write("\nEmployee ID: ");
            emp.EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Employee Name: ");
            emp.EmployeeName = Console.ReadLine();

            Console.Write("Designation: ");
            emp.Designation = Console.ReadLine();

            Console.Write("Joining Date (dd/MM/yyyy): ");
            emp.JoiningDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Department Name: ");
            emp.DepartmentName = Console.ReadLine();

            obj.AddEmployee(emp);
        }

        obj.DisplayEmployees();

        Console.WriteLine("\nEmployee details saved successfully to Employee.csv");
    }
}