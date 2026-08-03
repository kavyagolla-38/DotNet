using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string fname, string lname)
    {
        FirstName = fname;
        LastName = lname;
    }
}

interface IPayable
{
    void CalculatePay();
}

class HourlyEmployee : Person, IPayable
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }
    public double TotalPay { get; set; }

    public HourlyEmployee(string fname, string lname,
                          double hoursWorked, double payPerHour)
        : base(fname, lname)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public void CalculatePay()
    {
        TotalPay = HoursWorked * PayPerHour;
    }
}

class PermanentEmployee : Person, IPayable
{
    public double BasicSalary { get; set; }
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }
    public double NetPay { get; set; }
    public double TotalPay { get; set; }

    public PermanentEmployee(string fname, string lname,
                             double basicSalary,
                             double hra,
                             double da,
                             double tax)
        : base(fname, lname)
    {
        BasicSalary = basicSalary;
        HRA = hra;
        DA = da;
        Tax = tax;
    }

    public void CalculatePay()
    {
        TotalPay = BasicSalary + HRA + DA;
        NetPay = TotalPay - Tax;
    }
}

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee h = new HourlyEmployee("Hari", "Kumar", 40, 500);
        h.CalculatePay();

        Console.WriteLine("Hourly Employee");
        Console.WriteLine("Name : " + h.FirstName + " " + h.LastName);
        Console.WriteLine("Total Pay : " + h.TotalPay);

        Console.WriteLine();

        PermanentEmployee p = new PermanentEmployee("Ravi", "Kumar",
                                                    30000, 5000, 3000, 2000);
        p.CalculatePay();

        Console.WriteLine("Permanent Employee");
        Console.WriteLine("Name : " + p.FirstName + " " + p.LastName);
        Console.WriteLine("Total Pay : " + p.TotalPay);
        Console.WriteLine("Net Pay : " + p.NetPay);
    }
}