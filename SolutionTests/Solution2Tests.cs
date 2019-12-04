using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;
using System.Collections.Generic;


namespace AdventOfCode.tests {

    [TestClass]
    public class solution2Tests {

        [DataTestMethod]
        [DataRow(1, new int[] {1, 0, 0, 3})]
        [DataRow(2, new int[] {1, 1, 2, 3})]
        [DataRow(31, new int[] {0})]
        public void canRetrieveOpcode(int position, int[] expected) {
            int[] inputArray = solutions.solution2.getInputArray(solutions.solution2.dataPath);
            int[] opcode = solutions.solution2.getOpcode(inputArray, position);
            CollectionAssert.AreEquivalent(expected, opcode);
        }

        [TestMethod]
        public void canProcessOpcode() {
            int[] intCode = {1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50};
            int[] expected = {3500, 9, 10, 70, 2, 3, 11, 0, 99, 30, 40, 50};
            intCode = solutions.solution2.processIntCode(intCode);
            CollectionAssert.AreEquivalent(expected, intCode);
        }
    }
}