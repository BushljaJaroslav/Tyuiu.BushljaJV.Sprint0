namespace Tyuiu.BushljaJV.Sprint0.Task7.V0.Test
{
    using Tyuiu.BushljaJV.Sprint0.Task7.V0.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int[] nums1 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums2 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums3 = new int[] { 2, 2, 2, 2, 2 };

            int[] res = DataService.AddirionArrays(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);
             
        }
    }
}