using Tyuiu.KotlovaEA.Sprint1.Task6.V13.Lib;
namespace Tyuiu.KotlovaEA.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "abc";
            DataService ds = new DataService();
            bool res = ds.CheckWordsAlphabet(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
