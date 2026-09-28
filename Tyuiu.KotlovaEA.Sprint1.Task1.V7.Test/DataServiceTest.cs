using Tyuiu.KotlovaEA.Sprint1.Task1.V7.Lib;
namespace Tyuiu.KotlovaEA.Sprint1.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}
