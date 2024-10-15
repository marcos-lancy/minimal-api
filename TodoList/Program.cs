using TodoList.Models;

var builder = WebApplication.CreateBuilder(args);

// configuracao swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// linha atualizada
app.UseSwagger();
app.UseSwaggerUI();

// linha atualizada
app.MapGet("/", () => Results.Ok(new Tarefa(Guid.NewGuid(), "Escrever sobre Minimal Apis", false)));

app.Run();