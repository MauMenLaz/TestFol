using ConexionDatos;
using ConexionDatos.EDM;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//Configuracion de CORS
builder.Services.AddCors();

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});


app.UseHttpsRedirection();


app.MapGet("/saluda", () =>
{
    
    return "Hola :D";

});

app.MapGet("/obtenAreas", () =>
{
    Repositorio r = new Repositorio();
    return r.obtieneAreas();

});

app.MapGet("/obtieneEmpleados/{idEmpleado}", (int idEmpleado) =>
{
    Repositorio r = new Repositorio();
    return r.obtieneEmpleados(idEmpleado);

});

app.MapPost("/ingModEmpleado", (ExaTEmpleado emp) => {
    try
    {
        Repositorio re = new Repositorio();
        emp.FechaCreacion = DateTime.Now;
        return re.ingModEmpleado(emp);
    }
    catch (Exception ex)
    {
        return ex.Message;
    }
    
});

app.Run();

