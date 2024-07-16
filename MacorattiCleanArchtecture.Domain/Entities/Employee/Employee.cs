using CompanyModel = MacorattiCleanArchtecture.Domain.Entities.Company.Company;

namespace MacorattiCleanArchtecture.Domain.Entities.Employee
{
    public sealed class Employee : EntityAbstract
    {
        public string Name { get; private set; }

        public string Phone { get; private set; }

        public string JobRole { get; private set; }

        public string Cpf { get; private set; }

        public Guid CompanyId { get; set; }

        public CompanyModel Company { get; set; }


        public Employee(Guid companyId, string name, string phone, string jobRole, string cpf)
        {
            CompanyId = companyId;
            Name = name;
            Phone = phone;
            JobRole = jobRole;
            Cpf = cpf;
        }
    }
}
