using Microsoft.EntityFrameworkCore;
using LojaEstoqueApi.Models;

namespace LojaEstoqueApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}