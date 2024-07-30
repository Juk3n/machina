using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class AppDataContext : DbContext
{
    public DbSet<Robot> Robots { get; set; }
    public DbSet<JobStatus> JobStatuses { get; set; }
    public DbSet<LoadInfo> LoadInfos { get; set; }
    public DbSet<Localization> Localizations { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=RobotsDb;Trusted_Connection=True;TrustServerCertificate=true;");
    }
}
