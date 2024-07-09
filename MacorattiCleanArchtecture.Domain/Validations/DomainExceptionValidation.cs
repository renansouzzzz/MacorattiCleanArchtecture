namespace MacorattiCleanArchtecture.Domain.Validations
{
    public class DomainExceptionValidation
    {
        public bool ValueNull(ICollection<dynamic> atributes)
        {
            foreach (dynamic item in atributes)
                if (item is null)
                    return true;

            return false;
        }
    }
}
