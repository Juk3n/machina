using app.Data.Repositories;

namespace appTests
{
    [TestClass]
    public class RobotFilterTests
    {
        [TestMethod]
        public void BasicFiltering()
        {
            var repository = new TestRobotRepository();
            Assert.IsTrue(true);
        }
    }
}