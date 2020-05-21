using Microsoft.VisualStudio.TestTools.UnitTesting;
using PifPafPloufProject;

namespace PifafTest
{
    [TestClass]
    public class TddTest
    {
        readonly PifPafPlouf PifPafPlouf = new PifPafPlouf();
        [TestMethod]
        public void ShouldbenumberIfNumberIsnot3or4orMultiples()
        {
            Assert.AreEqual("1", PifPafPlouf.SuitElementFromNumber(1));
            Assert.AreEqual("2", PifPafPlouf.SuitElementFromNumber(2));
        }

        [TestMethod]
        public void ShouldbePifIfNumberIs3orMultiple()
        {
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3));
        }

        [TestMethod]
        public void ShouldbePafIfNumberIs4orMultiple()
        {
            Assert.AreEqual("Paf", PifPafPlouf.SuitElementFromNumber(4));
        }
    }
}
