using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Data.Repositories;

public interface IRobotRepository
{
    Task<IEnumerable<RobotModel>> GetAllRobotsAsync();
    IEnumerable<RobotModel> GetAllRobots();
}
