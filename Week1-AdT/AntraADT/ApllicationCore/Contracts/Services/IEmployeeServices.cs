using ApllicationCore.Entities;

namespace ApllicationCore.Services
{
    public interface IEmployeeServices
    {
        void AddEmployee();
        void DeleteEmployee();
        void GetAllEmployee();
        Employees GetByEmployeeID();
        void UpdateEmployee();
    }
}