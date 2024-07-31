using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class RobotModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Battery { get; set; }
    public required LocalizationModel Localization { get; set; }
    public required PositionModel Position { get; set; }

    public required StatusModel Status { get; set; }
    public required LoadInfoModel LoadInfo { get; set; }
    public required JobStatusModel JobStatus { get; set; }

    public RobotModel() 
    { 
    }

}
