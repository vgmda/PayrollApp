
using PayrollApp.Data;

namespace PayrollApp;

class Program
{
    private static void Main(string[] args)
    {


        //Staff s1 = new Staff("Vasile", 5);

        //s1.CalculatePay();

        //Console.WriteLine(s1.ToString());

        Staff s1 = new Staff("Vasile", 5);
        Manager m1 = new Manager("Vasile");

        s1.HoursWorked = 1000;
        m1.HoursWorked = 200;

        s1.CalculatePay();
        m1.CalculatePay();

        Console.WriteLine(s1.ToString());
        Console.WriteLine(m1.ToString());

        Console.ReadLine();
    }
}