using app.Data.Repositories;
using app.Models;
using app.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace appTests
{
    [TestClass]
    public class RobotFilterTests
    {
        [TestMethod]
        public async Task BasicFiltering()
        {
            var context = new AppDataTestContext();
            context.SeedData();

            var repository = new TestRobotRepository(context);


            var robotToFilterIndex = 3;
            var robots = await repository.GetAllRobotsAsync();
            var filtered = RobotFilter.FilterRobots(robots, robots.ElementAt(robotToFilterIndex).Name);
            Assert.AreEqual(robots.ElementAt(robotToFilterIndex), filtered.First());
        }
    }
}