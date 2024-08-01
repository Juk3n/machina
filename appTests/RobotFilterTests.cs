using app.Data.Repositories;
using app.Utilities;

namespace appTests
{
    [TestClass]
    public class RobotFilterTests
    {
        [TestMethod]
        public void BasicFiltering()
        {
            var robotToFilterIndex = 3;
            var repository = new TestRobotRepository();
            var robots = repository.GetAllRobots();
            var filtered = RobotFilter.FilterRobots(robots, robots.ElementAt(robotToFilterIndex).Name);
            Assert.AreEqual(robots.ElementAt(robotToFilterIndex), filtered.First());
        }
    }
}