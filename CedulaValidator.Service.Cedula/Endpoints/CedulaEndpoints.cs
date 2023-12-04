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
    var cedulaResp = await http.GetFromJsonAsync<CedulaResponseDto>($"{cedula}");

    if (cedulaResp is null)
      return TypedResults.NotFound("No se encontró la cédula solicitada");

    return TypedResults.Ok(cedulaResp);
  }
}
