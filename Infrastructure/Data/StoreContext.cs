using Core.Entity;

namespace Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class StoreContext : DbContext
{
    public StoreContext()
    {
    }
    
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }

    public DbSet<Fee> Fees { get; set; }
    public DbSet<Law> Laws { get; set; }
    public DbSet<LawCategory> LawCategories { get; set; }
}