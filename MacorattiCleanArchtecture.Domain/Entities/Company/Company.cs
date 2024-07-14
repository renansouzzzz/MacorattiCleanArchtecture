namespace MacorattiCleanArchtecture.Domain.Entities.Company
{
    public sealed class Company : EntityAbstract
    {
        public string Name { get; private set; }

        public string CNPJ { get; private set; }

        public string Address { get; private set; }


        public Company(string name, string cnpj, string address)
        {
            Name = name;
            CNPJ = cnpj;
            Address = address;
        }
    }
}
