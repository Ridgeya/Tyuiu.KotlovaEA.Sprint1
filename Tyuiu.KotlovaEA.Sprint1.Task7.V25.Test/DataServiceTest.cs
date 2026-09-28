using Tyuiu.KotlovaEA.Sprint1.Task7.V25.Lib;
namespace Tyuiu.KotlovaEA.Sprint1.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 0;
            double expected = 5.431;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(expected, res, 0.001);
        }
    }
}
