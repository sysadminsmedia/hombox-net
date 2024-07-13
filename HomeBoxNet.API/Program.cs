using HomeBoxNet.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = "HomeBoxNet.API", 
        Version = "v1",
        License = new OpenApiLicense()
        {
            Name = "AGPL-3.0",
            Url = new Uri("https://www.gnu.org/licenses/agpl-3.0.html")
        },
        Description = "v1 of the HomeBox API. This is a replica of the original Go based rest API."
    });
    c.SwaggerDoc("v2", new OpenApiInfo()
    {
        Title = "HomeBoxNet.API",
        Version = "v2",
        License = new OpenApiLicense()
        {
            Name = "AGPL-3.0",
            Url = new Uri("https://www.gnu.org/licenses/agpl-3.0.html")
        },
        Description = "v2 of the HomeBox API. This is a complete rewrite using OData for the API"
    });
});

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "HomeBoxNet.API v1");
    c.SwaggerEndpoint("/swagger/v2/swagger.json", "HomeBoxNet.API v2");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();