using EmpolyeeManagement.Models;

namespace EmpolyeeManagement.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly EmployeeDbContext employeeContext;

        public EmployeeService(EmployeeDbContext employeeContext) {
        
            this.employeeContext = employeeContext;
        }
        public void CreateEmployee(EmployeeService emp) { }

        public List<Employee> GetAllEmployess()
        {
            List<Employee> employeeList = (from emp in employeeContext.Employees
                                           where emp.IsDeleted == false
                                           select emp).ToList();

             return employeeList;
                                           
        }
    }
}
