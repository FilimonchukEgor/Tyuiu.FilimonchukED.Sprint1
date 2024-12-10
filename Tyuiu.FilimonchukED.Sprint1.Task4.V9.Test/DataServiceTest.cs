using Tyuiu.FilimonchukED.Sprint1.Task4.V9.Lib;
namespace Tyuiu.FilimonchukED.Sprint1.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = -5.872437150528495;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
