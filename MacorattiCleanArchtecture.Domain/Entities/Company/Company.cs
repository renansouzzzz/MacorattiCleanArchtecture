using EmployeeModel = MacorattiCleanArchtecture.Domain.Entities.Employee.Employee;

namespace MacorattiCleanArchtecture.Domain.Entities.Company
{
    public sealed class Company : EntityAbstract
    {
        public string Name { get; private set; }

        public string CNPJ { get; private set; }

        public string Address { get; private set; }

        public EmployeeModel Employee { get; set; }


        public Company(string name, string cnpj, string address, EmployeeModel employee, Guid employeeId)
        {
            Name = name;
            CNPJ = cnpj;
            Address = address;
            Employee = employee;
        }
    }
}
