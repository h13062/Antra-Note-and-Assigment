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
            Console.Write("Enter the department ID: ");
            e.DeptId = Convert.ToInt32(Console.ReadLine());
            if (employeeRepository.Insert(e) > 0)
            {
                Console.WriteLine("Sucessful insert for Employee: ");
            }
            else
            {
                Console.WriteLine("Error insert for Employee: ");
            }


        }
        public void DeleteEmployee()
        {
            Console.Write("Enter the Id of Employee to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            employeeRepository.DeleteById(id);
        }
        public Employees GetByEmployeeID()
        {
            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Employees e = employeeRepository.GetById(id);
            Console.WriteLine($"{e.Id} \t {e.FirstName} \t {e.LastName} \t {e.Salary} \t {e.DeptId}");
            return e;
        }
        public void GetAllEmployee()
        {
            IEnumerable<Employees> employees = employeeRepository.GetAll();
            foreach (var e in employees)
            {
                Console.WriteLine($"{e.Id} \t {e.FirstName} \t {e.LastName} \t {e.Salary} \t {e.DeptId}");
            }
        }
        public void UpdateEmployee()
        {
            var e = GetByEmployeeID();
            Console.Write("Enter new First name of Employee: ");
            e.FirstName = Console.ReadLine();
            Console.Write("Enter new Last name of Employee: ");
            e.LastName = Console.ReadLine();
            Console.Write("Enter new salary: ");
            e.Salary = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the department ID: ");
            e.DeptId = Convert.ToInt32(Console.ReadLine());
            employeeRepository.Update(e);
        }
    }
}
