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

        }
        public void DeleteDepartment()
        {
            Console.Write("");
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
            Console.Write("Enter ID: ");
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
