namespace CedulaValidator.Shared.Dtos;
public class CedulaResponseDto
{
  public DataCedula? Data { get; set; }
}

public class DataCedula
{
  public ResponseCedula? Response { get; set; }
}

public class ResponseCedula
{
  public string Identificacion { get; set; } = string.Empty;
  public string NombreCompleto { get; set; } = string.Empty;
  public string Nombres { get; set; } = string.Empty;
  public string Apellidos { get; set; } = string.Empty;
  public DateTime? FechaDefuncion { get; set; }
}
