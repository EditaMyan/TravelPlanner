using BlazorApp1;
using BlazorApp1.Context;
using BlazorApp1.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<Detailes>();


//Connection to database
builder.Services.AddDbContext<AppDbContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConnection")));


await builder.Build().RunAsync();
