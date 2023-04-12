using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menu
{
    public class MenuSelection
    {
        DepartmentServices d;
        EmployeeServices e;
        public MenuSelection()
        {
            d = new DepartmentServices();
            e = new EmployeeServices();
        }
        public void run()
        {
            int userChoice;
            do
            {
                Console.WriteLine("Select the number of your choice: ");
                Console.WriteLine("1: Add employee");
                Console.WriteLine("2: Remove a employee");
                Console.WriteLine("3: List all emloyee");
                Console.WriteLine("4: Add Department");
                Console.WriteLine("5: Remove a Department");
                Console.WriteLine("6: List all Department");
                Console.WriteLine("7: Quit");
                Console.Write("Enter the number of your choice: ");
                userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 7 )
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Choice = " + userChoice);

                if (userChoice == 1)
                {
                    e.AddEmployee();
                }
                if (userChoice == 2)
                {
                    e.DeleteEmployee();
                }
                if (userChoice == 3)
                {
                    e.GetAllEmployee();
                }
                if (userChoice == 4)
                {
                    d.AddDepartment();
                }
                if (userChoice == 5)
                {
                    d.DeleteDepartment();

                }
                if (userChoice == 6)
                {
                    d.GetAllDepartments();
                }
            } while (true);
        }
        
    }
}
