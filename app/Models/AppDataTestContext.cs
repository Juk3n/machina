using app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class AppDataTestContext : DbContext
{
    public DbSet<RobotModel> Robots { get; set; }
    public DbSet<JobStatusModel> JobStatuses { get; set; }
    public DbSet<LoadInfoModel> LoadInfos { get; set; }
    public DbSet<LocalizationModel> Localizations { get; set; }
    public DbSet<PositionModel> Positions { get; set; }
    public DbSet<StatusModel> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("TestRobotsDb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public void SeedData()
    {
        Localizations.AddRange(
            new LocalizationModel
            {
                Id = 1,
                Name = "USM 201"
            }
        );

        Positions.AddRange(
            new PositionModel
            {
                Id = 1,
                Name = "safe"
            }
        );

        Statuses.AddRange(
            new StatusModel { Id = 1, Name = "working" },
            new StatusModel { Id = 2, Name = "busy" },
            new StatusModel { Id = 3, Name = "available" },
            new StatusModel { Id = 4, Name = "error" }
        );

        LoadInfos.AddRange(
            new LoadInfoModel { Id = 1, Name = "available" },
            new LoadInfoModel { Id = 2, Name = "docked" },
            new LoadInfoModel { Id = 3, Name = "dismissed" }
        );

        JobStatuses.AddRange(
            new JobStatusModel
            {
                Id = 1,
                Name = "working"
            }
        );
        SaveChanges();

        Robots.AddRange(
            new RobotModel
            {
                Id = 1,
                Name = "Chiron",
                Battery = 70,
                Localization = Localizations.ToList().ElementAt(0),
                Position = Positions.ToList().ElementAt(0),
                Status = Statuses.ToList().ElementAt(0),
                LoadInfo = LoadInfos.ToList().ElementAt(0),
                JobStatus = JobStatuses.ToList().ElementAt(0)
            },
            new RobotModel
            {
                Id = 2,
                Name = "Robot 1",
                Battery = 70,
                Localization = Localizations.ToList().ElementAt(0),
                Position = Positions.ToList().ElementAt(0),
                Status = Statuses.ToList().ElementAt(1),
                LoadInfo = LoadInfos.ToList().ElementAt(1),
                JobStatus = JobStatuses.ToList().ElementAt(0)
            },
            new RobotModel
            {
                Id = 3,
                Name = "Robot 2",
                Battery = 70,
                Localization = Localizations.ToList().ElementAt(0),
                Position = Positions.ToList().ElementAt(0),
                Status = Statuses.ToList().ElementAt(2),
                LoadInfo = LoadInfos.ToList().ElementAt(0),
                JobStatus = JobStatuses.ToList().ElementAt(0)
            },
            new RobotModel
            {
                Id = 4,
                Name = "Robot 3",
                Battery = 70,
                Localization = Localizations.ToList().ElementAt(0),
                Position = Positions.ToList().ElementAt(0),
                Status = Statuses.ToList().ElementAt(3),
                LoadInfo = LoadInfos.ToList().ElementAt(2),
                JobStatus = JobStatuses.ToList().ElementAt(0)
            }
        );
        SaveChanges();
    }
}
