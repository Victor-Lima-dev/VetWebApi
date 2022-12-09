using Microsoft.EntityFrameworkCore;
using VetWebApi.Context;
using VetWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//variavel com a string de conexao usando o builder
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//adicionando o contexto do banco de dados
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

//registrar aplicarEfeitosService
builder.Services.AddScoped<AplicarEfeitosService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
