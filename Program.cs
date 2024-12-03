var builder = WebApplication.CreateBuilder(args); 

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(option => option.LowercaseUrls = true); // Colocar as url em letras minusculas

// �nica forma de pegar o appsettings em program
var test = builder.Configuration.GetValue<string>("MyClass:Prop1");

var app = builder.Build(); // Build � para poder gerar uma vari�vel para persistir as demais configura��es

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // Somente quando estiver no modo de desenvolvimento para visualizar o swagger;
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
 * Program.Cs - EntryPoint - Primeiras Linhas a serem executadas
  Configura��es da Api � nessa p�gina;
*/
