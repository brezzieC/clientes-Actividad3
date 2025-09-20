using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Ventas.webAssembly;
using Ventas.webAssembly.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<RepresentantesService>();
builder.Services.AddScoped<SucursalesService>();
builder.Services.AddScoped<JefesService>();
builder.Services.AddScoped<ClienteService>();


await builder.Build().RunAsync();
