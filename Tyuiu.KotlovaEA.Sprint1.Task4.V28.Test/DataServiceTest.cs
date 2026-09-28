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
            double x = 0;
            double y = 0;
            double wait = 1.0;                    
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
