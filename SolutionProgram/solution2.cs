using System;
using System.Linq;

namespace AdventOfCode.solutions
{
    public class solution2
    {
        public static readonly string dataPath = "B:\\OneDrive_Root\\OneDrive\\Documents\\Programming\\CSharp\\AdventOfCode\\SolutionProgram\\data\\day2input";
        public static readonly int[] integers;

        static solution2() {
            integers = getInputArray(dataPath);
        }

        public static int[] getInputArray(string path)
        {
            string[] integerStrings = System.IO.File.ReadAllText(dataPath).Split(',');
            int[] ints = (from singleString in integerStrings select int.Parse(singleString)).ToArray();
            return ints;
        }
    }

}