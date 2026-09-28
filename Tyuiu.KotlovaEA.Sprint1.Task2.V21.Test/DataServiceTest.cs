using Tyuiu.KotlovaEA.Sprint1.Task2.V21.Lib;
namespace Tyuiu.KotlovaEA.Sprint1.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.CalculateRectangleSquare(5, 3);
            Assert.AreEqual(15, res);
        }
    }
}
