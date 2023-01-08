using System;
using Microsoft.EntityFrameworkCore;

namespace LordOfTheRingsAPI.Models
{
	public class LotrDbContext: DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Lotr;User Id=aaron;Password=095458;\n");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();
        }

        public DbSet<Character> Characters { get; set; }
    }
}

