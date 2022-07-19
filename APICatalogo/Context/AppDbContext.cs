using Microsoft.EntityFrameworkCore;
using APICatalogo.Models;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext
    {
        //Construtor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //Mapeamento das entidades
       
        public DbSet<Produto>? Produtos { get; set; }

    }
}
