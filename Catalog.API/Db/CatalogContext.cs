using Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Db;

public class CatalogContext : DbContext
{
    public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

    public DbSet<Product> Products { get; set; }
}