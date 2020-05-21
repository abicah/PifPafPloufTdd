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
            Assert.AreEqual("5", PifPafPlouf.SuitElementFromNumber(5));
            Assert.AreEqual("7", PifPafPlouf.SuitElementFromNumber(7));
        }

        [TestMethod]
        public void ShouldbePifIfNumberIs3orMultipleAnNot12Multipple()
        {
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 1));
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 2));
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 3));
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 5));
            Assert.AreEqual("Pif", PifPafPlouf.SuitElementFromNumber(3 * 6));

        }

        [TestMethod]
        public void ShouldbePafIfNumberIs4orMultipleAndnot12Multiple()
        {
            Assert.AreEqual("Paf", PifPafPlouf.SuitElementFromNumber(4 * 1));
            Assert.AreEqual("Paf", PifPafPlouf.SuitElementFromNumber(4 * 2));
            Assert.AreEqual("Paf", PifPafPlouf.SuitElementFromNumber(4 * 4));
            Assert.AreEqual("Paf", PifPafPlouf.SuitElementFromNumber(4 * 5));
        }

        [TestMethod]
        public void ShouldbePloufIfNumberIs12orMultiple()
        {
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 1));
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 2));
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 3));
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 4));
            Assert.AreEqual("Plouf", PifPafPlouf.SuitElementFromNumber(12 * 5));
        }

    }
}
