using MacorattiCleanArchtecture.Domain.Entities.Employee;

namespace MacorattiCleanArchtecture.Domain.Interfaces.Service
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> SelectAllAsync();

        public Task<Employee> InsertAsync();

        public Task<Employee> UpdateAsync();

        public Task<bool> DeleteAsync();
    }
}
