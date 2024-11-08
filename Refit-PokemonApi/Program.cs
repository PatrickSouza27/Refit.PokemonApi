using System.Net;
using Refit;
using Refit.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRefitClient<IPokeService>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://pokeapi.co/api/v2"));

builder.Services.AddRefitClient<IExternalApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("http://localhost:5062/"));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();