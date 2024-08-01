using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Data.Repositories;

public class TestRobotRepository : IRobotRepository
{
    public Task<IEnumerable<RobotModel>> GetAllRobotsAsync()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<RobotModel> GetAllRobots()
    {
        var robots = new List<RobotModel>();

        robots.Add(new RobotModel(
            id: 0,
            name: "Chiron",
            battery: 70,
            localization: new LocalizationModel(id: 0, name: "USM 201"),
            position: new PositionModel(id: 0, name: "safe"),
            status: new StatusModel(id: 0, name: "working"),
            loadInfo: new LoadInfoModel(id: 0, name: "available"),
            jobStatus: new JobStatusModel(id: 0, name: "working")
        ));

        robots.Add(new RobotModel(
            id: 1,
            name: "Robot 1",
            battery: 70,
            localization: new LocalizationModel(id: 0, name: "USM 201"),
            position: new PositionModel(id: 0, name: "safe"),
            status: new StatusModel(id: 1, name: "busy"),
            loadInfo: new LoadInfoModel(id: 1, name: "docked"),
            jobStatus: new JobStatusModel(id: 0, name: "working")
        ));

        robots.Add(new RobotModel(
            id: 2,
            name: "Robot 2",
            battery: 70,
            localization: new LocalizationModel(id: 0, name: "USM 201"),
            position: new PositionModel(id: 0, name: "safe"),
            status: new StatusModel(id: 2, name: "available"),
            loadInfo: new LoadInfoModel(id: 0, name: "available"),
            jobStatus: new JobStatusModel(id: 0, name: "working")
        ));

        robots.Add(new RobotModel(
            id: 3,
            name: "Robot 3",
            battery: 70,
            localization: new LocalizationModel(id: 0, name: "USM 201"),
            position: new PositionModel(id: 0, name: "safe"),
            status: new StatusModel(id: 3, name: "error"),
            loadInfo: new LoadInfoModel(id: 0, name: "dismissed"),
            jobStatus: new JobStatusModel(id: 0, name: "working")
        ));
        return robots;
    }
}
