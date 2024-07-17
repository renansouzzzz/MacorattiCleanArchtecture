using System.ComponentModel.DataAnnotations;

namespace MacorattiCleanArchtecture.Application.DTOs
{
    public class CompanyDTO
    {
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2)]
        public string Name { get; set; } = null!;

        [MaxLength(14)]
        [Required(ErrorMessage = "CNPJ is required.")]
        public string Cnpj { get; set; } = null!;

        [MaxLength(100)]
        public string Address { get; set; } = null!;
    }
}
