using Tyuiu.FilimonchukED.Sprint1.Task6.V2.Lib;
namespace Tyuiu.FilimonchukED.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strtest = "asdaoksojdasoHelloasdgdaha";
            var res = ds.CheckHello(strtest);
            Assert.IsTrue(res);
        }
    }
}
