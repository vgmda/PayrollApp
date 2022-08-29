using System;
using System.IO;
namespace PayrollApp.Data;


/// <summary>
/// The FileReader class consists of a method ReadFile() that writes to a .txt file
/// </summary>

public class FileReader
{

    // Methods
    public List<Staff> ReadFile()
    {
        List<Staff> myStaff = new List<Staff>();

        // Create an array of two elements, will add values later (Name and Position)
        string[] result = new string[2];
        string path = @"./staff.txt";
        //string[] separator = { ", " };

        if (File.Exists(path))
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    result = sr.ReadLine().Split(", ");

                    if (result[1] == "Manager")
                    {
                        Manager m;
                        m = new Manager(result[0]);
                        myStaff.Add(m);
                    }
                    if (result[1] == "Admin")
                    {
                        Admin a;
                        a = new Admin(result[0]);
                        myStaff.Add(a);
                    }
                }
                sr.Close();
            }
        }
        else
        {
            Console.WriteLine("ERROR: File(s) does not exist");
        }

        return myStaff;

    }
}

