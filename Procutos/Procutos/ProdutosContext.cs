using Microsoft.EntityFrameworkCore;
using Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos
{
    public class ProdutosContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Setor> Setor { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public ProdutosContext(DbContextOptions<ProdutosContext> options)
            : base(options)
        {
            //irá criar o banco e a estrutura de tabelas necessárias
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().Property("SetorId");
            modelBuilder.Entity<Produto>().Property("CategoriaId");
            modelBuilder.Entity<Produto>().Property("MarcaId");
            

        }
    }
}
