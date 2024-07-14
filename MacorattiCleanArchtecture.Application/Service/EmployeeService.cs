using MacorattiCleanArchtecture.Domain.Entities.Employee;
using MacorattiCleanArchtecture.Domain.Interfaces.Service;

namespace MacorattiCleanArchtecture.Application.Service
{
    public class EmployeeService : IEmployeeService
    {
        public Task<bool> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> InsertAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> SelectAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
