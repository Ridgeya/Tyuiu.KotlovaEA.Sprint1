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

            int a = 5;
            int b = 3;
            int expected = 15;                              // 5 * 3 = 15
            int res = ds.CalculateRectangleSquare(a, b);

            Assert.AreEqual(expected, res);
        }
    }
}
