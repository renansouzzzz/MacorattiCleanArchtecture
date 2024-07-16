using MacorattiCleanArchtecture.Domain.Entities.Company;
using MacorattiCleanArchtecture.Domain.Entities.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MacorattiCleanArchtecture.Infra.Data.EntitiesConfiguration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
            builder.Property(p => p.CPF).HasMaxLength(11).IsRequired();
            builder.Property(p => p.JobRole).HasMaxLength(50);
            builder.Property(p => p.Phone).HasMaxLength(11);

            builder.Property(p => p.CreatedAt).IsRequired();
            builder.Property(p => p.UpdatedAt).IsRequired();

            builder.HasOne(x => x.Company)
                .WithOne(x => x.Employee)
                .HasForeignKey<Employee>(x => x.CompanyId);
        }
    }
}
