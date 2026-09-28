using Tyuiu.KotlovaEA.Sprint1.Task4.V28.Lib;
namespace Tyuiu.KotlovaEA.Sprint1.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(0, 0);
            Assert.AreEqual(1.0, res, 0.001);
        }
    }
}
