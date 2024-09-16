namespace Tyuiu.BushljaJV.Sprint0.Task3.V0.Text
{
    using Tyuiu.BushljaJV.Sprint0.Task3.V0.Lib;
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}