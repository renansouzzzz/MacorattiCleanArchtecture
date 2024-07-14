using MacorattiCleanArchtecture.Domain.Entities.Company;
using MacorattiCleanArchtecture.Domain.Interfaces.Service;

namespace MacorattiCleanArchtecture.Application.Service
{
    public class CompanyService : ICompanyService
    {
        public Task<bool> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Company> InsertAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Company>> SelectAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Company> UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
