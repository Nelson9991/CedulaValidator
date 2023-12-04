using System.Net.Http.Headers;
using CedulaValidator.Service.Cedula;
using CedulaValidator.Service.Cedula.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient(AppConstants.CEDULA_HTTP_CLIENT, client =>
{
  client.BaseAddress = new Uri("https://webservices.ec/api/cedula/");
  client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
    "J3NqE1xmCLrStMC28wIxX8V29A5LNhE43YTsSaOf");
});

var app = builder.Build();

app.AddCedulaEndpoints();

app.Run();
