using Tyuiu.FilimonchukED.Sprint1.Task0.V22.Lib;
namespace Tyuiu.FilimonchukED.Sprint1.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(10, res);
        }
    }
}