using Adopet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=BancoAdopet.db"));

var app = builder.Build();

// Rotas para gerenciar abrigos
app.MapPost("/adopet/abrigos/cadastrar", async ([FromBody] Abrigo abrigo, [FromServices] AppDbContext ctx) =>
{
    ctx.Abrigos.Add(abrigo);
    await ctx.SaveChangesAsync();
    return Results.Created($"/adopet/abrigos/{abrigo.AbrigoId}", abrigo);
});

app.MapGet("/adopet/abrigos/listar", async ([FromServices] AppDbContext ctx) =>
{
    var abrigos = await ctx.Abrigos.ToListAsync();
    return abrigos.Any() ? Results.Ok(abrigos) : Results.NotFound();
});

// Rotas para gerenciar animais
app.MapPost("/adopet/animais/cadastrar", async ([FromBody] Animal animal, [FromServices] AppDbContext ctx) =>
{
    ctx.Animais.Add(animal);
    await ctx.SaveChangesAsync();
    return Results.Created($"/adopet/animais/{animal.AnimalId}", animal);
});

app.MapGet("/adopet/animais/listar", async ([FromServices] AppDbContext ctx) =>
{
    var animais = await ctx.Animais.ToListAsync();
    return animais.Any() ? Results.Ok(animais) : Results.NotFound();
});

app.MapPut("/adopet/animais/{id}", async (int id, [FromBody] Animal animalAtualizado, [FromServices] AppDbContext ctx) =>
{
    var animal = await ctx.Animais.FindAsync(id);
    if (animal == null)
    {
        return Results.NotFound();
    }
    animal.Nome = animalAtualizado.Nome;
    animal.Especie = animalAtualizado.Especie;
    animal.Raca = animalAtualizado.Raca;
    animal.Idade = animalAtualizado.Idade;
    animal.DisponivelParaAdocao = animalAtualizado.DisponivelParaAdocao;
    animal.AbrigoId = animalAtualizado.AbrigoId;
    await ctx.SaveChangesAsync();
    return Results.Ok(animal);
});

app.MapDelete("/adopet/animais/{id}", async (int id, [FromServices] AppDbContext ctx) =>
{
    var animal = await ctx.Animais.FindAsync(id);
    if (animal == null) return Results.NotFound();
    ctx.Animais.Remove(animal);
    await ctx.SaveChangesAsync();
    return Results.NoContent();
});

// Rotas para gerenciar adotantes
app.MapPost("/adopet/adotantes/cadastrar", async ([FromBody] Adotante adotante, [FromServices] AppDbContext ctx) =>
{
    ctx.Adotantes.Add(adotante);
    await ctx.SaveChangesAsync();
    return Results.Created($"/adopet/adotantes/{adotante.AdotanteId}", adotante);
});

app.MapGet("/adopet/adotantes/listar", async ([FromServices] AppDbContext ctx) =>
{
    var adotantes = await ctx.Adotantes.ToListAsync();
    return Results.Ok(adotantes);
});

// Rotas para gerenciar adoções
app.MapPost("/adopet/adocoes/cadastrar", async ([FromBody] Adocao adocao, [FromServices] AppDbContext ctx) =>
{
    ctx.Adocoes.Add(adocao);
    await ctx.SaveChangesAsync();
    return Results.Created($"/adopet/adocoes/{adocao.AdocaoId}", adocao);
});

app.MapGet("/adopet/adocoes/listar", async ([FromServices] AppDbContext ctx) =>
{
    var adocoes = await ctx.Adocoes.ToListAsync();
    return Results.Ok(adocoes);
});

app.MapPut("/adopet/adocoes/{id}", async (int id, [FromBody] Adocao adocaoAtualizada, [FromServices] AppDbContext ctx) =>
{
    var adocao = await ctx.Adocoes.FindAsync(id);
    if (adocao == null)
    {
        return Results.NotFound();
    }
    adocao.Status = adocaoAtualizada.Status;
    await ctx.SaveChangesAsync();
    return Results.Ok(adocao);
});

app.MapDelete("/adopet/adocoes/{id}", async (int id, [FromServices] AppDbContext ctx) =>
{
    var adocao = await ctx.Adocoes.FindAsync(id);
    if (adocao == null) return Results.NotFound();
    ctx.Adocoes.Remove(adocao);
    await ctx.SaveChangesAsync();
    return Results.NoContent();
});

app.Run();