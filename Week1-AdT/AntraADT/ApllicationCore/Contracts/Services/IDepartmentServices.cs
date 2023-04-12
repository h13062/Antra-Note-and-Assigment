using ApllicationCore.Entities;

namespace ApllicationCore.Services
{
    public interface IDepartmentServices
    {
        void AddDepartment();
        void DeleteDepartment();
        void GetAllDepartments();
        Departments GetDepartmentsById();
        void UpdateDepartment();
    }
}