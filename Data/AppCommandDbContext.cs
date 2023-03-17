using CommanderDb.Model;
using CommanderDB.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.AppCommandDbContext
{
    public class AppCommandDbContext : DbContext
    {
        public AppCommandDbContext(DbContextOptions<AppCommandDbContext> options):base(options){
           
        }

        public DbSet<Commander> Commanders { get; set; }
        public DbSet<Macmiilka> Macmiilkas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
           modelBuilder
           .Entity<Commander>()
           .HasMany(p=>p.Macmiilkas)
           .WithOne(p=>p.commander!)
           .HasForeignKey(p=>p.CommanderId);

           modelBuilder
           .Entity<Macmiilka>()
           .HasOne(p=>p.commander)
           .WithMany(p=>p.Macmiilkas)
           .HasForeignKey(p=>p.CommanderId);
        } 
    }
}