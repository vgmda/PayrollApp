
using System;
using PayrollApp.Data;
namespace PayrollApp;

/// <summary>
/// Program class only consists of Main() method where all the calls are made.
/// </summary>

class Program
{
    private static void Main(string[] args)
    {
        List<Staff> myStaff = new List<Staff>();
        FileReader fr = new FileReader();
        int month = 0, year = 0;

        while (year == 0)
        {
            Console.WriteLine("\nPlease enter the year: ");

            try
            {
                // Code to convert the input to an integer
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                // Code to handle the exception
                Console.WriteLine("You have entered non-numeric characters. Try again");
            }
        }

        while (month == 0)
        {
            Console.WriteLine("\nPlease enter the month: ");

            try
            {
                // Code to convert the input to an integer
                month = Convert.ToInt32(Console.ReadLine());

                // Check the data range of the input
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Invalid month range. Enter a valid number");
                    month = 0;
                }
            }
            catch (Exception e)
            {
                // Code to handle the exception
                Console.WriteLine("You have entered non-numeric characters. Try again");
            }
        }

        myStaff = fr.ReadFile();

        for (int i = 0; i < myStaff.Count; i++)
        {
            try
            {
                Console.WriteLine("Enter hours worked for {0}", myStaff[i].NameOfStaff);
                myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());
                myStaff[i].CalculatePay();
                Console.WriteLine(myStaff[i].ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine("You have entered non-numeric characters. Try again");
                i--;
            }
        }

        PaySlip ps = new PaySlip(month, year);
        ps.GeneratePaySlip(myStaff);
        ps.GenerateSummary(myStaff);


        Console.ReadLine();
    }
}