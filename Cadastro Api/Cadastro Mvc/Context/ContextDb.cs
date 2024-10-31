using Cadastro_Mvc.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_Mvc.Context
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options)
            : base(options) { }

        public DbSet<Pessoa> Pessoas => Set<Pessoa>();
        public DbSet<Endereco> Enderecos => Set<Endereco>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Enderecos)
                .WithOne(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Endereco>()
                .HasOne(w => w.Pessoa)
                .WithMany(p => p.Enderecos)
                .HasForeignKey(p => p.IdPessoa);
        }
    }
}
