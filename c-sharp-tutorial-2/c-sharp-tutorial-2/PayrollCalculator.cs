using System;
using System.IO;
using System.Text.Json;

//call stack/debugging
//garbage collection/scope
//exception handling
//properties
//small project looking at how to store employee data

class PayrollCalculator
{
    public const string employeeDataPath = @"C:\Users\ambid\Documents\Coding\C-sharp-Basics\c-sharp-tutorial-2\readTest.txt";

    static void Main(string[] args)
    {
        //WriteEmployee();
        //ReadEmployee();
        PrintCost();
        
    }

    static void PrintCost()
    {
        int totalCost = 0;
        Console.WriteLine("asdf");
    }

    static void WriteEmployee()
    {
        Employee bob = new Employee()
        {
            Name = "bob",
            YearlyCost = 10000,
            EmployeeType = EmployeeTypes.Hourly,
            Address = new Address()
            {
                street = "123 meadow lane",
                zipCode = "11111",
                state = "NE"
            }
        };

        string employeeData;
        employeeData = JsonSerializer.Serialize<Employee>(bob);
        File.WriteAllText(employeeDataPath, employeeData);
    }

    //static void ReadEmployee()
    //{
    //    string employee = File.ReadAllText(employeeDataPath);
    //    Employee bob = JsonSerializer.Deserialize<Employee>(employee);
    //    Console.WriteLine(bob);
    //}
}
