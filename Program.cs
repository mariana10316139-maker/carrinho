using DataAccess;
using DataAccess.Repositorios;
using DataAccess.Repositorios.Contratos;


var builder = WebApplication.CreateBuilder(args);
//Registra o contexto
builder.Services.AddDbContext<Contexto>();
//Registra uma comanda de intemediario entre DB e Interfaces 
builder.Services.AddScoped<IPanhaRepositorio, PanhaRepositorio>();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
///Swagger
builder.Services.AddSwaggerGen();
// constro aplicacao
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
