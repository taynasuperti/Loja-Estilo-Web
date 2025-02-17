using LojaEstiloWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaEstiloWeb.Data;
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
       {
       } 

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ProdutoFoto> ProdutoFotos { get; set; }
    }


// parte do código que vai implementar o Banco de Dados no projeto