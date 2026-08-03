using System;

class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;

    public Person(string firstName, string lastName, string email, DateTime dob)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = email;
        this.dateOfBirth = dob;
    }

    // Read-only property
    public bool IsAdult
    {
        get
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now < dateOfBirth.AddYears(age))
                age--;

            return age >= 18;
        }
    }

    // Read-only property
    public bool IsBirthDay
    {
        get
        {
            return (DateTime.Now.Day == dateOfBirth.Day &&
                    DateTime.Now.Month == dateOfBirth.Month);
        }
    }

    // Read-only property
    public string ScreenName
    {
        get
        {
            return firstName.ToLower() +
                   lastName.ToLower() +
                   dateOfBirth.ToString("ddMMyy");
        }
    }

    // Read-only property
    public string SunSign
    {
        get
        {
            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "Aries";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "Taurus";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return "Gemini";
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return "Cancer";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Leo";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Virgo";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Libra";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Scorpio";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Sagittarius";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "Capricorn";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "Aquarius";
            else
                return "Pisces";
        }
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, string email,
                    DateTime dob, double salary)
        : base(firstName, lastName, email, dob)
    {
        Salary = salary;
    }
}

class InheritanceProgram
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(
            "Hari",
            "Doe",
            "hari@gmail.com",
            new DateTime(1998, 5, 25),
            50000
        );

        Console.WriteLine("Is Adult      : " + emp.IsAdult);
        Console.WriteLine("Sun Sign      : " + emp.SunSign);
        Console.WriteLine("Is Birthday   : " + emp.IsBirthDay);
        Console.WriteLine("Screen Name   : " + emp.ScreenName);
        Console.WriteLine("Salary        : " + emp.Salary);
    }
}