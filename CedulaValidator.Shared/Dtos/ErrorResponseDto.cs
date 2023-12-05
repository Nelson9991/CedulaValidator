using System.Text.Json.Serialization;

namespace CedulaValidator.Shared.Dtos;
public class DataError
{
  [JsonPropertyName("error")]
  public string Error { get; set; } = string.Empty;
}

public class ErrorResponseDto
{
  [JsonPropertyName("error")]
  public bool Error { get; set; }

  [JsonPropertyName("data")]
  public DataError? Data { get; set; }
}


