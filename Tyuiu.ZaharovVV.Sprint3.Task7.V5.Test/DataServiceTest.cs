using Tyuiu.ZaharovVV.Sprint3.Task7.V5.Lib;

namespace Tyuiu.ZaharovVV.Sprint3.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] valueWaitArray = new double[stopValue - startValue + 1];
            valueWaitArray[0] = 70.14;
            valueWaitArray[1] = 55.21;
            valueWaitArray[2] = 41.05;
            valueWaitArray[3] = 27.96;
            valueWaitArray[4] = 15.48;
            valueWaitArray[5] = 1.0;
            valueWaitArray[6] = -13.06;
            valueWaitArray[7] = -28.16;
            valueWaitArray[8] = -42.96;
            valueWaitArray[9] = -56.77;
            valueWaitArray[10] = -69.83;
            CollectionAssert.AreEqual(dataService.GetMassFunction(startValue, stopValue), valueWaitArray);

        }
    }
}