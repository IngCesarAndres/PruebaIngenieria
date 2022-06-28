using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaIngenieria;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlServer<LibreriaContext>("Data Source=(localdb)\\PRACTICA; Initial Catalog=LibreriaDb; user id=prueba;password=chutas");
builder.Services.AddScoped<IAutorService, AutorService>();
builder.Services.AddScoped<ILibroService, LibroService>();



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

app.MapGet("/dbconexion", async([FromServices] LibreriaContext dbContext) =>{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: "+ dbContext.Database.IsInMemory());
});

app.Run();
