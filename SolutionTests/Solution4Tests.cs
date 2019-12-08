using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;
using System.Collections.Generic;


namespace AdventOfCode.tests {

    [TestClass]
    public class solution4 {

        [DataTestMethod]
        [DataRow(5, false)]
        [DataRow(137777, true)]
        [DataRow(223450, false)]
        [DataRow(677777, true)]
        public void validatorWorks(int number, bool expected) {
            Assert.AreEqual(expected, solutions.solution4.isValidNumber(number));
        }

        [DataTestMethod]
        [DataRow(345567, true)]
        [DataRow(137889, true)]
        [DataRow(445555, true)]
        [DataRow(137789, true)]
        [DataRow(334455, true)]
        [DataRow(677777, false)]
        [DataRow(455567, false)]
        [DataRow(445678, true)]
        [DataRow(456788, true)]
        public void validatorWorksV2(int number, bool expected) {
            Assert.AreEqual(expected, solutions.solution4p2.isValidNumberV2(number));
        }

    }

}