var builder = WebApplication.CreateBuilder(args); 

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(option => option.LowercaseUrls = true); // Colocar as url em letras minusculas

// Única forma de pegar o appsettings em program
var test = builder.Configuration.GetValue<string>("MyClass:Prop1");

var app = builder.Build(); // Build é para poder gerar uma variável para persistir as demais configurações

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
  Configurações da Api é nessa página;
*/
