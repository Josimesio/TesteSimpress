using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebTesteEntrevista.Models;

namespace WebTesteEntrevista.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categoria { get; set; } 

    }
}
