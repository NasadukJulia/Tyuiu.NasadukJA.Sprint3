using Tyuiu.NasadukJA.Sprint3.Task4.V8.Lib;

namespace Tyuiu.NasadukJA.Sprint3.Task4.V8.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 2237.227; 

            Assert.AreEqual(wait, res);
        }
    }
}
