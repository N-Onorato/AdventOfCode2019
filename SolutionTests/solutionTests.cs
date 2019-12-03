using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.solutions;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.tests
{
    [TestClass]
    public static class Solution_1_Tests
    {
        [DataTestMethod]
        [DataRow(12, 2)]
        [DataRow(14, 2)]
        [DataRow(1969, 654)]
        [DataRow(100756, 33583)]
        public static void canCalculateFuelForModule(int val, int expected)
        {
            var fuelNeeded = solution1.calcFuelForModule(val);
            Assert.AreEqual(fuelNeeded, expected);
        }

        [TestMethod]
        public static void canRetrieveInputData() {
            List<int> inputs = solution1.getInputDataAsList();
            Assert.AreEqual(inputs[0], 50350);
            Assert.AreEqual(inputs[1], 104487);
            Assert.AreEqual(inputs[2], 101866);
        }
    }

    [TestClass]
    public static class Solution_2_Tests {

        [TestMethod]
        public static void canGenerateRecursiveFuel() {
            var fuelValues = solution2.calcFuelValues(2);
            var toArray = (from fuel in fuelValues select fuel).ToArray();
            Assert.AreEqual(fuelValues, System.Array.Empty<int>());
        }
    }
}
