using EmployeeModel = MacorattiCleanArchtecture.Domain.Entities.Employee.Employee;

namespace MacorattiCleanArchtecture.Domain.Entities.Company
{
    public sealed class Company : EntityAbstract
    {
        public string Name { get; private set; }

        public string Cnpj { get; private set; }

        public string Address { get; private set; }

        public EmployeeModel Employee { get; set; } = null!;


        public Company(string name, string cnpj, string address)
        {
            Name = name;
            Cnpj = cnpj;
            Address = address;
        }
    }
}
