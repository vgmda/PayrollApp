using System;
namespace PayrollApp.Data;

/// <summary>
/// The Employee class contains information about each employee in the company.
/// It also provides a method for calculating basic pay.
/// It inherits the properties of the parent class. (Staff)
/// </summary>

public class Employee : Staff
{
    // Fields
    private const float empHourlyRate = 20;


    // Properties
    public float Bonus { get; private set; } = 200;

    // Constructor
    public Employee(string name) : base(name, empHourlyRate)
    {
        // Call the parent constructor and pass the two parameters (name & managerHourlyRate)
    }

    // Methods
    public override string ToString()
    {
        return "Name of Staff = " + NameOfStaff +
            ", Hourly Rate = " + empHourlyRate +
            ", Allowance = " + Bonus +
            ", Total Pay = " + TotalPay;
    }

    public override void CalculatePay()
    {
        base.CalculatePay();

        float multiplier = (float)1.2;

        if (HoursWorked > 160 && HoursWorked < 210)
        {
            Bonus += Bonus * multiplier;
            TotalPay += Bonus;
        }
        else if (HoursWorked > 210 && HoursWorked < 250)
        {
            multiplier += (float)0.5;
            Bonus += Bonus * multiplier;
            TotalPay += Bonus;
        }
        else if (HoursWorked > 250)
        {
            multiplier += (float)1;
            Bonus += Bonus * multiplier;
            TotalPay += Bonus;
        }

    }
}

