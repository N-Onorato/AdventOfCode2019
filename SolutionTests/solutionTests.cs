using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.solutions;

namespace AdventOfCode.tests
{
    [TestClass]
    public class Solution_1_Tests
    {
        [DataTestMethod]
        [DataRow(12, 2)]
        [DataRow(14, 2)]
        [DataRow(1969, 654)]
        [DataRow(100756, 33583)]
        public void canCalculateFuelForModule(int val, int expected)
        {
            var fuelNeeded = solution1.calcFuelForModule(val);
            Assert.AreEqual(fuelNeeded, expected);
        }

        [TestMethod]
        public void canRetrieveInputData() {
            int value = solution1.getInputData();
            Assert.AreEqual(value, 50350);
        }
    }
}
