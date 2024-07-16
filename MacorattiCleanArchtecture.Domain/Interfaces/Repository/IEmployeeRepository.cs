using CSharpFunctionalExtensions;
using MacorattiCleanArchtecture.Domain.Entities.Employee;

namespace MacorattiCleanArchtecture.Domain.Interfaces.Service
{
    public interface IEmployeeRepository
    {
        public Task<Result<IEnumerable<Employee>>> SelectAllAsync();

        public Task<Result<Employee, string>> InsertAsync(Employee employee);

        public Task<Result<Employee, string>> UpdateAsync(Employee employee);

        public Task<Result<bool, string>> DeleteAsync(Guid id);
    }
}
