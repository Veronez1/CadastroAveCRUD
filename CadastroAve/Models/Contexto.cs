using Microsoft.EntityFrameworkCore;

namespace CadastroAve.Models
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> options) : base(options)
        {
            
        }

        public DbSet<Ave> Ave { get; set; }
    }
}
