
using CedulaValidator.Service.Cedula;
using CedulaValidator.Service.Licencia.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CedulaValidator.Service.Licencia.Endpoints;

public static class LicenciaEndpoints
{
  public static WebApplication AddLicenciaEndpoints(this WebApplication app)
  {
    var licenciaEndpoint = app.MapGroup("/api/licencia");

    licenciaEndpoint.MapGet("/consultar", GetLicenciaInfo);

    return app;
  }

  private static async Task<IResult> GetLicenciaInfo([FromQuery] string cedula,
    [FromQuery] string matricula, IHttpClientFactory clientFactory)
  {
    var http = clientFactory.CreateClient(AppConstants.LICENCIA_HTTP_CLIENT);
    var licenciaResp = await http.GetStringAsync($"clp_grid_citaciones.jsp?ps_tipo_identificacion=CED&ps_identificacion={cedula}&ps_placa={matricula}");

    return Results.Extensions.Html(licenciaResp);
  }
}
