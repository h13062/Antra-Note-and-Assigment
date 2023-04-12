//DAPPER tutorial 
// add class library 
using Infrastructure.Services;
using System;
using System.Linq;
using System.Text;
namespace ConsoleApp1;

public class Program
{
    public static void Main()
    {
        DepartmentServices d = new DepartmentServices();
        d.AddDepartment();
        d.DeleteDepartment();
        EmployeeServices e = new EmployeeServices();
    }
}
