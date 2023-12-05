using System.Text.Json;
using CedulaValidator.Service.Cedula;
using CedulaValidator.Shared.Dtos;

namespace CedulaValidator.Service.Ruc.Endpoints;

public static class RucEndpoints
{
  public static WebApplication AddRucEndpoints(this WebApplication app)
  {
    var rucEndpoint = app.MapGroup("/api/ruc");

    rucEndpoint.MapGet("/{ruc}", ValidateRuc);

    return app;
  }

  private static async Task<IResult> ValidateRuc(string ruc, IHttpClientFactory clientFactory)
  {
    using var http = clientFactory.CreateClient(AppConstants.RUC_HTTP_CLIENT);
    var rucResp = await http.GetStringAsync($"{ruc}");

    return rucResp.Contains("error")
    ? TypedResults.NotFound(JsonSerializer.Deserialize<ErrorResponseDto>(rucResp))
    : TypedResults.Ok(JsonSerializer.Deserialize<RucResponseDto>(rucResp));
  }
}
