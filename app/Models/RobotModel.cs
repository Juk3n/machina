using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class RobotModel
{
    public RobotModel(int id, string name, int battery, LocalizationModel localization, PositionModel position, StatusModel status, LoadInfoModel loadInfo, JobStatusModel jobStatus)
    {
        Id = id;
        Name = name;
        Battery = battery;
        Localization = localization;
        Position = position;
        Status = status;
        LoadInfo = loadInfo;
        JobStatus = jobStatus;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Battery { get; set; }
    public LocalizationModel Localization { get; set; }
    public PositionModel Position { get; set; }

    public StatusModel Status { get; set; }
    public LoadInfoModel LoadInfo { get; set; }
    public JobStatusModel JobStatus { get; set; }

}
