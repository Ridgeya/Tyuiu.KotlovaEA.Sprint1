using Tyuiu.KotlovaEA.Sprint1.Task3.V16.Lib;
namespace Tyuiu.KotlovaEA.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.CoeffOfQuadraticEquation(2, 3);
            Assert.AreEqual(-5.0, res, 0.001);
        }
    }
}
