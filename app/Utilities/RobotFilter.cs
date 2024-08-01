using app.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Utilities;

public static class RobotFilter
{
    public static IEnumerable<RobotModel> FilterRobots(IEnumerable<RobotModel>? robots, string filterValue)
    {
        IEnumerable<RobotModel> filteredRobots = new List<RobotModel>();
        if (robots != null)
            if (filterValue == "Wszystkie")
                filteredRobots = new List<RobotModel>(robots);
            else
                filteredRobots = new List<RobotModel>(robots.Where(x => x.Name == filterValue));
        return filteredRobots;
    }
}
