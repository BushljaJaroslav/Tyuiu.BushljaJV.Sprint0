namespace Tyuiu.BushljaJV.Sprint0.Task6.V0.Test
{
    using Tyuiu.BushljaJV.Sprint0.Task6.V0.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAddititonArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstractionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(16, res);
        }
    }
}