
using PayrollApp.Data;

namespace PayrollApp;

class Program
{
    private static void Main(string[] args)
    {
        List<Staff> sList = new List<Staff>();
        sList.Add(new Staff("Vaso", 20));
        sList.Add(new Staff("Test", 21));
        sList.Add(new Staff("Test3", 10));
        sList.Add(new Staff("Test43", 30));




        Manager m1 = new Manager("Vasile");
        Admin a1 = new Admin("Vasile");

        sList[0].HoursWorked = 200;
        m1.HoursWorked = 200;
        a1.HoursWorked = 200;

        sList[0].CalculatePay();
        //m1.CalculatePay();
        //a1.CalculatePay();

        //Console.WriteLine(s1.ToString());
        //Console.WriteLine(m1.ToString());
        //Console.WriteLine(a1.ToString());

        FileReader f = new FileReader();

        f.ReadFile();

        PaySlip p = new PaySlip(1, 2011);

        p.GeneratePaySlip(sList);




        Console.ReadLine();

    }
}