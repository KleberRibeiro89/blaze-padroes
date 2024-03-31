using Blaze.Service;
using Blaze.Repository;
using blaze.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRepositoryModule(builder.Configuration);

builder.Services.AddHttpClient<IApostaService, ApostaService>((client) =>
{
    client.BaseAddress = new Uri(builder.Configuration["url"]);

});
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
