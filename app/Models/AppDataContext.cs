using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class AppDataContext : DbContext
{
    public DbSet<RobotModel> Robots { get; set; }
    public DbSet<JobStatusModel> JobStatuses { get; set; }
    public DbSet<LoadInfoModel> LoadInfos { get; set; }
    public DbSet<LocalizationModel> Localizations { get; set; }
    public DbSet<PositionModel> Positions { get; set; }
    public DbSet<StatusModel> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=RobotsDb;Trusted_Connection=True;TrustServerCertificate=true;");
    }
}
