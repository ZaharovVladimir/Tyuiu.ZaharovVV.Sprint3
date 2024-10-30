using Tyuiu.ZaharovVV.Sprint3.Task4.V20.Lib;

namespace Tyuiu.ZaharovVV.Sprint3.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;

            double res = ds.Calculate(startValue, endValue);

            double wait = 4.676;

            Assert.AreEqual(res, wait);

        }
    }
}