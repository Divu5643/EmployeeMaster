using EmpolyeeManagement.Models;

namespace EmpolyeeManagement.Services
{
    public interface IEmployeeService
    {
        public void CreateEmployee(EmployeeService emp);
        List<Employee> GetAllEmployess();
    }
}
