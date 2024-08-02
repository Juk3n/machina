using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class RobotModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Battery { get; set; }
    public LocalizationModel Localization { get; set; }
    public PositionModel Position { get; set; }
    public StatusModel Status { get; set; }
    public LoadInfoModel LoadInfo { get; set; }
    public JobStatusModel JobStatus { get; set; }
}
