using System.ComponentModel.DataAnnotations;

namespace CedulaValidator.Shared.Dtos;
public class CedulaRequestDto
{
  [Required(ErrorMessage = "La Cédula es requerida")]
  [Length(10, 10, ErrorMessage = "La Cédula debe tener 10 caractéres")]
  [RegularExpression(@"^[0-9]+$", ErrorMessage = "La Cédula debe ser numérica")]
  public string Cedula { get; set; } = string.Empty;
}
