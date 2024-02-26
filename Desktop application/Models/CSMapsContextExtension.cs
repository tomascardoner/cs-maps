using Microsoft.EntityFrameworkCore;

namespace CSMaps.Models;

public partial class CSMapsContext : DbContext
{
    public static string ConnectionString { get; set; }

    public CSMapsContext()
        : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }
}