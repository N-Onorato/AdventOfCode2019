using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.solutions;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.tests
{

    public class Helpers {
        public static string printArray(int[] numbers) {
            string result = "";
            foreach (int num in numbers)
            {
                result += num.ToString() + ", ";
            }
            result += "\n";
            return result;
        }
    }

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
            List<int> inputs = solution1.getInputDataAsList();
            Assert.AreEqual(inputs[0], 50350);
            Assert.AreEqual(inputs[1], 104487);
            Assert.AreEqual(inputs[2], 101866);
        }
    }

    [TestClass]
    public class Solution_2_Tests {

        [TestMethod]
        public void canCalcZeroFuel() {
            var fuel = solution1p2.calcFuelValues(0);
            Assert.AreEqual(fuel.FirstOrDefault(), 0);
            Assert.AreEqual(fuel.LastOrDefault(), 0);
        }

        [TestMethod]
        public void canCalcTwoFuel() {
            var fuel = solution1p2.calcFuelValues(2);
            Assert.AreEqual(fuel.FirstOrDefault(), 0);
            Assert.AreEqual(fuel.LastOrDefault(), 0);
        }

        [TestMethod]
        public void canCalcSixFuel() {
            var fuel = solution1p2.calcFuelValues(6);
            Assert.AreEqual(fuel.FirstOrDefault(), 0);
            Assert.AreEqual(fuel.LastOrDefault(), 0);
        }

        [TestMethod]
        public void canCalcNineFuel() {
            var fuel = solution1p2.calcFuelValues(9);
            Assert.AreEqual(1, fuel.Count());
            Assert.AreEqual(1, fuel.FirstOrDefault());
            Assert.AreEqual(1, fuel.LastOrDefault());
        }

        [DataTestMethod]
        [DataRow(2, new int[0] {})]
        [DataRow(12, new int[1] {2})]
        [DataRow(654, new int[4] {216, 70, 21, 5})]
        [DataRow(33583, new int[8] {11192, 3728, 1240, 411, 135, 43, 12, 2})]
        public void canGenerateRecursiveFuel(int input, int[] expected) {
            var fuelValues = solution1p2.calcFuelValues(input);
            var asArray = (from fuel in fuelValues select fuel).ToArray();
            Assert.AreEqual(expected.Length, asArray.Length, $"{Helpers.printArray(asArray) } vs. {Helpers.printArray(expected)}");
            CollectionAssert.AreEquivalent(expected, asArray);
        }

        [TestMethod]
        public void modulesAndFuelCalcCorrectly() {
            var fuelforModule = solution1.calcFuelForModule(1969);
            var fuelForFuel = solution1p2.calcFuelValues(fuelforModule).Sum();
            Assert.AreEqual(966, fuelforModule + fuelForFuel);
        }

        [TestMethod]
        public void canCalculateUsingCorrectFuel() {
            var fuelforModule = 3212842;
            var fuelForFuel = solution1p2.calcFuelValues(fuelforModule).Sum();
            Assert.AreEqual(4819221, fuelforModule + fuelForFuel);
        }
    }
}
