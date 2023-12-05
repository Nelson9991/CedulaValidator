using CedulaValidator.Service.Cedula;
using CedulaValidator.Service.Licencia.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient(AppConstants.LICENCIA_HTTP_CLIENT, client =>
{
  client.BaseAddress = new Uri("https://consultaweb.ant.gob.ec/PortalWEB/paginas/clientes/");
  client.DefaultRequestHeaders.Add("User-Agent", "PostmanRuntime/7.35.0");
  client.DefaultRequestHeaders.Add("Accept", "*/*");
  client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
  client.DefaultRequestHeaders.Add("Connection", "keep-alive");
});

var app = builder.Build();

app.AddLicenciaEndpoints();

app.Run();
