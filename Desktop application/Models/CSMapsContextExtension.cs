using Microsoft.EntityFrameworkCore;

namespace CSMaps.Models;

public partial class CSMapsContext : DbContext
{
    public CSMapsContext()
        : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string connectionString = "Data Source=localhost;AttachDbFilename=;Initial Catalog=CSMaps;User ID=sa;Password=Tai1802Pei;MultipleActiveResultSets=True;Connect Timeout=15;TrustServerCertificate=True;Application Name=;Workstation ID=NOTEBOOK-TOMAS;ConnectRetryCount=1;ConnectRetryInterval=10";
        optionsBuilder.UseSqlServer(connectionString);
    }
}