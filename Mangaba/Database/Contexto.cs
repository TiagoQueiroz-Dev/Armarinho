using Microsoft.EntityFrameworkCore;
using Armarinho.Models;

namespace Armarinho.Database;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
}