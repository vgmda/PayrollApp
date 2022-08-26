using System;
namespace PayrollApp.Data;

/// <summary>
/// The Staff class contains information about each staff in the company.
/// It also provides a method for calculating basic pay.
/// It serves as a parent class from which two other classes will be derived. (Manager & Admin)
/// </summary>

public class Staff
{
    // Fields
    private float hourlyRate;
    private int hWorked;

    // Properties
    public float TotalPay { get; protected set; }
    public float BasicPay { get; private set; }
    public string NameOfStaff { get; private set; }
    public int HoursWorked
    {
        get
        {
            return hWorked;
        }
        set
        {
            if (value > 0)
            {
                hWorked = value;
            }
            else
            {
                hWorked = 0;
            }
        }
    }

    // Constructor
    public Staff(string name, float rate)
    {
        NameOfStaff = name;
        hourlyRate = rate;
    }

    // Methods
    public override string ToString()
    {
        return "Name of Staff = " + NameOfStaff +
            ", Hourly Rate = " + hourlyRate +
            ", Hours Worked = " + hWorked +
            ", Total Pay = " + TotalPay;
    }

    public virtual void CalculatePay()
    {
        Console.WriteLine("Calculating Pay...Please wait...");

        BasicPay = hWorked * hourlyRate;
        TotalPay = BasicPay;

    }
}

