using Microsoft.EntityFrameworkCore;
using PoteDeOuro.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoteDeOuro.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
                
        }

        /// <summary>
        /// Mapeando o banco de dados
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PedidoProduto>().HasKey(pp => new { pp.PedidoId, pp.ProdutoId });
            modelBuilder.Entity<PedidoProduto>().HasOne(pp => pp.Pedidos).WithMany(pp => pp.PedidoProdutos).HasForeignKey(pp => pp.PedidoId);
            modelBuilder.Entity<PedidoProduto>().HasOne(pp => pp.Produto).WithMany(pp => pp.PedidoProdutos).HasForeignKey(pp => pp.PedidoId);

            modelBuilder.Entity<Cliente>().HasOne(c => c.Endereco).WithMany(c => c.Clientes).HasForeignKey(c => c.EnderecoId);
            modelBuilder.Entity<Cliente>().HasMany(c => c.Pedidos).WithOne(c => c.Cliente);

            modelBuilder.Entity<Endereco>().HasMany(e => e.Clientes).WithOne(e => e.Endereco).HasForeignKey(e => e.EnderecoId);

            modelBuilder.Entity<Pedidos>().HasOne(p => p.Cliente).WithMany(p => p.Pedidos).HasForeignKey(p => p.PedidosId);


        }
    }
}
