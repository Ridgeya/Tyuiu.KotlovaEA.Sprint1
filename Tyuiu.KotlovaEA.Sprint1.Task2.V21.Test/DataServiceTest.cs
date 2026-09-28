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
            int value = 5;
            int valueTwo = 3;
            int wait = 15;
            int res = ds.CalculateRectangleSquare(value, valueTwo);
            Assert.AreEqual(wait, res);
        }
    }
}
