using Microsoft.EntityFrameworkCore;

namespace CSMaps.Models;

#pragma warning disable MA0048 // File name must match type name
public partial class CSMapsContext : DbContext
#pragma warning restore MA0048 // File name must match type name
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