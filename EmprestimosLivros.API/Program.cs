using EmprestimosLivrosNovo.Infra.Data;
using EmprestimosLivrosNovo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using EmprestimosLivrosNovo.Application.Mappings;
using EmprestimosLivrosNovo.Infra.Ioc;
using EmprestimosLivrosNovo.Application.Interfaces;
using EmprestimosLivrosNovo.Application.Services;
using EmprestimosLivrosNovo.Domain.Interfaces;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ControleEmprestimoLivroContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddInfrastructureSwagger();
//builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClienteService, ClienteService>();

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();


builder.Services.AddAutoMapper(typeof(EntitiesToDTOMappingProfile));

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
