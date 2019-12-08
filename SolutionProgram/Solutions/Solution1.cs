using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AdventOfCode.solutions
{

    public static class solution1
    {
        public const string dataPath = "B:\\OneDrive_Root\\OneDrive\\Documents\\Programming\\CSharp\\AdventOfCode\\SolutionProgram\\data\\day1input";

        public static string getAnswer() {
            var inputs = getInputAsEnum(dataPath);
            int sum = (from input in inputs select calcFuelForModule(int.Parse(input))).Sum();
            return sum.ToString();
        }

        public static int calcFuelForModule(int mass)
        {
            return mass / 3 - 2;
        }
        
        public static List<int> getInputDataAsList()
        {
            IEnumerable<string> inputStrings = getInputAsEnum(dataPath);
            return (from input in inputStrings select int.Parse(input)).ToList();
        }

        public static IEnumerable<string> getInputAsEnum(string path)
        {
            return File.ReadLines(path);
        }
    }

}