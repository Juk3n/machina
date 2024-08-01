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
    public static BindableCollection<RobotModel> FilterRobots(BindableCollection<RobotModel>? robots, string filterValue)
    {
        BindableCollection<RobotModel> filteredRobots = new BindableCollection<RobotModel>();
        if (robots != null)
            if (filterValue == "Wszystkie")
                filteredRobots = new BindableCollection<RobotModel>(robots);
            else
                filteredRobots = new BindableCollection<RobotModel>(robots.Where(x => x.Name == filterValue));
        return filteredRobots;
    }
}
