using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Repositorie.Common
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CategoriaProduto> CategoriasProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PromocaoProduto> PromocoesProdutos { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
        public AppDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;

        }
    }
}
