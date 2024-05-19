using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Repository.Models;

namespace SistemaCadastro.Repository
{
        public class Context(string conn) : DbContext
        {
            private readonly string _connection = conn;

            public DbSet<Fornecedor> Fornecedor { get; set; }

            public DbSet<Produto> Produto { get; set; }

            public DbSet<Login> Login { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            { 
                optionsBuilder.UseSqlServer(_connection); 
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor");

                modelBuilder.Entity<Produto>().ToTable("Produto");

                modelBuilder.Entity<Login>().ToTable("Login");
            }

        }

}
