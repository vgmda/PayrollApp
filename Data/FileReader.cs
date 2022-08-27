using System;
using System.IO;
namespace PayrollApp.Data;


/// <summary>
/// The FileReader class consists of a method ReadFile() that writes to a .txt file
/// </summary>

public class FileReader
{
    public List<Staff> ReadFile()
    {
        List<Staff> myStaff = new List<Staff>();
        string[] result = new string[2];
        string path = "staff.txt";
        string[] separator = { ", " };

    }
}

