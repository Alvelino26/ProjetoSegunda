using Microsoft.EntityFrameworkCore;

namespace Projeto.Data
{
    public class GerenciamentoAdocaoContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Abrigo> Abrigos { get; set; }
        public DbSet<Adotante> Adotantes { get; set; }
        public DbSet<Adocao> Adocoes { get; set; }

        // Construtor que aceita DbContextOptions
        public GerenciamentoAdocaoContext(DbContextOptions<GerenciamentoAdocaoContext> options) 
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=gerenciamento_adocao.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Abrigo>()
            .HasKey(a => a.Id);
       
        }
    }
}
