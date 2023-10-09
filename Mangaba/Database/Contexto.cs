using Microsoft.EntityFrameworkCore;
using Mangaba.Models;

namespace Teste4.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}