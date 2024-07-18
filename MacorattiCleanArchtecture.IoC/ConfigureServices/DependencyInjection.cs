using MacorattiCleanArchtecture.Application.Interfaces.Company;
using MacorattiCleanArchtecture.Application.Interfaces.Employee;
using MacorattiCleanArchtecture.Application.Mappings;
using MacorattiCleanArchtecture.Application.Service.Company;
using MacorattiCleanArchtecture.Application.Service.Employee;
using MacorattiCleanArchtecture.Domain.Interfaces.Service;
using MacorattiCleanArchtecture.Infra.Data.Context;
using MacorattiCleanArchtecture.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MacorattiCleanArchtecture.Infra.IoC.ConfigureServices
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
            IConfiguration configuration) 
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            opt.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                )
            );

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
