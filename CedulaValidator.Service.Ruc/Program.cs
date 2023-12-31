using System.Net.Http.Headers;
using CedulaValidator.Service.Cedula;
using CedulaValidator.Service.Ruc.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
  options.AddPolicy("AllowAll", builder =>
  {
    builder.AllowAnyOrigin()
      .AllowAnyMethod()
      .AllowAnyHeader();
  });
});

builder.Services.AddHttpClient(AppConstants.RUC_HTTP_CLIENT, client =>
{
  client.BaseAddress = new Uri("https://webservices.ec/api/ruc/");
  client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
    "J3NqE1xmCLrStMC28wIxX8V29A5LNhE43YTsSaOf");
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.AddRucEndpoints();

app.Run();
