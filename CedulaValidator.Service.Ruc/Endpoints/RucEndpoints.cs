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
    var rucResp = await http.GetFromJsonAsync<RucResponseDto>($"{ruc}");

    if (rucResp is null)
      return TypedResults.NotFound("No se encontró el RUC solicitado");

    return TypedResults.Ok(rucResp);
  }
}
