using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetBHLeasing.Models;

namespace ProjetBHLeasing.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Client { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<Profil> Profil { get; set; }
        public DbSet<His_Relances> His_Relances { get; set; }

    }
}