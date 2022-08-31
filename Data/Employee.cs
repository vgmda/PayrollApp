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
    public int Bonus { get; private set; }

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
        Bonus = 2000;

        if (HoursWorked == 200)
        {
            TotalPay += Bonus;
        }
    }
}

