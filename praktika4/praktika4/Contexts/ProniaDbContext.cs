using Microsoft.EntityFrameworkCore;
using praktika4.Models;

namespace praktika4.Contexts;

public class ProniaDbContext : DbContext
{
    public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
    {

    }

    public DbSet<Slider> Sliders { get; set; } = null!;
}
