using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;
using System.Collections.Generic;


namespace AdventOfCode.tests {


    [TestClass] 
    public class partOneTests {
        
        [TestMethod]
        public void canAddWireToGrid()
        {
            Grid myGrid = new Grid();
            myGrid.addWire("U4,R5,D250");
            myGrid.addWire("L5,D32,R100");
            Assert.AreEqual(1, myGrid.numOfIntersects);
            var nearestIntersection = myGrid.getClosestIntersection();
            int distance = GetDistanceFromKey(nearestIntersection);
            Assert.AreEqual(37, distance);
        }

        [DataTestMethod]
        [DataRow("U30", 30)]
        [DataRow("R30", 30)]
        [DataRow("D30", 30)]
        [DataRow("L30", 30)]
        [DataRow("R30,L30", 31)]
        public void wiresAreProperLength(string wireDef, int expected) {
            Grid basicGrid = new Grid();
            basicGrid.addWire(wireDef);
            int count = basicGrid.getNumberOfCells();
            Assert.AreEqual(expected, count);
        }

        [DataTestMethod]
        [DataRow("R8,U5,L5,D3", "U7,R6,D4,L4", 6)]
        [DataRow("R75,D30,R83,U83,L12,D49,R71,U7,L72","U62,R66,U55,R34,D71,R55,D58,R83", 159)]
        [DataRow("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51","U98,R91,D20,R16,D67,R40,U7,R15,U6,R7", 135)]
        public void canMatchExampleData(string firstWire, string secondWire, int expectedDistance) {
            Grid testGrid = new Grid();
            testGrid.addWire(firstWire);
            testGrid.addWire(secondWire);
            var intersection = testGrid.getClosestIntersection();
            int distance = GetDistanceFromKey(intersection);
            Assert.AreEqual(expectedDistance, distance);
        }

        [TestMethod]
        public void CanCreateDifferentGrids() {
            Grid secondGrid = new Grid();
            secondGrid.addWire("U5,L10");
            secondGrid.addWire("D5,L9");
            secondGrid.addWire("R1,D8,L5,U30");
            var nearestIntersection = secondGrid.getClosestIntersection();
            int distance = GetDistanceFromKey(nearestIntersection);
            Assert.AreEqual(9, distance);
        }


        private static int GetDistanceFromKey(KeyValuePair<(int, int), GridPoint> nearestIntersection)
        {
            return System.Math.Abs(nearestIntersection.Key.Item1) + System.Math.Abs(nearestIntersection.Key.Item2);
        }
    }

}