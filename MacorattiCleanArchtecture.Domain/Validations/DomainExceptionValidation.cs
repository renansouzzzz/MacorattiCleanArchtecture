namespace MacorattiCleanArchtecture.Domain.Validations
{
    public class DomainExceptionValidation
    {
        public bool ValueNull(object atributes)
        {
            foreach (var item in atributes.GetType().GetProperties())
                if (item.GetValue(atributes) is null)
                    return true;

            return false;
        }
    }
}
