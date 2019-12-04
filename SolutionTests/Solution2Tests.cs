using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;
using System.Collections.Generic;


namespace AdventOfCode.tests {

    [TestClass]
    public class solution2Tests {

        [TestMethod]
        public void canGetInputArray() {
            int[] inputArray = solutions.solution2.getInputArray(solutions.solution2.dataPath);
            Assert.AreEqual(121, inputArray.Length);
        }

    }
}