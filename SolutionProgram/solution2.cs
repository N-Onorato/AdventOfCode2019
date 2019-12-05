using System;

namespace AdventOfCode.solutions
{

    public class solution2
    {
        public const string dataPath = "B:\\OneDrive_Root\\OneDrive\\Documents\\Programming\\CSharp\\AdventOfCode\\SolutionProgram\\data\\day2input";
        internal int[] integers;

        private static IntCodeComputer computer;

        static solution2() {
            computer = new IntCodeComputer(dataPath);
        }

        public static string getAnswer() {
            computer.setCodeElement(1, 12);
            computer.setCodeElement(2, 2);
            computer.processIntCode();
            return computer.getOutput().ToString();
        }

    }

}