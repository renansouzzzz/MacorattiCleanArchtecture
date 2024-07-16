using CSharpFunctionalExtensions;
using MacorattiCleanArchtecture.Domain.Entities.Employee;
using MacorattiCleanArchtecture.Domain.Interfaces.Service;
using MacorattiCleanArchtecture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace MacorattiCleanArchtecture.Infra.Data.Repositories
{
    public sealed class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Result<IEnumerable<Employee>>> SelectAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Result<Employee, string>> InsertAsync(Employee company)
        {
            var exists = await _context
                .Employees
                .AnyAsync(a => a.Id == company.Id);

            if (exists)
                return "Entidade já existente.";

            await _context.AddAsync(company);

            return company;
        }

        public async Task<Result<Employee, string>> UpdateAsync(Employee company)
        {
            var exists = await _context
                .Employees
                .AnyAsync(a => a.Id == company.Id);

            if (!exists)
                return "Esse ID não existe no contexto.";

            _context.Update(company);

            return company;
        }

        public async Task<Result<bool, string>> DeleteAsync(Guid id)
        {
            var exists = await _context
                .Employees
                .AnyAsync(a => a.Id == id);

            if (!exists)
                return "Essa entidade não existe no contexto.";

            _context.Remove(id);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
