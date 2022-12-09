using Microsoft.EntityFrameworkCore;
using VetWebApi.Models;

namespace VetWebApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Remedio> Remedios { get; set; }
    }
    {
    }
}
