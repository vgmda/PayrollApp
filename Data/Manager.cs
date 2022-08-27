using System;
namespace PayrollApp.Data;

/// <summary>
/// The Manager class contains information about each manager in the company.
/// It also provides a method for calculating basic pay.
/// It inherits the properties of the parent class. (Staff)
/// </summary>

public class Manager : Staff
{

    // Fields
    private const float managerHourlyRate = 50;

    // Properties
    public int Allowance { get; private set; }

    // Constructor
    public Manager(string name) : base(name, managerHourlyRate)
    {
        // Call the parent constructor and pass the two parameters (name & managerHourlyRate)
    }

    // Methods
    public override string ToString()
    {
        return "Name of Staff = " + NameOfStaff +
            ", Hourly Rate = " + managerHourlyRate +
            ", Allowance = " + Allowance +
            ", Total Pay = " + TotalPay;
    }

    public override void CalculatePay()
    {
        base.CalculatePay();
        Allowance = 100;

        if (HoursWorked > 160)
        {
            TotalPay += Allowance;
        }
    }
}

