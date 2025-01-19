using FrontCrudEmpleados;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CurrieTechnologies.Razor.SweetAlert2;
using FrontCrudEmpleados.Repositorios;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSweetAlert2();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5260/")
});


ConfigureServices(builder.Services);
await builder.Build().RunAsync();

void ConfigureServices(IServiceCollection services)
{
    services.AddSweetAlert2();
    services.AddScoped<IRepositorio, Repositorio>();

}


await builder.Build().RunAsync();
