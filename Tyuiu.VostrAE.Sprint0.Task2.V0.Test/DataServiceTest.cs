using System;

using Tyuiu.VostrAE.Sprint0.Task2.V0.Lib;
namespace Tyuiu.VostrAE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Саша";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Саша", res);
        }
    }
}
