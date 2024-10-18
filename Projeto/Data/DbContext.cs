using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configuração para SQLite, onde o arquivo do banco de dados será criado.
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
}
