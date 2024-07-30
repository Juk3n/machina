using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class Robot
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Battery { get; set; }
    public required Localization Localization { get; set; }
    public required Position Position { get; set; }

    public required Status Status { get; set; }
    public required LoadInfo LoadInfo { get; set; }
    public required JobStatus JobStatus { get; set; }

}
