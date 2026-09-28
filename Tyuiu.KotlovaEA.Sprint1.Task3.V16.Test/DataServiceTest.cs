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
            double x1 = 2;
            double x2 = 3;
            double expected = -5;
            double res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(expected, res, 0.001);
        }
    }
}
