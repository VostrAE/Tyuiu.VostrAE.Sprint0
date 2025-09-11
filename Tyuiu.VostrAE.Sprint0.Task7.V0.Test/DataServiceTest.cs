using Tyuiu.VostrAE.Sprint0.Task7.V0.Lib;
namespace Tyuiu.VostrAE.Sprint0.Task7.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void CheckAdditionValid() {
            int[] nums1 = new int[] { 1, 1, 1, 1, 1, };
            int[] nums2 = new int[] { 1, 1, 1, 1, 1, };
            int[] nums3 = new int[] { 2, 2, 2, 2, 2, };
            int[] res = DataService.AdditionArrays(nums1, nums2);
            CollectionAssert.AreEquivalent(nums3, res);
        } 
    }
}
