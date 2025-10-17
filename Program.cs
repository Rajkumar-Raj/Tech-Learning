using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TechLearning;

//var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.RootComponents.Add<App>("#app");
//builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//await builder.Build().RunAsync();


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var host = builder.Build();

// 🔸 Handle redirect from 404.html (e.g. /?path=/some/route)
var uri = new Uri(host.Services.GetRequiredService<NavigationManager>().Uri);
var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
var path = query.Get("path");

if (!string.IsNullOrEmpty(path))
{
    var nav = host.Services.GetRequiredService<NavigationManager>();
    nav.NavigateTo("Tech-Learning/" + path, forceLoad: false);
}

await host.RunAsync();