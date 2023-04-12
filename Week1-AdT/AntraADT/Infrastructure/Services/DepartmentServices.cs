using ApllicationCore.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{

    public class DepartmentServices
    {
        DepartmentRepository departmentRepository;
        public DepartmentServices()
        {
            departmentRepository = new DepartmentRepository();
        }
        public void AddDepartment()
        {
            Departments d = new Departments();
            Console.Write("Enter name of Department: ");
            d.DeptName = Console.ReadLine();
            Console.Write("Enter name of Department's Location : ");
            d.Location = Console.ReadLine();
            if (departmentRepository.Insert(d) > 0)
            {
                Console.WriteLine("Sucessful insert for Department: ");
            }
            else
            {
                Console.WriteLine("Error insert for Department: ");
            }

        }
        public void DeleteDepartment()
        {
            Console.Write("Enter the Id of Department to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            departmentRepository.DeleteById(id);
        }
        public void UpdateDepartment()
        {
            var deptToChange = GetDepartmentsById();
            Console.Write("Enter new department name: ");
            deptToChange.DeptName = Console.ReadLine();
            Console.Write("Enter new location: ");
            deptToChange.Location = Console.ReadLine();
            departmentRepository.Update(deptToChange);
        }
        public Departments GetDepartmentsById()
        {
            Console.Write("Enter Department ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Departments departments = departmentRepository.GetById(id);
            Console.WriteLine($"{departments.ID} \t {departments.DeptName} \t {departments.Location}");
            return departments;
        }
        public void GetAllDepartments()
        {
            IEnumerable<Departments> departments = departmentRepository.GetAll();
            foreach (var department in departments)
            {
                Console.WriteLine($"{department.ID} \t {department.DeptName} \t {department.Location}");
            }
        }
    }
}
