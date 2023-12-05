using System.Text.Json.Serialization;
namespace CedulaValidator.Shared.Dtos;

public class Data
{
  [JsonPropertyName("response")]
  public Response Response { get; set; } = new Response();
}

public class Response
{
  [JsonPropertyName("identificacion")]
  public string Identificacion { get; set; } = string.Empty;

  [JsonPropertyName("nombreCompleto")]
  public string NombreCompleto { get; set; } = string.Empty;

  [JsonPropertyName("nombres")]
  public string Nombres { get; set; } = string.Empty;

  [JsonPropertyName("apellidos")]
  public string Apellidos { get; set; } = string.Empty;

  [JsonPropertyName("fechaDefuncion")]
  public object FechaDefuncion { get; set; } = string.Empty;
}

public class CedulaResponseDto
{
  [JsonPropertyName("data")]
  public Data? Data { get; set; }
}