
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
        int month, year = 0;

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




        Console.ReadLine();

    }
}