using Microsoft.EntityFrameworkCore;

namespace Projeto.Data
{
    public class GerenciamentoAdocaoContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Abrigo> Abrigos { get; set; }
        public DbSet<Adotante> Adotantes { get; set; }
        public DbSet<Adocao> Adocoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=gerenciamento_adocao.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais (se necessário)
        }
    }
}
