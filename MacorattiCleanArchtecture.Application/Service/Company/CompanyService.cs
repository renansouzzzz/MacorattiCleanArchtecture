using CSharpFunctionalExtensions;
using MacorattiCleanArchtecture.Application.DTOs;
using MacorattiCleanArchtecture.Application.Interfaces.Company;

namespace MacorattiCleanArchtecture.Application.Service.Company
{
    public class CompanyService : ICompanyService
    {
        public Task<Result<IEnumerable<CompanyDTO>>> SelectAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<CompanyDTO, string>> InsertAsync(CompanyDTO company)
        {
            throw new NotImplementedException();
        }

        public Task<Result<CompanyDTO, string>> UpdateAsync(CompanyDTO company)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool, string>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
