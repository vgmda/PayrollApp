
using PayrollApp.Data;

namespace PayrollApp;

class Program
{
    private static void Main(string[] args)
    {
        //Staff s1 = new Staff("Vasile", 5);
        //Manager m1 = new Manager("Vasile");
        //Admin a1 = new Admin("Vasile");

        //s1.HoursWorked = 200;
        //m1.HoursWorked = 200;
        //a1.HoursWorked = 200;

        //s1.CalculatePay();
        //m1.CalculatePay();
        //a1.CalculatePay();

        //Console.WriteLine(s1.ToString());
        //Console.WriteLine(m1.ToString());
        //Console.WriteLine(a1.ToString());

        FileReader f = new FileReader();

        f.ReadFile();

        Console.ReadLine();


    }
}