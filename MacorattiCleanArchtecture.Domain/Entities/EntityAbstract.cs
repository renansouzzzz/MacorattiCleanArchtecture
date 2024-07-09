namespace MacorattiCleanArchtecture.Domain.Entities
{
    public abstract class EntityAbstract
    {
        public Guid Id { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        public DateTime UpdatedAt { get; protected set; }
    }
}
