using MacorattiCleanArchtecture.Domain.Entities.Company;

namespace MacorattiCleanArchtecture.Domain.Interfaces.Service
{
    public interface ICompanyService
    {
        public Task<IEnumerable<Company>> SelectAllAsync();

        public Task<Company> InsertAsync();

        public Task<Company> UpdateAsync();

        public Task<bool> DeleteAsync();
    }
}
