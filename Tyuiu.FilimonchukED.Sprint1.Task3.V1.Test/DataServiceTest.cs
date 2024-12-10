using Tyuiu.FilimonchukED.Sprint1.Task3.V1.Lib;
namespace Tyuiu.FilimonchukED.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 3;
            double wait = 37.68;
            var res = ds.Calculate(r, h);
        }
    }
}