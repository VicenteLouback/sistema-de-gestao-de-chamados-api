using Microsoft.EntityFrameworkCore;
using SistemaGestaoChamados.Infrastructure.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os Controllers da API.
builder.Services.AddControllers();

// Configura o Entity Framework Core com SQL Server.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    var connectionString = builder.Configuration
        .GetConnectionString("DefaultConnection");

    options.UseSqlServer(connectionString);
});

// Configuração do OpenAPI.
builder.Services.AddOpenApi();

var app = builder.Build();

// Configuração do OpenAPI apenas no ambiente de desenvolvimento.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Redireciona HTTP para HTTPS.
app.UseHttpsRedirection();

// Mapeia os Controllers.
app.MapControllers();

app.Run();