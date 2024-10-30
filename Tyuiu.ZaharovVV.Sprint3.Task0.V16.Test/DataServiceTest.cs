using Tyuiu.ZaharovVV.Sprint3.Task0.V16.Lib;
namespace Tyuiu.ZaharovVV.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesValid()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueStart = 1; int valueStop = 2;
            Assert.AreEqual(ds.GetMultiplySeries(value, valueStart, valueStop), 8);
        }
    }
}