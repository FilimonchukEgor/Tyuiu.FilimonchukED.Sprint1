using Tyuiu.FilimonchukED.Sprint1.Task5.V4.Lib;
namespace Tyuiu.FilimonchukED.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 8000;
            int wait = 2;
            var res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }
    }
}
