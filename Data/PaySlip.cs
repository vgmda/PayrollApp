using System;
namespace PayrollApp.Data;

/// <summary>
/// The Payslip class generates the pay slip of each employee in the company.
/// In addition, it also generates a summary of the details of staff who worked less than 10 hours in a month.
/// </summary>

public class PaySlip
{
    // Fields
    private int month;
    private int year;

    // Enum
    enum MonthsOfYear
    {
        JAN = 1,
        FEB = 2,
        MAR = 3,
        APR = 4,
        MAY = 5,
        JUN = 6,
        JUL = 7,
        AUG = 8,
        SEP = 9,
        OCT = 10,
        NOV = 11,
        DEC = 12
    }

    // Constructor
    public PaySlip(int payMonth, int payYear)
    {
        month = payMonth;
        year = payYear;
    }


    // Methods
    public override string ToString()
    {
        return "Month: " + month +
            ", Year: " + year;
    }

    public void GeneratePaySlip(List<Staff> myStaff)
    {
        string path;

        foreach (Staff f in myStaff)
        {
            path = @"./" + f.NameOfStaff + ".txt";

            // Writing to the file
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("PAYSLIP FOR {0} {1}", (MonthsOfYear)month, year);
                sw.WriteLine("=====================");
                sw.WriteLine("Name of Staff: {0}", f.NameOfStaff);
                sw.WriteLine("Hours Worked: {0}", f.HoursWorked);
                sw.WriteLine("");
                sw.WriteLine("Basic Pay: {0:C}", f.BasicPay);

                if (f.GetType() == typeof(Manager))
                {
                    sw.WriteLine("Allowance: {0:C}", ((Manager)f).Allowance);
                }
                else if (f.GetType() == typeof(Admin))
                {
                    sw.WriteLine("Overtime: {0:C}", ((Admin)f).Overtime);
                }

                sw.WriteLine("");
                sw.WriteLine("=====================");
                sw.WriteLine("Total Pay: {0:C}", f.TotalPay);
                sw.WriteLine("=====================");
                sw.Close();
            }
        }
    }

    public void GenerateSummary(List<Staff> myStaff)
    {
        var result =
            from staff in myStaff
            where staff.HoursWorked < 10
            orderby staff.NameOfStaff ascending
            select new { staff.NameOfStaff, staff.HoursWorked };

        string path = @"./summary.txt";

        // Writing to the file
        using (StreamWriter sw = new StreamWriter(path, true))
        {
            sw.WriteLine("---------------------------");
            sw.WriteLine("Staff with less than 10 working hours:");
            sw.WriteLine("");

            foreach (var f in result)
            {
                sw.WriteLine("Name of Staff: {0}, Hours Worked: {1}", f.NameOfStaff, f.HoursWorked);
            }

            sw.Close();
        }
    }



}

