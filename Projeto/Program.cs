using Projeto.Data; 
using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<GerenciamentoAdocaoContext>(options =>
    options.UseSqlite("Data Source=gerenciamento_adocao.db"));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapPost("/animais", async (Animal animal, GerenciamentoAdocaoContext context) =>
{
    context.Animais.Add(animal);
    await context.SaveChangesAsync();
    return Results.Created($"/animais/{animal.Id}", animal);
});

app.MapGet("/animais", async (GerenciamentoAdocaoContext context) =>
{
    var animais = await context.Animais.Include(a => a.Abrigo).ToListAsync();
    return Results.Ok(animais);
});

app.MapPut("/animais/{id}", async (int id, Animal dadosAtualizados, GerenciamentoAdocaoContext context) =>
{
    var animal = await context.Animais.FindAsync(id);
    if (animal is null) return Results.NotFound();

    animal.Nome = dadosAtualizados.Nome;
    animal.Especie = dadosAtualizados.Especie;
    animal.Raca = dadosAtualizados.Raca;
    animal.Idade = dadosAtualizados.Idade;
    animal.DisponivelParaAdocao = dadosAtualizados.DisponivelParaAdocao;

    await context.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/animais/{id}", async (int id, GerenciamentoAdocaoContext context) =>
{
    var animal = await context.Animais.FindAsync(id);
    if (animal is null) return Results.NotFound();

    context.Animais.Remove(animal);
    await context.SaveChangesAsync();
    return Results.NoContent();
});

app.MapPost("/adocoes", async (Adocao adocao, GerenciamentoAdocaoContext context) =>
{
    var animal = await context.Animais.FindAsync(adocao.AnimalId);
    if (animal is null || !animal.DisponivelParaAdocao)
        return Results.BadRequest("Animal não disponível para adoção");

    var adotante = await context.Adotantes.FindAsync(adocao.AdotanteId);
    if (adotante is null)
        return Results.BadRequest("Adotante não encontrado");

    animal.DisponivelParaAdocao = false;  // Atualizando status do animal
    adocao.Status = "Pendente";
    context.Adocoes.Add(adocao);
    await context.SaveChangesAsync();

    return Results.Created($"/adocoes/{adocao.Id}", adocao);
});

app.Run();
