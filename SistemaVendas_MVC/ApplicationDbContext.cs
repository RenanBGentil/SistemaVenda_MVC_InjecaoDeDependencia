using Microsoft.EntityFrameworkCore;
using SistemaVendas_MVC.Models;

namespace SistemaVendas_MVC
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options ) : base (options) { }

        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<VendaModel> Vendas { get; set; }
        public DbSet<VendedorModel> Vendedores { get; set; }
        public DbSet<ItemVendaModel> ItemVendas { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ItemVendaModel>().HasKey(x => new { x.Venda_Id, x.Produto_Id });

            builder.Entity<ItemVendaModel>()
                .HasOne(x => x.Venda)
                .WithMany(y => y.Produtos)
                .HasForeignKey(x => x.Venda_Id);

            builder.Entity<ItemVendaModel>()
                .HasOne(x => x.Produto)
                .WithMany(y => y.Vendas)
                .HasForeignKey(x => x.Produto_Id);
        }

    }
}
