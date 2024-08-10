using System.ComponentModel.DataAnnotations;

namespace MacorattiCleanArchtecture.Application.DTOs
{
    public class EmployeeDTO
    {
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2)]
        public string Name { get; set; } = null!;

        [MaxLength(9)]
        public string Phone { get; set; } = null!;

        [MinLength(3)]
        public string JobRole { get; set; } = null!;

        [Required(ErrorMessage = "CPF is required.")]
        [MaxLength(11)]
        [ValidCPF(ErrorMessage = "CPF invalid.")]
        public string Cpf { get; set; } = null!;

        //public string Name { get; private set; }

        //public string Phone { get; private set; }

        //public string JobRole { get; private set; }

        //public string Cpf { get; private set; }

        //public Guid CompanyId { get; set; }

        //public CompanyModel Company { get; set; }
    }
}
