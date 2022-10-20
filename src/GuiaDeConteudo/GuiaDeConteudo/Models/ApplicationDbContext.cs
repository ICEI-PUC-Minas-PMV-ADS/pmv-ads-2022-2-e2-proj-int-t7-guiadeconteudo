using Microsoft.EntityFrameworkCore;

namespace GuiaDeConteudo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Material> Materiais { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }
}
