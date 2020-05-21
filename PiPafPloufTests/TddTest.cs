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
        }
    }
}
