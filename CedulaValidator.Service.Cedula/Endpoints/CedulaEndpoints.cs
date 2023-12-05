using System.Text.Json;
using CedulaValidator.Shared.Dtos;

namespace CedulaValidator.Service.Cedula.Endpoints;

public static class CedulaEndpoints
{
  public static WebApplication AddCedulaEndpoints(this WebApplication app)
  {
    var cedulaEndpoint = app.MapGroup("/api/cedula");

    cedulaEndpoint.MapGet("/{cedula}", ValidateCedula);

    return app;
  }

  private static async Task<IResult> ValidateCedula(string cedula, IHttpClientFactory clientFactory)
  {
    using var http = clientFactory.CreateClient(AppConstants.CEDULA_HTTP_CLIENT);
    var cedulaResp = await http.GetStringAsync($"{cedula}");

    return cedulaResp.Contains("error")
       ? TypedResults.BadRequest(JsonSerializer.Deserialize<ErrorResponseDto>(cedulaResp))
       : TypedResults.Ok(JsonSerializer.Deserialize<CedulaResponseDto>(cedulaResp));
  }
}
