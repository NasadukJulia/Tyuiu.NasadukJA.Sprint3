using Tyuiu.NasadukJA.Sprint3.Task3.V13.Lib;

namespace Tyuiu.NasadukJA.Sprint3.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string str = "?sd!! 5gh.s!";
            int res = ds.ConvertStringToInt(str);

            int wait = 5; 

            Assert.AreEqual(wait, res);
        }
    }
}
