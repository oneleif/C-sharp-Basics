using System;
using System.Collections.Generic;
using System.Text;

public enum EmployeeTypes
{
    Salary, Hourly
}

class Employee
{
    public const int numberOfHoursPerYear = 2000; // Assuming 50 weeks worked per year, and 40 hours per week

    private float _yearlyCost;

    public string Name { get; set; }
    public float YearlyCost { 
        get 
        {
            if(EmployeeType == EmployeeTypes.Hourly)
            {
                return _yearlyCost * numberOfHoursPerYear;
            }
            else
            {
                return _yearlyCost;
            }
        }
        set{
            _yearlyCost = value;
        } 
    }
    public EmployeeTypes EmployeeType { get; set; }
    public Address Address { get; set; }

    public override string ToString()
    {
        return $"Employee name:  {Name}  yearly cost: {YearlyCost}";
    }

}
