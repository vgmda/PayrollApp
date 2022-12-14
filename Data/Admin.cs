using System;
namespace PayrollApp.Data;

/// <summary>
/// The Admin class contains information about each admin in the company.
/// It also provides a method for calculating basic pay.
/// It inherits the properties of the parent class. (Staff)
/// </summary>

public class Admin : Staff
{

    // Fields
    private const float overtimeRate = (float)15.50;
    private const float adminHourlyRate = 30;

    // Properties
    public float Overtime { get; private set; }

    // Constructor
    public Admin(string name) : base(name, adminHourlyRate)
    {
        // Call the parent constructor and pass the two parameters (name & managerHourlyRate)
    }

    // Methods
    public override string ToString()
    {
        return "Name of Staff = " + NameOfStaff +
            ", Hourly Rate = " + adminHourlyRate +
            ", Overtime Rate = " + overtimeRate +
            ", Total Pay = " + TotalPay;
    }

    public override void CalculatePay()
    {
        base.CalculatePay();

        if (HoursWorked > 160)
        {
            Overtime = overtimeRate * (HoursWorked - 160);
            TotalPay += Overtime;
        }
    }
}



