using CSharpFunctionalExtensions;
using MacorattiCleanArchtecture.Domain.Entities.Company;

namespace MacorattiCleanArchtecture.Domain.Interfaces.Service
{
    public interface ICompanyRepository
    {
        public Task<Result<IEnumerable<Company>>> SelectAllAsync();

        public Task<Result<Company, string>> InsertAsync(Company company);

        public Task<Result<Company, string>> UpdateAsync(Company company);

        public Task<Result<bool, string>> DeleteAsync(Guid id);
    }
}
