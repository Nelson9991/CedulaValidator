using System.ComponentModel.DataAnnotations;

namespace CedulaValidator.Shared.Dtos;
public class RucRequestDto
{
  [Required(ErrorMessage = "La RUC es requerido")]
  [Length(13, 13, ErrorMessage = "La RUC debe tener 13 caractéres")]
  public string? Ruc { get; set; }
}
