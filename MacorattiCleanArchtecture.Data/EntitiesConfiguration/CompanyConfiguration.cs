using MacorattiCleanArchtecture.Domain.Entities.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MacorattiCleanArchtecture.Infra.Data.EntitiesConfiguration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Cnpj).HasMaxLength(14);

            builder.Property(p => p.CreatedAt).IsRequired();
            builder.Property(p => p.UpdatedAt).IsRequired();
        }
    }
}
