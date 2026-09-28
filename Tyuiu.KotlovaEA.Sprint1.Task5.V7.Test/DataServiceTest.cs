using Tyuiu.KotlovaEA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KotlovaEA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double f = 90;
            int wait = 3;

            int res = ds.AngleToHoursMinutes(f);

            Assert.AreEqual(wait, res);
        }
    }
}
