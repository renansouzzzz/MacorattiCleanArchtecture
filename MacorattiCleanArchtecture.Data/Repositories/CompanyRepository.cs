using CSharpFunctionalExtensions;
using MacorattiCleanArchtecture.Domain.Entities.Company;
using MacorattiCleanArchtecture.Domain.Interfaces.Service;
using MacorattiCleanArchtecture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace MacorattiCleanArchtecture.Infra.Data.Repositories
{
    public sealed class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<Result<IEnumerable<Company>>> SelectAllAsync()
        {
            return await _context.Companys.ToListAsync();
        }

        public async Task<Result<Company, string>> InsertAsync(Company company)
        {
            var exists = await _context
                .Companys
                .AnyAsync(a => a.Id == company.Id);

            if (exists)
                return "Entidade já existente.";

            await _context.AddAsync(company);

            return company;
        }

        public async Task<Result<Company, string>> UpdateAsync(Company company)
        {
            var exists = await _context
                .Companys
                .AnyAsync(a => a.Id == company.Id);

            if (!exists)
                return "Esse ID não existe no contexto.";

            _context.Update(company);

            return company;
        }

        public async Task<Result<bool, string>> DeleteAsync(Guid id)
        {
            var exists = await _context
                .Companys
                .AnyAsync(a => a.Id == id);

            if (!exists)
                return "Essa entidade não existe no contexto.";

            _context.Remove(id);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
