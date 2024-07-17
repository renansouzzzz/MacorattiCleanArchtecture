using CSharpFunctionalExtensions;
using MacorattiCleanArchtecture.Application.DTOs;

namespace MacorattiCleanArchtecture.Application.Interfaces.Company
{
    public interface ICompanyService
    {
        public Task<Result<IEnumerable<CompanyDTO>>> SelectAllAsync();

        public Task<Result<CompanyDTO, string>> InsertAsync(CompanyDTO company);

        public Task<Result<CompanyDTO, string>> UpdateAsync(CompanyDTO company);

        public Task<Result<bool, string>> DeleteAsync(Guid id);
    }
}
