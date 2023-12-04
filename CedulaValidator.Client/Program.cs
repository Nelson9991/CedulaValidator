using CedulaValidator.Client;
using CedulaValidator.Client.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient(AppConstants.CEDULA_SERVICE_CLIENT, client =>
{
  client.BaseAddress = new Uri("https://localhost:7045/api/cedula");
});

builder.Services.AddHttpClient(AppConstants.RUC_SERVICE_CLIENT, client =>
{
  client.BaseAddress = new Uri("https://localhost:7295/api/ruc");
});

builder.Services.AddHttpClient(AppConstants.LICENCIA_SERVICE_CLIENT, client =>
{
  client.BaseAddress = new Uri("https://localhost:7152/api/licencia");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error", createScopeForErrors: true);
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
