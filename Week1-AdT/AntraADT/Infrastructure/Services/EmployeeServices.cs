using ApllicationCore.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class EmployeeServices
    {
        EmployeeRepository employeeRepository;
        public EmployeeServices()
        {
            employeeRepository = new EmployeeRepository();
        }
        public void AddEmployee()
        {
            Employees e = new Employees();
            Console.Write("Enter First name of Employee: ");
            e.FirstName = Console.ReadLine();
            Console.Write("Enter Last name of Employee: ");
            e.LastName = Console.ReadLine();
            Console.Write("Enter the salary: ");
            e.Salary = decimal.Parse(Console.ReadLine());
            if (employeeRepository.Insert(e) > 0)
            {
                Console.WriteLine("Sucessful insert for Employee: ");
            }
            else
            {
                Console.WriteLine("Error insert for Employee: ");
            }


        }
    }
}
