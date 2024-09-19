using BlazorDolarApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using BlazorDolarApp.Services;
using Microsoft.Extensions.DependencyInjection;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<DolaresServices>(client =>
{
    client.BaseAddress = new Uri("https://dolarapi.com/");
});
builder.Services.AddMudServices();

await builder.Build().RunAsync();
