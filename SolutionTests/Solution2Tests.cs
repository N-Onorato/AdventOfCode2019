using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AdventOfCode.tests
{

    [TestClass]
    public class solution2Tests {

        [DataTestMethod]
        [DataRow(1, new int[] {1, 0, 0, 3})]
        [DataRow(2, new int[] {1, 1, 2, 3})]
        [DataRow(31, new int[] {0})]
        public void canRetrieveOpcode(int position, int[] expected) {
            IntCodeComputer myComputer = new IntCodeComputer(solutions.solution2.dataPath);
            int[] inputArray = myComputer.getInputArray();
            int[] opcode = myComputer.getOpcode(position);
            CollectionAssert.AreEquivalent(expected, opcode);
        }

        [TestMethod]
        public void canProcessOpcode() {
            int[] intCode = {1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50};
            IntCodeComputer myComputer = new IntCodeComputer(intCode);
            int[] expected = {3500, 9, 10, 70, 2, 3, 11, 0, 99, 30, 40, 50};
            myComputer.processIntCode();
            intCode = myComputer.getInputArray();
            CollectionAssert.AreEquivalent(expected, intCode);
        }
    }
}