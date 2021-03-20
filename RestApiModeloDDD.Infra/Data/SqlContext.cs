using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Linq;

namespace RestApiModeloDDD.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Empresa> Empresas { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                    entry.Property("UltimaAlteracao").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("UltimaAlteracao").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Deleted)
                {
                    entry.Property("UltimaAlteracao").CurrentValue = DateTime.Now;
                    entry.Property("Deletado").CurrentValue = true;
                }
            }
            return base.SaveChanges();
        }
    }
}
