namespace MacorattiCleanArchtecture.Domain.Entities.Employee
{
    public sealed class Employee : EntityAbstract
    {
        public string Name { get; private set; }

        public string Phone { get; private set; }

        public string JobRole { get; private set; }

        public string CPF { get; private set; }


        public Employee(string name, string phone, string jobRole, string cpf)
        {
            Name = name;
            Phone = phone;
            JobRole = jobRole;
            CPF = cpf;
        }
    }
}
