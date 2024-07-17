using CSharpFunctionalExtensions;
using MacorattiCleanArchtecture.Application.DTOs;

namespace MacorattiCleanArchtecture.Application.Interfaces.Employee
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<EmployeeDTO>> SelectAllAsync();

        public Task<EmployeeDTO> InsertAsync(EmployeeDTO employee);

        public Task<EmployeeDTO> UpdateAsync(EmployeeDTO employee);

        public bool DeleteAsync(Guid id);
    }
}
