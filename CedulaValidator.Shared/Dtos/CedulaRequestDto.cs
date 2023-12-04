using System.ComponentModel.DataAnnotations;

namespace CedulaValidator.Shared.Dtos;
public class CedulaRequestDto
{
  [Required(ErrorMessage = "La Cédula es requerida")]
  [Length(10, 10, ErrorMessage = "La Cédula debe tener 10 caractéres")]
  public string Cedula { get; set; } = string.Empty;
}
