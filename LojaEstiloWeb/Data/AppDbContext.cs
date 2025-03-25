using LojaEstiloWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LojaEstiloWeb.Data;
    public class AppDbContext : IdentityDbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
       {
       } 

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ProdutoFoto> ProdutoFotos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityUser>().ToTable("Usuario");
        //para criar um padrão para as tabelas do banco e não deixar o nome extenso (como é o padrão)
        builder.Entity<IdentityRole>().ToTable("Perfil");
        builder.Entity<IdentityUserRole<string>>().ToTable("UsuarioPerfil");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UsuarioRegras");
        builder.Entity<IdentityUserToken<string>>().ToTable("UsuarioToken");
        // Token é chave de identificação do usuário (códigos de verificação)
        builder.Entity<IdentityUserLogin<string>>().ToTable("UsuarioLogin");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("PerfilRegras");

        AppDbSeed seed = new(builder);
    }
    //configuração do banco
}


// parte do código que vai implementar o Banco de Dados no projeto