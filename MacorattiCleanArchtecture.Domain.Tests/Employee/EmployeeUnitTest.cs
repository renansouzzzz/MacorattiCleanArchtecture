using FluentAssertions;
using MacorattiCleanArchtecture.Domain.Validations;
using EmployeeModel = MacorattiCleanArchtecture.Domain.Entities.Employee.Employee;

namespace MacorattiCleanArchtecture.Domain.Tests.Employee
{
    public class EmployeeUnitTest
    {
        private readonly DomainExceptionValidation ExceptionValidation;

        public EmployeeUnitTest()
        {
            ExceptionValidation = new DomainExceptionValidation();
        }

        private static EmployeeModel employee => new EmployeeModel(
            "",
            "12 997657465",
            "Diretor",
            "4875682346"
            );

        [Fact]
        public void CreateEmployee_AtributesNotNull_ShouldBeTrue()
        {
            ExceptionValidation.ValueNull(employee)
                .Should()
                .BeFalse();            
        }
    }
}
